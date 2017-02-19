using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.TypeNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.OtherNodes
{
    class VarDefNode : BasicNode
    {
        public VarDefNode(CommonTree node)
            : base(node)
        {

        }
        public VarDefNode(IToken t)
            : base(t)
        {

        }

        public VarDefNode(int t)
            : base(new CommonToken(t, "VarDef"))
        {

        }

        public override ITree DupNode()
        {
            return new VarDefNode(Token);
        }

        public string VarName
        {
            get { return GetChild(0).Text; }
        }
        public TypeNode VarType
        {
            get { return GetChild(1) as TypeNode; }
        }
    }
}
