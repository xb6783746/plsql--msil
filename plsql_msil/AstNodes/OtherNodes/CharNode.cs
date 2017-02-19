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
    class CharNode : BasicNode
    {
        public CharNode(CommonTree node)
            : base(node)
        {

        }
        public CharNode(IToken t)
            : base(t)
        {

        }

        public CharNode(int t)
            : base(new CommonToken(t, "Char"))
        {

        }

        public override ITree DupNode()
        {
            return new CharNode(Token);
        }

        public char Value
        {
            get { return Text.Replace("'", "")[0]; }
        }
    }
}
