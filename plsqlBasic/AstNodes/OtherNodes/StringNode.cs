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
    public class StringNode : BasicNode
    {
        public StringNode(CommonTree node)
            : base(node)
        {

        }
        public StringNode(IToken t)
            : base(t)
        {

        }

        public StringNode(int t)
            : base(new CommonToken(t, "String"))
        {

        }

        public override ITree DupNode()
        {
            return new StringNode(Token);
        }

        public string Value
        {
            get { return Text.Replace("\"", ""); }
        }
    }
}
