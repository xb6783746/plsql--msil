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
    class ByteNode : BasicNode
    {
        public ByteNode(CommonTree node)
            : base(node)
        {

        }
        public ByteNode(IToken t)
            : base(t)
        {

        }

        public ByteNode(int t)
            : base(new CommonToken(t, "Byte"))
        {

        }

        public override ITree DupNode()
        {
            return new ByteNode(Token);
        }

        public byte Value
        {
            get { return byte.Parse(Text); }
        }
    }
}
