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
    class IntegerNode : BasicNode
    {
        public IntegerNode(CommonTree node)
            : base(node)
        {

        }
        public IntegerNode(IToken t)
            : base(t)
        {

        }

        public IntegerNode(int t)
            : base(new CommonToken(t, "Integer"))
        {

        }

        public override ITree DupNode()
        {
            return new IntegerNode(Token);
        }

        public int Value
        {
            get { return int.Parse(Text); }
        }
    }
}
