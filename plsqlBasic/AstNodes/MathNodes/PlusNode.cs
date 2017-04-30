using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    public class PlusNode :BinaryOperator
    {

        public PlusNode(CommonTree node)
            : base(node)
        {

        }
        public PlusNode(IToken t)
            : base(t)
        {

        }
        public PlusNode(int t)
            : base(new CommonToken(t, "+"))
        {

        }

        public override ITree DupNode()
        {
            return new PlusNode(Type);
        }
    }
}
