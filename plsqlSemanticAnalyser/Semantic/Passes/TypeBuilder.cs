using System;
using System.Linq;
using Antlr.Runtime.Tree;
using plsqlBasic.Loggers;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Semantic;
using plsql_msil.Types;
using plsql_msil.Types.VarTypes;

namespace plsqlSemanticAnalyser.Semantic.Passes
{
  
    class TypeBuilder :Analyser, IPass
    {
        public TypeBuilder(TypeStorage types, ILogger logger)
            :base(types, logger)
        {

        }

        public bool Check(CommonTree tree)
        {

            foreach(dynamic node in tree.Children.OfType<ClassDeclNode>())
            {
                Visit(node, null);
            }

            return !Error;
        }

        private void Visit(RecordNode node, TypeInfo type) { }
        private void Visit(TableNode node, TypeInfo type) { }
        private void Visit(TypeNode node, TypeInfo type) { }


        private void Visit(ClassDeclNode node, TypeInfo type)
        {
            var classType = types.GetType(node.ClassName) as ClassType;

            foreach (dynamic item in node.ClassDecls)
            {
                Visit(item, classType);
            }

            var constructor = new ConstructorInfo(false, classType);

            foreach (var item in classType.Fields)
            {
                constructor.AddArg(item.Name, item.Type);
            }

            classType.AddConstructor(constructor);

        }

        private void Visit(VarDefNode node, TypeInfo type) 
        {
            var classType = type as ClassType;

            var var = GetVar(node);

            if (!classType.AddField(var.Name, var.Type))
            {
                Log(
                    string.Format("В типе {0} поле {1} уже существует", 
                        classType.Name, 
                        var.Name),
                    node);
            }

        }

        private void Visit(MethodDeclNode node, ClassType classType) 
        {

            var method = GetMethod(node);

            var methodInfo = new MethodInfo(
                method.Name, 
                method.Ret, 
                method.Static, 
                classType,
                method.Args
                    .Select(x => new MethodVarInfo(x.Name, x.Type, MethodVarType.Argument))
                    .ToList());

            if (!classType.AddMethod(methodInfo))
            {
                Log(
                    string.Format("В типе {0} метод {1} уже существует", 
                        classType.Name, 
                        method.Name),
                    node);
            }
        }

    }
}
