using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    public class NotNode : BasicNode
    {

        public NotNode(CommonTree node)
            : base(node)
        {

        }
        public NotNode(IToken t)
            : base(t)
        {

        }
        public NotNode(int t)
            : base(new CommonToken(t, "!"))
        {

        }

        public override ITree DupNode()
        {
            return new NotNode(Type);
        }

        public BasicNode Operand
        {
            get { return this.GetChild(0) as BasicNode; }
        }
    }
}
