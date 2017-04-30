using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    public class AndNode :BinaryOperator
    {

        public AndNode(CommonTree node)
            : base(node)
        {

        }
        public AndNode(IToken t)
            : base(t)
        {

        }
        public AndNode(int t)
            : base(new CommonToken(t, "&&"))
        {

        }

        public override ITree DupNode()
        {
            return new AndNode(Type);
        }
    }
}
