using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    class LessNode :BinaryOperator
    {

        public LessNode(CommonTree node)
            : base(node)
        {

        }
        public LessNode(IToken t)
            : base(t)
        {

        }
        public LessNode(int t)
            : base(new CommonToken(t, "<"))
        {

        }

        public override ITree DupNode()
        {
            return new LessNode(Type);
        }
    }
}
