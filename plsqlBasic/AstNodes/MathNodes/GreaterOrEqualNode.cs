using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    public class GreaterOrEqualNode :BinaryOperator
    {

        public GreaterOrEqualNode(CommonTree node)
            : base(node)
        {

        }
        public GreaterOrEqualNode(IToken t)
            : base(t)
        {

        }
        public GreaterOrEqualNode(int t)
            : base(new CommonToken(t, ">="))
        {

        }

        public override ITree DupNode()
        {
            return new GreaterOrEqualNode(Type);
        }
    }
}
