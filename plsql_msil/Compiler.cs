using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsqlBasic.Loggers;
using plsqlSemanticAnalyser.Semantic;
using plsql_msil.Codegeneration;
using plsql_msil.Optimization;
using plsql_msil.TypeLoader;
using plsql_msil.Types;

namespace plsql_msil
{
    class Compiler
    {


        public void Compile(CompilerArgs args)
        {

            if (args.SourceFiles.Count == 0)
            {
                Console.WriteLine("Файлы для компиляции не заданы");

                return;
            }

            var nameConvertor = new CSNameConvertor();
            var typeLoader = new StandardLibraryTypesLoader(nameConvertor);
            var typeStorage = typeLoader.Load(args.Libs);

            ILogger logger = GetLogger(args.OutFile);
            ILogger treeLogger = GetLogger(args.PrintTreeFile);

            var tree = Parse(args.SourceFiles);
            var node = Combine(tree);

            if (args.PrintTree)
            {
                treeLogger.Log(ASTPrinter.Print(node));
            }

            bool ok = Analyze(node, typeStorage, logger);

            if (!ok)
            {
                Console.ReadLine();
                return;
            }

            Optimize(node);

            string code = Generate(node, nameConvertor, typeStorage);

            Write(args.OutFile, code);

        }

        private static void CompileFile(Stream fileStream, string fileName, StreamWriter outStream, TypeStorage typeStorage,
            ILogger logger, ILogger treeLogger, INameConvertor nameConvertor)
        {

            logger.Log(String.Format("----Файл {0}----", fileName));

            var stream = new ANTLRInputStream(fileStream);
            var lexer = new PlsqlLexer(stream);
            var parser = new PlsqlParser(new CommonTokenStream(lexer));
            var tree = parser.program().Tree as CommonTree;

            if (treeLogger != null)
            {
                treeLogger.Log(ASTPrinter.Print(tree));
            }

            var semanticAnalyser = new SemanticAnalyser(typeStorage, logger);
            bool res = semanticAnalyser.Check(tree);


            if (res)
            {
                var optimizer = new Optimizer();
                optimizer.Optimize(tree);

                var codegenerator = new Codegenerator(nameConvertor);
                string code = codegenerator.Generate(tree, typeStorage);

                outStream.Write(code);

            }

            logger.Log(string.Format("--------", fileName));
        }

        private static void CompileFile(string path, string outPath, TypeStorage typeStorage, 
            ILogger logger, ILogger treeLogger, CSNameConvertor nameConvertor)
        {
            using (var fileStream = new FileStream(path, FileMode.Open))
            using (var outStream = new StreamWriter(outPath))
            {
                CompileFile(fileStream, path, outStream, typeStorage, logger, treeLogger, nameConvertor);
            }
        }
        private static void CompileAll(List<string> files, TypeStorage typeStorage, 
            ILogger logger, ILogger treeLogger, CSNameConvertor nameConvertor)
        {
            using (var fileWriter = new StreamWriter("out.il"))
            {

                foreach (var item in files)
                {
                    using (var fileStream = new FileStream(item, FileMode.Open))
                    {
                        CompileFile(fileStream, item, fileWriter,typeStorage, logger, treeLogger, nameConvertor);
                    }
                }
                
            }
        }

        private List<SourceFile> Parse(List<string> files)
        {
            var res = new List<SourceFile>();

            foreach (var item in files)
            {
                using(var fileStream = new FileStream(item, FileMode.Open))
                {
                    var stream = new ANTLRInputStream(fileStream);
                    var lexer = new PlsqlLexer(stream);
                    var parser = new PlsqlParser(new CommonTokenStream(lexer));
                    var tree = parser.program().Tree as CommonTree;

                    res.Add(new SourceFile(item, tree));
                }
            }

            return res;
        }

        private bool Analyze(CommonTree tree, TypeStorage types, ILogger logger)
        {

            var semanticAnalyser = new SemanticAnalyser(types, logger);

            return semanticAnalyser.Check(tree);
        }


        private void Optimize(CommonTree tree)
        {

            var optimizer = new Optimizer();
            optimizer.Optimize(tree);
        }

        private string Generate(CommonTree tree, INameConvertor nameConvertor, TypeStorage types)
        {
            var codegenerator = new Codegenerator(nameConvertor);
            return codegenerator.Generate(tree, types);
        }

        private void Write(string file, string code)
        {
            using (var writer = new StreamWriter(file))
            {
                writer.WriteLine(code);
            }
        }

        private CommonTree Combine(List<SourceFile> sourceFiles)
        {
            var root = new CommonTree(new CommonToken(0, ""));

            foreach (var item in sourceFiles)
            {
                foreach (var node in item.Tree.Children)
                {
                    root.AddChild(node);
                }
            }

            return root;
        }

        private static ILogger GetLogger(string path)
        {
            if (path == null)
            {
                return new ConsoleLogger();
            }
            else
            {
                return new FileLogger(path);
            }
        }
    }
}
