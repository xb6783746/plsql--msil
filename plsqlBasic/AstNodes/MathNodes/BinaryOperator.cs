using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace plsql_msil.AstNodes.MathNodes
{
    public class BinaryOperator :BasicNode
    {
        public BinaryOperator(CommonTree node)
            : base(node)
        {

        }
        public BinaryOperator(IToken t)
            : base(t)
        {

        }

        public BasicNode LeftOperand
        {
            get
            {
                return this.GetChild(0) as BasicNode;
            }
        }
        public BasicNode RightOperand
        {
            get
            {
                return this.GetChild(1) as BasicNode;
            }
        }
    }
}
