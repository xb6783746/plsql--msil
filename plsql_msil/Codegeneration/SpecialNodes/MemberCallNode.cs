using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.OtherNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.SpecialNodes
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
