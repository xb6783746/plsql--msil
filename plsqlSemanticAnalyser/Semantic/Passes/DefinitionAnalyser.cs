using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using plsqlBasic.Loggers;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.Semantic;
using plsql_msil.Types;
using plsql_msil.Types.VarTypes;

namespace plsqlSemanticAnalyser.Semantic.Passes
{
    class DefinitionAnalyser : Analyser, IPass
    {

        public DefinitionAnalyser(TypeStorage types, ILogger logger)
            :base(types, logger)
        {

            typeAnalyser = new TypeAnalyser(types, logger);
        }

        private TypeAnalyser typeAnalyser;

        public bool Check(CommonTree tree)
        {
            var context = new Context(types);

            context.NotImplementedTypes = tree.Children
                .OfType<ClassDeclNode>()
                .Select(x => context.Types.GetType(x.ClassName))
                .ToList();

            var collection = tree.Children
                .Where(x => 
                       x is DeclareBlockNode 
                    || x is ClassDefNode 
                    || x is EntryPointNode);

            foreach (dynamic item in collection)
            {
                Visit(item, context);
            }

            if (context.NotImplementedTypes.Count > 0)
            {
                string names = "";

                foreach (var item in context.NotImplementedTypes)
                {
                    names += item + " ";
                }

                Log(string.Format("Типы {0} не реализованы", names), null);

            }

            return !Error;
        }


        private TypeDescriptor Visit(EntryPointNode node, Context context)
        {
            var entryPoint = new MethodInfo("", TypeInfo.Void, false, null);

            context.CurrentMethod = entryPoint;

            foreach (dynamic item in node.DeclareItems)
            {
                Visit(item, context);
            }

            typeAnalyser.Check(node.CodeBlock, context);

            return null;
        }

        private TypeDescriptor Visit(ClassDefNode node, Context context)
        {
            var type = context.GetType(node.Name) as ClassType;

            if (type == null)
            {
                Log(string.Format("Класс {0} определяет тело, но не определяет интерфейс", node.Name), node);

                return null;
            }

            if (!context.NotImplementedTypes.Contains(type))
            {
                Log(string.Format("Класс {0} уже определил тело", node.Name), node);

                return null;
            }

            context.NotImplementedTypes.Remove(type);

            context.Self = type;

            List<MethodInfo> allMethods = new List<MethodInfo>(type.Methods);

            foreach (var item in node.Defs)
            {
                var method = Visit(item, type, context);

                if (method != null)
                {
                    allMethods.RemoveAll(x => 
                           x.Name == method.Name 
                        && TypeInfo.Compare(x.ArgTypes, method.ArgTypes)
                        && x.IsStatic == method.IsStatic);
                }
            }

            if (allMethods.Count != 0)
            {
                string methods = allMethods
                    .Aggregate("", (current, item) => current + (item.Name + " "));

                Log(string.Format("В классе {0} методы {1}объявлены, но не реализованы", node.Name, methods), node);
            }

            return null;
        }
        private TypeDescriptor Visit(PackageDefNode node, Context context)
        {
            var type = context.GetType(node.Name) as PackageType;

            if (type == null)
            {
                Log(string.Format("Пакет {0} определяет тело, но не определяет интерфейс", node.Name), node);

                return null;
            }

            if (!context.NotImplementedTypes.Contains(type))
            {
                Log(String.Format("Пакет {0} уже определил тело", node.Name), node);

                return null;
            }

            context.NotImplementedTypes.Remove(type);

            List<MethodInfo> allMethods = new List<MethodInfo>(type.Methods);

            foreach (var item in node.Defs)
            {
                var method = Visit(item, type, context);

                if (method != null)
                {
                    allMethods.RemoveAll(x => 
                        x.Name == method.Name 
                        && TypeInfo.Compare(x.ArgTypes, method.ArgTypes)
                        && x.IsStatic == method.IsStatic);
                }
            }

            if (allMethods.Count != 0)
            {
                string methods = allMethods
                    .Aggregate("", (current, item) => current + (item.Name + " "));

                Log(string.Format("В пакете {0} методы {1} объявлены, но не реализованы", node.Name, methods), node);
            }


            return null;

        }

        private MethodInfo Visit(MethodDefNode node, ClassType type, Context context)
        {

            var defined = GetMethod(node.MethodDecl);

            var declared = type.GetMethod(
                defined.Name, 
                defined.Args.Select(x => x.Type).ToList(), 
                defined.Static);

            if (declared == null)
            {
                Log(
                    string.Format("Метод {0} определен в теле пакета {1}, но не определен в интерфейсе",
                        node.MethodDecl.MethodName,
                        type.Name),
                    node);

                declared = new MethodInfo(
                    defined.Name,
                    defined.Ret, 
                    defined.Static, 
                    type, 
                    defined.Args
                        .Select(x => new MethodVarInfo(x.Name, x.Type, MethodVarType.Argument))
                        .ToList());
            }

            context.CurrentMethod = declared;

            var locals = GetLocalVars(node.DeclareBlock);

            foreach (var item in locals)
            {
                declared.AddLocalVar(item.Name, item.Type);
            }

            typeAnalyser.Check(node.Commands, context);

            context.CurrentMethod = null;

            return declared;
        }


        private TypeDescriptor Visit(VarDefNode node, Context context)
        {
            var var = GetVar(node);

            if (context.CurrentMethod != null)
            {
                bool res = context.CurrentMethod.AddLocalVar(var.Name, var.Type);

                if (!res)
                {
                    Log(string.Format("Переменная {0} уже определена", node.VarName), node);
                }
            }

            return null;
        }


        private List<VarStruct> GetLocalVars(DeclareBlockNode node)
        {

            var vars = new List<VarStruct>();

            foreach(var item in node.Decls)
            {
                var varInfo = GetVar(item);

                if (vars.Exists(x => x.Name == varInfo.Name))
                {
                    Log(
                        string.Format("Невозможно создать локальную переменную с именем {0}", varInfo.Name),
                        item);
                }
                else
                {
                    vars.Add(varInfo);
                }
            }

            return vars;
        }

    }
}
