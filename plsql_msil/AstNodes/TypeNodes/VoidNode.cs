using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.TypeNodes
{
    class VoidNode : TypeNode
    {
        public VoidNode(CommonTree node)
            : base(node)
        {

        }
        public VoidNode(IToken t)
            : base(t)
        {

        }
        public VoidNode(int t)
            : base(new CommonToken(t, "void"))
        {

        }

        public override ITree DupNode()
        {
            return new VoidNode(Type);
        }

        public override string PackageName
        {
            get
            {
                return null;
            }
        }
        public override string TypeName
        {
            get
            {
                return "void";
            }
        }
    }
}
