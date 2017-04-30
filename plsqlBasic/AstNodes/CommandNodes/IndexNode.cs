using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.CommandNodes
{
    public class IndexNode :BasicNode
    {
        public IndexNode(CommonTree node)
            : base(node)
        {

        }
        public IndexNode(IToken t)
            : base(t)
        {

        }

        public IndexNode(int t)
            : base(new CommonToken(t, "Index"))
        {

        }

        public override ITree DupNode()
        {
            return new IndexNode(Token);
        }

        public ExpressionNode Index
        {
            get
            {
                return GetChild(0) as ExpressionNode;
            }
        }

        public BasicNode Where
        {
            get
            {
                return GetChild(1) as BasicNode;
            }
        }

        //public TableType TableType { get; set; }

    }
}
