using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    class OrNode :BinaryOperator
    {

        public OrNode(CommonTree node)
            : base(node)
        {

        }
        public OrNode(IToken t)
            : base(t)
        {

        }
        public OrNode(int t)
            : base(new CommonToken(t, "||"))
        {

        }

        public override ITree DupNode()
        {
            return new OrNode(Type);
        }
    }
}
