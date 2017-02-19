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
    class IfNode :BasicNode
    {
        public IfNode(CommonTree node)
            : base(node)
        {

        }
        public IfNode(IToken t)
            : base(t)
        {

        }

        public IfNode(int t)
            : base(new CommonToken(t, "If"))
        {

        }

        public override ITree DupNode()
        {
            return new IfNode(Token);
        }

        public ExpressionNode Condition
        {
            get
            {
                return GetChild(0) as ExpressionNode;
            }
        }

        public CodeBlockNode IfTrue
        {
            get
            {
                return GetChild(1) as CodeBlockNode;
            }
        }

        public CodeBlockNode IfFalse
        {
            get
            {
                return ChildCount > 2? GetChild(2) as CodeBlockNode : null;
            }
        }
    }
}
