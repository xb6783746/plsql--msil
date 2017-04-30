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
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Semantic.Passes
{
    class TypeCollector : Analyser, IPass
    {

        public TypeCollector(TypeStorage types, ILogger logger)
            :base(types, logger)
        {
            this.types = types;
        }

        public bool Check(CommonTree tree)
        {

            CollectTypeInfo(tree);

            return !this.Error;
        }

        private void CollectTypeInfo(CommonTree tree)
        {

            foreach (var item in tree.Children.Where(x => x is ClassDeclNode || x is PackageDeclNode))
            {

                CollectTypeInfo(item as dynamic);
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
            bool exists = types.Exists(node.ClassName);

            if (!exists)
            {
                types.AddType(new PackageType(node.ClassName));

                CollectPackageTypes(node);
            }
            else
            {
                Log(String.Format("Пакет с именем {0} уже существует", node.ClassName), node);
            }

        }

        private void CollectPackageTypes(PackageDeclNode node)
        {

            var packageType = types.GetType(node.ClassName) as PackageType;

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

            var record = new RecordType(packageType.Name, node.Name);

            foreach (var item in node.Vars)
            {
                var varInfo = GetVar(item);

                record.AddField(varInfo.Name, varInfo.Type);
            }

            bool ok = packageType.AddType(record);
            types.AddType(record);

            if (!ok)
            {
                Log(String.Format("Запись с именем {0} уже существует", node.Name), node);
            }


        }
        private void CollectTable(TableNode node, PackageType packageType)
        {
            var tableType = builder.GenerateTableType(node.TypeNode, packageType.Name + "." + node.Name);

            bool ok = packageType.AddType(tableType);
            types.AddType(tableType);

            if (!ok)
            {
                Log(String.Format("Таблица с именем {0} уже существует", node.Name), node);
            }

        }
        //private void CollectDictionary(DictionaryNode node, PackageType packageType)
        //{
        //    var dictType = GenerateDictionaryType(node.TypeNode, node.Name);

        //    bool ok = packageType.AddType(tableType);
        //    types.AddType(tableType);

        //    if (!ok)
        //    {
        //        Log(String.Format("Таблица с именем {0} уже существует", node.Name), node);
        //    }

        //}

    }
}
