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
    public class BoolNode : BasicNode
    {
        public BoolNode(CommonTree node)
            : base(node)
        {

        }
        public BoolNode(IToken t)
            : base(t)
        {

        }

        public BoolNode(int t)
            : base(new CommonToken(t, "Bool"))
        {

        }

        public override ITree DupNode()
        {
            return new BoolNode(Token);
        }

        public bool Value
        {
            get { return bool.Parse(Text); }
        }
    }
}
