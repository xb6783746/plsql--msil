using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.TypeNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.OtherNodes
{
    public class SelfNode : BasicNode
    {
        public SelfNode(CommonTree node)
            : base(node)
        {

        }
        public SelfNode(IToken t)
            : base(t)
        {

        }

        public SelfNode(int t)
            : base(new CommonToken(t, "Self"))
        {

        }

        public override ITree DupNode()
        {
            return new SelfNode(Token);
        }
    }
}
