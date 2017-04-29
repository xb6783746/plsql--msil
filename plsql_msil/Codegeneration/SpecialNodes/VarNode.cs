using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.OtherNodes;

namespace plsql_msil.Codegeneration.SpecialNodes
{
    class AssignVarNode : VarNode
    {
        public AssignVarNode(VarNode node):base(node)
        {
            //VarInfo = node.VarInfo;
        }

        public AssignVarNode(CommonTree node)
            : base(node)
        {

        }
        public AssignVarNode(IToken t)
            : base(t)
        {

        }

        public AssignVarNode(int t)
            : base(new CommonToken(t, "AssignVar"))
        {

        }

        public override ITree DupNode()
        {
            return new AssignVarNode(Token);
        }

    }
}
