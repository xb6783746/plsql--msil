using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    public class NotEqualNode :BinaryOperator
    {

        public NotEqualNode(CommonTree node)
            : base(node)
        {

        }
        public NotEqualNode(IToken t)
            : base(t)
        {

        }
        public NotEqualNode(int t)
            : base(new CommonToken(t, "!="))
        {

        }

        public override ITree DupNode()
        {
            return new NotEqualNode(Type);
        }
    }
}
