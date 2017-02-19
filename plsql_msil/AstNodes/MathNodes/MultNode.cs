using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    class MultNode :BinaryOperator
    {

        public MultNode(CommonTree node)
            : base(node)
        {

        }
        public MultNode(IToken t)
            : base(t)
        {

        }
        public MultNode(int t)
            : base(new CommonToken(t, "*"))
        {

        }

        public override ITree DupNode()
        {
            return new MultNode(Type);
        }
    }
}
