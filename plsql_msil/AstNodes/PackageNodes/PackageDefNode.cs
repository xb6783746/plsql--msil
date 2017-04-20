using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MethodNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.AstNodes.ClassNodes;

namespace plsql_msil.AstNodes.PackageNodes
{
    class PackageDefNode : ClassDefNode
    {
        public PackageDefNode(CommonTree node)
            : base(node)
        {

        }
        public PackageDefNode(IToken t)
            : base(t)
        {

        }

        public PackageDefNode(int t)
            : base(new CommonToken(t, "PackageDef"))
        {

        }

        public override ITree DupNode()
        {
            return new PackageDefNode(Token);
        }


    }
}
