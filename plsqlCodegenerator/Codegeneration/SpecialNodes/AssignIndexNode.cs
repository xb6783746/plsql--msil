using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.CommandNodes;

namespace plsql_msil.Codegeneration.SpecialNodes
{
    class AssignIndexNode :IndexNode
    {
        public AssignIndexNode(CommonTree node)
            : base(node)
        {

        }
        public AssignIndexNode(IToken t)
            : base(t)
        {

        }

        public AssignIndexNode(int t)
            : base(new CommonToken(t, "AssignIndex"))
        {

        }

        public override ITree DupNode()
        {
            return new AssignIndexNode(Token);
        }


    }
}
