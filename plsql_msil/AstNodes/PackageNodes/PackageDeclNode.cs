using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.PackageNodes
{
    class PackageDeclNode :BasicNode
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

        public string PackageName
        {
            get
            {
                return GetChild(0).Text;
            }
        }

        public List<BasicNode> PackageDecls
        {
            get
            {
                List<BasicNode> res = new List<BasicNode>();

                for(int i = 1; i < ChildCount; i++)
                {
                    res.Add(GetChild(i) as BasicNode);
                }

                return res;
            }
        }
    }
}
