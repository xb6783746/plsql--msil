using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime.Tree;
using plsql_msil.Loggers;
using plsql_msil.Optimization.Passes;
using plsql_msil.Semantic;

namespace plsql_msil.Optimization
{
    class Optimizer
    {
        public Optimizer()
        {
            passes = new List<IPass>();

            passes.Add(new ConstantConvolution());
        }

        private List<IPass> passes;

        public void Optimize(CommonTree tree)
        {
            foreach (var item in passes)
            {
                item.Check(tree);
            }
        }
    }
}
