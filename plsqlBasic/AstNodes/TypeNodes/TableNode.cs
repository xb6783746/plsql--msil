using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.TypeNodes
{
    public class TableNode :BasicNode
    {
        public TableNode(CommonTree node)
            : base(node)
        {

        }
        public TableNode(IToken t)
            : base(t)
        {

        }
        public TableNode(int t)
            : base(new CommonToken(t, "TableNode"))
        {

        }

        public override ITree DupNode()
        {
            return new TableNode(Type);
        }

        public string Name
        {
            get
            {
                return GetChild(0).Text;
            }
        }

        public TypeNode TypeNode
        {
            get
            {
                return GetChild(1) as TypeNode;
            }
        }
    }
}
