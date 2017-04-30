using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.TypeNodes
{
    class DictionaryNode :BasicNode
    {
        public DictionaryNode(CommonTree node)
            : base(node)
        {

        }
        public DictionaryNode(IToken t)
            : base(t)
        {

        }
        public DictionaryNode(int t)
            : base(new CommonToken(t, "DictionaryNode"))
        {

        }

        public override ITree DupNode()
        {
            return new DictionaryNode(Type);
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

        public TypeNode ValTypeNode
        {
            get
            {
                return GetChild(2) as TypeNode;
            }
        }
    }
}
