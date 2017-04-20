using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Loggers;
using plsql_msil.Types;

namespace plsql_msil.Semantic.Passes
{
    class TypeCollector : Analyser, IPass
    {

        public TypeCollector(TypeStorage types)
        {
            this.types = types;
        }

        public bool Check(CommonTree tree, ILogger logger)
        {
            this.logger = logger;

            CollectTypeInfo(tree);
            CollectAnonymousTypes(tree);

            return !this.Error;
        }

        private void CollectTypeInfo(CommonTree tree)
        {

            foreach (var item in tree.Children.Where(x => x is ClassDeclNode || x is PackageDeclNode))
            {

                CollectTypeInfo(item as dynamic);
            }

        }
        private void CollectAnonymousTypes(CommonTree tree)
        {

            foreach (var item in tree.Children.OfType<ClassDefNode>())
            {

                foreach (var method in item.Defs)
                {
                    CollectAnonymousTypes(method);
                }
            }

            var entryPoint = tree.Children.FirstOrDefault(x => x is EntryPointNode) as EntryPointNode;

            if (entryPoint != null)
            {
                CollectAnonymousTypes(entryPoint);
            }
        }

        private void CollectTypeInfo(ClassDeclNode node)
        {

            bool exists = types.Exists(node.ClassName);

            if (!exists)
            {
                types.AddType(new ClassType(node.ClassName));
            }
            else
            {
                Log(string.Format("Объект с именем {0} уже существует", node.ClassName), node);
            }

        }
        private void CollectTypeInfo(PackageDeclNode node)
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

        }

        private void CollectPackageTypes(PackageDeclNode node)
        {

            var packageType = types.GetType(node.PackageName) as PackageType;

            foreach (var item in node.Children)
            {

                if (item is TableNode)
                {

                    CollectTable(item as TableNode, packageType);
                }
                else if (item is RecordNode)
                {

                    CollectRecord(item as RecordNode, packageType);
                }
            }
        }

        private void CollectRecord(RecordNode node, PackageType packageType)
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


        }
        private void CollectTable(TableNode node, PackageType packageType)
        {

            var tableType = new TableType(
                                packageType.Name, node.Name, types.GetType(node.TypeNode.TypeName));

            bool ok = packageType.AddType(tableType);
            types.AddType(tableType);

            if (!ok)
            {
                Log(String.Format("Таблица с именем {0} уже существует", node.Name), node);
            }

        }


        private void CollectAnonymousTypes(MethodDefNode node)
        {
            var decls = node.DeclareBlock.Decls
                .Where(x => x.VarType is TableTypeNode)
                .Select(x => x.VarType as TableTypeNode);

            foreach (var item in decls)
            {
                types.AddType(GetType(item));
            }


        }
        private void CollectAnonymousTypes(EntryPointNode node)
        {
            var decls = node.DeclareItems.OfType<VarDefNode>()
                .Where(x => x.VarType is TableTypeNode)
                .Select(x => x.VarType as TableTypeNode);

            foreach (var item in decls)
            {
                types.AddType(GetType(item));
            }


        }

        private TypeInfo GetType(TypeNode node)
        {
            return types.GetType(node.TypeName);
        }
        private TypeInfo GetType(TableTypeNode node)
        {
            var type = GetType(node.TypeNode as dynamic);

            types.AddType(type);

            return new TableType(node.TypeName, type);
        }
    }
}
