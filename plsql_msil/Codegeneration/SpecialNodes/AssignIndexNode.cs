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
