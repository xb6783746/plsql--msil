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
    class WhileNode :BasicNode
    {
        public WhileNode(CommonTree node)
            : base(node)
        {

        }
        public WhileNode(IToken t)
            : base(t)
        {

        }

        public WhileNode(int t)
            : base(new CommonToken(t, "While"))
        {

        }

        public override ITree DupNode()
        {
            return new WhileNode(Token);
        }

        public ExpressionNode Condition
        {
            get
            {
                return GetChild(0) as ExpressionNode;
            }
        }

        public CodeBlockNode Command
        {
            get
            {
                return GetChild(1) as CodeBlockNode;
            }
        }

    }
}
