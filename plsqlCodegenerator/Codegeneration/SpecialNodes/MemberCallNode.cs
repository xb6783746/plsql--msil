using plsql_msil.AstNodes;
using plsql_msil.AstNodes.CommandNodes;

namespace plsql_msil.Codegeneration.SpecialNodes
{
    class AssignMemberCallNode :BasicNode
    {

        public AssignMemberCallNode(MemberCallNode node)
            : base(node)
        {
            MemberCallNode = node;

        }

        public MemberCallNode MemberCallNode { get; private set; }

    }
}
