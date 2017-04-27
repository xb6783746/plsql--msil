using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.Codegeneration;
using plsql_msil.Semantic;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Loggers;
using plsql_msil.Optimization;
using plsql_msil.TypeLoader;

/*
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.ClassNodes;
*/
namespace plsql_msil
{

    class Program
    {

        private static bool printTree;
        private static bool all;
        private static string printTreeFile;
        private static string outFile;

        private static List<string> sourceFiles = new List<string>();
        private static List<string> libs = new List<string>();

        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                string message =
@"
Аргументы не заданы.
Обязательные команды:
    -src (path)+  задает пути к файлам, которые необходимо скомпилировать
Опцинально:
    -libs (path)+  задает пути к библиотекам
    -all
    -out path   выводит сообщения в файл с данным путем, по умолчанию - в консоль
    -tree (path)?   выводит дерево в консоль, если path не задан, иначе - в файл с данным путем;
    по умолчанию дерево не выводится
";

                Console.WriteLine(message);

                return;
            }

            var helper = new ConsoleHelper();
            helper.Register("tree", TreeOut);
            helper.Register("src", SourceFiles);
            helper.Register("out", OutFile);
            helper.Register("libs", Libs);
            helper.Register("all", All);

            try
            {
                helper.Parse(args);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                return;
            }

            if(sourceFiles.Count == 0)
            {
                Console.WriteLine("Файлы для компиляции не заданы");

                return;
            }

            var nameConvertor = new CSNameConvertor();
            var typeLoader = new StandardLibraryTypesLoader(nameConvertor);
            var typeStorage = typeLoader.Load(libs);

            ILogger logger = GetLogger(outFile);
            ILogger treeLogger = null;

            if(printTree)
            {
                treeLogger = GetLogger(printTreeFile);
            }

            if (all)
            {
                CompileAll(sourceFiles, typeStorage.Clone(), logger, treeLogger, nameConvertor);
            }
            else
            {
                foreach (var item in sourceFiles)
                {
                    CompileFile(item, typeStorage.Clone(), logger, treeLogger, nameConvertor);
                }
            }

        }

        private static void CompileFile(Stream fileStream, string path, TypeStorage typeStorage, ILogger logger, ILogger treeLogger, INameConvertor nameConvertor)
        {

            logger.Log(String.Format("----Файл {0}----", path));

            var stream = new ANTLRInputStream(fileStream);
            var lexer = new PlsqlLexer(stream);
            var parser = new PlsqlParser(new CommonTokenStream(lexer));
            var tree = parser.program().Tree as CommonTree;

            if (treeLogger != null)
            {
                treeLogger.Log(ASTPrinter.Print(tree));
            }

            var semanticAnalyser = new SemanticAnalyser(typeStorage);
            bool res = semanticAnalyser.Check(tree, logger);

            if (res)
            {
                var optimizer = new Optimizer();
                optimizer.Optimize(tree, logger);

                var codegenerator = new Codegenerator(nameConvertor);
                string code = codegenerator.Generate(tree, typeStorage);

                using (var writer = new StreamWriter(path + ".il"))
                {
                    writer.Write(code);
                }

            }

            logger.Log(string.Format("--------", path));
        }

        private static void CompileFile(string path, TypeStorage typeStorage, ILogger logger, ILogger treeLogger, CSNameConvertor nameConvertor)
        {
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                CompileFile(fileStream, path, typeStorage, logger, treeLogger, nameConvertor);
            }
        }
        private static void CompileAll(List<string> files, TypeStorage typeStorage, ILogger logger, ILogger treeLogger, CSNameConvertor nameConvertor)
        {
            using (var memoryStream = new MemoryStream())
            using (var fileWriter = new StreamWriter(memoryStream))
            {             

                foreach (var item in files)
                {
                    using (var fileStream = new StreamReader(item))
                    {
                        fileWriter.WriteLine(fileStream.ReadToEnd());

                        fileWriter.Flush();
                    }
                }

                memoryStream.Position = 0;

                CompileFile(memoryStream, "out", typeStorage, logger, treeLogger, nameConvertor);
            }
        }

        private static void TreeOut(List<string> args)
        {
            printTree = true;

            if (args.Count > 0)
            {
                printTreeFile = args[0];
            }
        }
        private static void Libs(List<string> args)
        {
            if (args.Count == 0)
            {
                throw new Exception("Не заданы пути библиотек");
            }

            libs.AddRange(args);
        }
        private static void All(List<string> args)
        {
            all = true;
        }

        private static void OutFile(List<string> args)
        {
            if (args.Count > 0)
            {
                outFile = args[0];
            }
        }
        private static void SourceFiles(List<string> args)
        {
            if(args.Count == 0)
            {
                throw new Exception("Файлы с исходным кодом не определены");
            }

            sourceFiles.AddRange(args);
        }

        private static ILogger GetLogger(string path)
        {
            if(path == null)
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
