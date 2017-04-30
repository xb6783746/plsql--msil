using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.AstNodes.ClassNodes;

namespace plsql_msil.AstNodes.PackageNodes
{
    class PackageDeclNode :ClassDeclNode
    {
        public PackageDeclNode(CommonTree node)
            : base(node)
        {

        }
        public PackageDeclNode(IToken t)
            : base(t)
        {

        }

        public PackageDeclNode(int t)
            : base(new CommonToken(t, "PackageDecl"))
        {

        }

        public override ITree DupNode()
        {
            return new PackageDeclNode(Token);
        }

    }
}
