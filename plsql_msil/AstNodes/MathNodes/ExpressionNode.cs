using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    class ExpressionNode : BasicNode
    {

        public ExpressionNode(CommonTree node)
            : base(node)
        {

        }
        public ExpressionNode(IToken t)
            : base(t)
        {

        }
        public ExpressionNode(int t)
            : base(new CommonToken(t, "Expression"))
        {

        }

        public override ITree DupNode()
        {
            return new ExpressionNode(Type);
        }

        public BasicNode Expression
        {
            get { return GetChild(0) as BasicNode; }
        }
    }
}
