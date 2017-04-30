using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.TypeNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types;

namespace plsql_msil.AstNodes.OtherNodes
{
    public class CastNode : BasicNode
    {
        public CastNode(CommonTree node)
            : base(node)
        {

        }
        public CastNode(IToken t)
            : base(t)
        {

        }

        public CastNode(int t)
            : base(new CommonToken(t, "Cast"))
        {

        }

        public override ITree DupNode()
        {
            return new CastNode(Token);
        }

        public TypeNode TypeNode
        {
            get { return GetChild(1) as TypeNode; } 
        }

        public BasicNode Expression
        {
            get { return GetChild(0) as BasicNode; }
        }

        public TypeInfo Type { get; set; }
    }
}
