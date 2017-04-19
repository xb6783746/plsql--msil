using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Semantic
{
    enum LogLevel
    {
        Warning, Error, Info
    }
    class TypeAnalyser :Analyser, IPass
    {
        public TypeAnalyser(TypeStorage types)
        {
            this.types = types;
        }

        public bool Check(CommonTree tree, ILogger logger)
        {
            this.logger = logger;

            CollectTypeInfo(tree);

            foreach(dynamic node in tree.Children)
            {
                if (node is ClassDeclNode || node is PackageDeclNode)
                {
                    Visit(node, null);
                }
            }

            return !Error;
        }

        private void CollectTypeInfo(CommonTree tree)
        {
            bool del;

            for (int i = 0; i < tree.ChildCount; i++ )
            {
                var node = tree.GetChild(i);
                del = false;

                if(node is ClassDeclNode)
                {
                    del = CollectTypeInfo(node as ClassDeclNode);
                }
                else if (node is PackageDeclNode)
                {
                    del = CollectTypeInfo(node as PackageDeclNode);
                }

                if(del)
                {
                    tree.DeleteChild(i);
                    i--;
                }
            }
        }

        private bool CollectTypeInfo(ClassDeclNode node)
        {

            bool exists = types.Exists(node.ClassName);

            if (!exists)
            {
                types.AddType(new ClassType(node.ClassName));
            }
            else
            {
                Log(String.Format("Объект с именем {0} уже существует", node.ClassName), node);
            }

            return exists;
        }
        private bool CollectTypeInfo(PackageDeclNode node)
        {
            bool exists = types.Exists(node.PackageName);

            if (!exists)
            {
                types.AddType(new PackageType(node.PackageName));

                CollectPackageTypes(node);
            }
            else
            {
                Log(String.Format("Пакет с именем {0} уже существует", node.PackageName), node);
            }

            return exists;
        }

        private void CollectPackageTypes(PackageDeclNode node)
        {
            bool del;

            var packageType = types.GetType(node.PackageName) as PackageType;

            for (int i = 0; i < node.ChildCount; i++)
            {
                del = false;

                dynamic item = node.GetChild(i);

                if (item is TableNode)
                {

                    del = CollectTable(item as TableNode, packageType);
                    
                }
                else if (item is RecordNode)
                {

                    del = CollectRecord(item as RecordNode, packageType);
                   
                }

                if (del)
                {
                    node.DeleteChild(i);
                    i--;
                }
            }
        }

        private bool CollectRecord(RecordNode node, PackageType packageType) 
        {

            var vars = new List<VarInfo>();

            foreach (var item in node.Vars)
            {
                var varInfo = GetVar(item);

                vars.Add(new VarInfo(varInfo.Name, varInfo.Type, VarLocation.Global));
            }

            var record = new RecordType(packageType.Name, node.Name, vars);

            bool ok = packageType.AddType(record);
            types.AddType(record);

            if (!ok)
            {
                Log(String.Format("Запись с именем {0} уже существует", node.Name), node);
            }

            return ok;

        }
        private bool CollectTable(TableNode node, PackageType packageType) 
        {

            var tableType = new TableType(
                                packageType.Name, node.Name, types.GetType(node.TypeNode.TypeName));

            bool ok = packageType.AddType(tableType);
            types.AddType(tableType);

            if (!ok)
            {
                Log(String.Format("Таблица с именем {0} уже существует", node.Name), node);
            }

            return !ok;
            
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
