using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.OtherNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.CommandNodes
{
    public class DoWhileNode : WhileNode
    {
        public DoWhileNode(CommonTree node)
            : base(node)
        {

        }
        public DoWhileNode(IToken t)
            : base(t)
        {

        }

        public DoWhileNode(int t)
            : base(new CommonToken(t, "DoWhile"))
        {

        }

        public override ITree DupNode()
        {
            return new DoWhileNode(Token);
        }

    }
}
