using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.SpecialNodes
{
    class AssignVarNode : VarNode
    {
        public AssignVarNode(VarNode node):base(node)
        {
            VarInfo = node.VarInfo;
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
