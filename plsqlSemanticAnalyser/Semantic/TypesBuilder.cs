using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Types;

namespace plsql_msil.Semantic
{
    class TypesBuilder
    {
        public TypesBuilder(TypeStorage types)
        {
            this.types = types;
        }

        private TypeStorage types;


        public TypeInfo Build(TypeNode node)
        {
            return Visit(node as dynamic);
        }

        public TypeInfo GenerateTableType(TypeNode node, string name = null)
        {
            var type = Visit(node as dynamic);

            var tableTypeTemplate = types.GetTemplate("List`1");

            return tableTypeTemplate.Generate(name, type);

        }
        public TypeInfo GenerateDictionaryType(TypeNode kTypeNode, TypeNode valTypeNode, string name = null)
        {
            var type = Visit(kTypeNode as dynamic);

            var valType = Visit(valTypeNode as dynamic);

            var dictTypeTemplate = types.GetTemplate("Dictionary`2");

            return dictTypeTemplate.Generate(name, type, valType);
        }
        public TypeInfo GenerateArrayType(TypeNode node, string name = null)
        {
            var type = Visit(node as dynamic);

            var arrTypeTemplate = types.GetTemplate("Array`1");

            return arrTypeTemplate.Generate(name, type);
        }

        private TypeInfo Visit(TypeNode node)
        {
            return types.GetType(node.TypeName);
        }
        private TypeInfo Visit(TableTypeNode node)
        {
            return GenerateTableType(node.TypeNode);
        }
        private TypeInfo Visit(DictionaryTypeNode node)
        {
            return GenerateDictionaryType(node.IndexTypeNode, node.TypeNode);
        }
        private TypeInfo Visit(ArrayTypeNode node)
        {
            return GenerateArrayType(node.TypeNode);
        }
    }
}