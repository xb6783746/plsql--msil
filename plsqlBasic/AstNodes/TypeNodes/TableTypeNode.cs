using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.TypeNodes
{
    public class TableTypeNode :TypeNode
    {
        public TableTypeNode(CommonTree node)
            : base(node)
        {

        }
        public TableTypeNode(IToken t)
            : base(t)
        {

        }
        public TableTypeNode(int t)
            : base(new CommonToken(t, "TableTypeNode"))
        {

        }

        public override ITree DupNode()
        {
            return new TableTypeNode(Type);
        }

        public TypeNode TypeNode
        {
            get
            {
                return GetChild(0) as TypeNode;
            }
        }

        public override string TypeName
        {
            get
            {

                return string.Format("table({0})", TypeNode.TypeName);
            }
        }
    }
}
