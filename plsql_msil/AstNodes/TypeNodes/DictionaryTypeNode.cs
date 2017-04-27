using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.TypeNodes
{
    class DictionaryTypeNode :BasicNode
    {
        public DictionaryTypeNode(CommonTree node)
            : base(node)
        {

        }
        public DictionaryTypeNode(IToken t)
            : base(t)
        {

        }
        public DictionaryTypeNode(int t)
            : base(new CommonToken(t, "DictionaryTypeNode"))
        {

        }

        public override ITree DupNode()
        {
            return new DictionaryTypeNode(Type);
        }

        public TypeNode TypeNode
        {
            get
            {
                return GetChild(0) as TypeNode;
            }
        }

        public TypeNode IndexTypeNode
        {
            get
            {
                return GetChild(1) as TypeNode;
            }
        }
    }
}
