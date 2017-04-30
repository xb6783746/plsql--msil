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
    public class ReturnNode :BasicNode
    {
        public ReturnNode(CommonTree node)
            : base(node)
        {

        }
        public ReturnNode(IToken t)
            : base(t)
        {

        }

        public ReturnNode(int t)
            : base(new CommonToken(t, "Return"))
        {

        }

        public override ITree DupNode()
        {
            return new ReturnNode(Token);
        }

        public ExpressionNode Expression
        {
            get
            {
                return GetChild(0) as ExpressionNode;
            }
        }

    }
}
