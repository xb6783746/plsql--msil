using Antlr.Runtime.Tree;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration
{
    class Codegenerator
    {

        public Codegenerator()
        {
            passes.Add(new AssignPass());
        }

        private List<IPreGenPass> passes = new List<IPreGenPass>();
        private Codegen codegen = new Codegen();

        public string Generate(CommonTree tree, TypeStorage types)
        {

            foreach(var item in passes)
            {
                item.Pass(tree);
            }

            return codegen.Generate(tree, types);
        }
    }
}
