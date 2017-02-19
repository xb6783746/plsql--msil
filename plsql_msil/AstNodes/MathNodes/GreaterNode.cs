using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    class GreaterNode :BinaryOperator
    {

        public GreaterNode(CommonTree node)
            : base(node)
        {

        }
        public GreaterNode(IToken t)
            : base(t)
        {

        }
        public GreaterNode(int t)
            : base(new CommonToken(t, ">"))
        {

        }

        public override ITree DupNode()
        {
            return new GreaterNode(Type);
        }
    }
}
