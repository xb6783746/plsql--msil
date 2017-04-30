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
    public class FloatNode : BasicNode
    {
        public FloatNode(CommonTree node)
            : base(node)
        {

        }
        public FloatNode(IToken t)
            : base(t)
        {

        }

        public FloatNode(int t)
            : base(new CommonToken(t, "Float"))
        {

        }

        public override ITree DupNode()
        {
            return new FloatNode(Token);
        }

        public float Value
        {
            get { return float.Parse(Text); }
        }
    }
}
