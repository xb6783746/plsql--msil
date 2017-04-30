using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.OtherNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.CommandNodes
{
    public class MemberCallNode :BasicNode
    {
        public MemberCallNode(CommonTree node)
            : base(node)
        {

        }
        public MemberCallNode(IToken t)
            : base(t)
        {

        }

        public MemberCallNode(int t)
            : base(new CommonToken(t, "MemberCall"))
        {

        }

        public override ITree DupNode()
        {
            return new MemberCallNode(Token);
        }

        public virtual string MemberName
        {
            get
            {
                return GetChild(0).Text;
            }
        }

        public virtual BasicNode Where
        {
            get
            {
                return GetChild(1) as BasicNode;
            }
        }

    }
}
