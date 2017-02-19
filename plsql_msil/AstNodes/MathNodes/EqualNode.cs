using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    class EqualNode :BinaryOperator
    {

        public EqualNode(CommonTree node)
            : base(node)
        {

        }
        public EqualNode(IToken t)
            : base(t)
        {

        }
        public EqualNode(int t)
            : base(new CommonToken(t, "=="))
        {

        }

        public override ITree DupNode()
        {
            return new EqualNode(Type);
        }
    }
}
