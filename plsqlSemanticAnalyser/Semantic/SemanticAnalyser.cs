using System.Collections.Generic;
using Antlr.Runtime.Tree;
using plsqlBasic.Loggers;
using plsqlSemanticAnalyser.Semantic.Passes;
using plsql_msil.Semantic;
using plsql_msil.Semantic.Passes;
using plsql_msil.Types;

namespace plsqlSemanticAnalyser.Semantic
{
    public class SemanticAnalyser
    {
        public SemanticAnalyser(TypeStorage types, ILogger logger)
        {
            this.types = types;


            passList.Add(new TypeCollector(types, logger));
            passList.Add(new TypeBuilder(types, logger));
            passList.Add(new OperatorPass());
            passList.Add(new DefinitionAnalyser(types, logger));
        }


        private TypeStorage types;

        private List<IPass> passList = new List<IPass>();

        public bool Check(CommonTree tree)
        {
            bool result = true;

            foreach (var item in passList)
            {
                result &= item.Check(tree);
            }

            return result;

        }
    }
}
