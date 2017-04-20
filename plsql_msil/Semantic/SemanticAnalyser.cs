using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Loggers;
using plsql_msil.Semantic.Passes;

namespace plsql_msil.Semantic
{
    class SemanticAnalyser
    {
        public SemanticAnalyser(TypeStorage types)
        {
            this.types = types;


            passList.Add(new TypeAnalyser(types));
            passList.Add(new DefinitionAnalyser(types));
        }


        private TypeStorage types;

        private List<IPass> passList = new List<IPass>();

        public bool Check(CommonTree tree, ILogger logger)
        {
            bool result = true;

            foreach (var item in passList)
            {
                result &= item.Check(tree, logger);
            }

            return result;

        }
    }
}
