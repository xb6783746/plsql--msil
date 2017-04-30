using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.TypeNodes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.OtherNodes
{
    public class RealNode : BasicNode
    {
        public RealNode(CommonTree node)
            : base(node)
        {

        }
        public RealNode(IToken t)
            : base(t)
        {

        }

        public RealNode(int t)
            : base(new CommonToken(t, "Real"))
        {

        }

        public override ITree DupNode()
        {
            return new RealNode(Token);
        }

        public double Value
        {
            get { return double.Parse(Text, CultureInfo.InvariantCulture); }
        }
    }
}
