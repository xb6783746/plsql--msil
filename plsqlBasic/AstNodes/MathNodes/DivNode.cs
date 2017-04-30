using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    public class DivNode :BinaryOperator
    {

        public DivNode(CommonTree node)
            : base(node)
        {

        }
        public DivNode(IToken t)
            : base(t)
        {

        }
        public DivNode(int t)
            : base(new CommonToken(t, "/"))
        {

        }

        public override ITree DupNode()
        {
            return new DivNode(Type);
        }
    }
}
