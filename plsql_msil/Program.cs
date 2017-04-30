using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsqlBasic.Loggers;
using plsqlSemanticAnalyser.Semantic;
using plsql_msil.Codegeneration;
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
            helper.Register("tree", TreeOut)
                .Register("src", SourceFiles)
                .Register("out", OutFile)
                .Register("libs", Libs)
                .Register("all", All);

            try
            {
                helper.Parse(args);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

                return;
            }

            var compiler = new Compiler();
            var compilerArgs = new CompilerArgs(
                libs, 
                sourceFiles, 
                printTree, 
                printTreeFile, 
                outFile, 
                all); 

            compiler.Compile(compilerArgs);
           


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
