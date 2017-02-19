using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.OtherNodes
{
    class VarNode : BasicNode
    {
        public VarNode(CommonTree node)
            : base(node)
        {

        }
        public VarNode(IToken t)
            : base(t)
        {

        }

        public VarNode(int t)
            : base(new CommonToken(t, "Var"))
        {

        }

        public override ITree DupNode()
        {
            return new VarNode(Token);
        }

        public string VarName
        {
            get { return Text; }
        }

        public VarInfo VarInfo { get; set; }
    }
}
