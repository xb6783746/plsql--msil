using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    public class ModNode :BinaryOperator
    {

        public ModNode(CommonTree node)
            : base(node)
        {

        }
        public ModNode(IToken t)
            : base(t)
        {

        }
        public ModNode(int t)
            : base(new CommonToken(t, "%"))
        {

        }

        public override ITree DupNode()
        {
            return new ModNode(Type);
        }
    }
}
