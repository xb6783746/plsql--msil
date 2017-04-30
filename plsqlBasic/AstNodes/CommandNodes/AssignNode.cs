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
    public class AssignNode :BasicNode
    {
        public AssignNode(CommonTree node)
            : base(node)
        {

        }
        public AssignNode(IToken t)
            : base(t)
        {

        }

        public AssignNode(int t)
            : base(new CommonToken(t, "Assign"))
        {

        }

        public override ITree DupNode()
        {
            return new AssignNode(Token);
        }

        public ExpressionNode LValue
        {
            get
            {
                return GetChild(0) as ExpressionNode;
            }
        }

        public ExpressionNode Expression
        {
            get
            {
                return GetChild(1) as ExpressionNode;
            }
        }
    }
}
