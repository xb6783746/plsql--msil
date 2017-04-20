using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Loggers;
using plsql_msil.Types;

namespace plsql_msil.Semantic.Passes
{
    enum LogLevel
    {
        Warning, Error, Info
    }
    class TypeBuilder :Analyser, IPass
    {
        public TypeBuilder(TypeStorage types)
        {
            this.types = types;
        }

        public bool Check(CommonTree tree, ILogger logger)
        {
            this.logger = logger;

            foreach(dynamic node in tree.Children)
            {
                if (node is ClassDeclNode || node is PackageDeclNode)
                {
                    Visit(node, null);
                }
            }

            return !Error;
        }

        private void Visit(RecordNode node, TypeInfo type) { }
        private void Visit(TableNode node, TypeInfo type) { }
        private void Visit(TypeNode node, TypeInfo type) { }

        private void Visit(PackageDeclNode node, TypeInfo type) 
        {
            var packageType = types.GetType(node.PackageName) as ClassType;

            foreach (dynamic item in node.PackageDecls)
            {
                Visit(item, packageType);
            }

        }

        private void Visit(VarDefNode node, TypeInfo type) 
        {
            var classType = type as ClassType;

            var var = GetVar(node);

            if (!classType.AddField(var.Name, var.Type))
            {
                Log(
                    String.Format("В типе {0} поле {1} уже существует", classType.Name, var.Name),
                    node);
            }

        }

        private void Visit(MethodDeclNode node, ClassType classType) 
        {

            var method = GetMethod(node);

            var methodInfo = new MethodInfo(method.Name, method.Ret, IsStatic(node.Modifier), classType);

            foreach(var item in method.Args)
            {
                methodInfo.AddArg(item.Name, item.Type);
            }

            if (!classType.AddMethod(methodInfo))
            {
                Log(
                    String.Format("В типе {0} метод {1} уже существует", classType.Name, method.Name),
                    node);
            }
        }

        private void Visit(ClassDeclNode node, TypeInfo type) 
        {
            var classType = types.GetType(node.ClassName) as ClassType;

            foreach (dynamic item in node.ClassDecls)
            {
                Visit(item, classType);
            }

        }
    }
}
