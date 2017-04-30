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
    public class ForNode :BasicNode
    {
        public ForNode(CommonTree node)
            : base(node)
        {

        }
        public ForNode(IToken t)
            : base(t)
        {

        }

        public ForNode(int t)
            : base(new CommonToken(t, "For"))
        {

        }

        public override ITree DupNode()
        {
            return new ForNode(Token);
        }

        public BasicNode Init
        {
            get
            {
                return GetChild(0) as BasicNode;
            }
        }

        public BasicNode Condition
        {
            get
            {
                return GetChild(1) as BasicNode;
            }
        }

        public BasicNode Iteration
        {
            get
            {
                return GetChild(2) as BasicNode;
            }
        }

        public CodeBlockNode CodeBlock
        {
            get
            {
                return GetChild(3) as CodeBlockNode;
            }
        }

    }
}
