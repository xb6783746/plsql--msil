using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MethodNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.PackageNodes
{
    class PackageDefNode :BasicNode
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

        public string PackageName
        {
            get
            {
                return GetChild(0).Text;
            }
        }

        public List<MethodDefNode> PackageDefs
        {
            get
            {
                List<MethodDefNode> res = new List<MethodDefNode>();

                for (int i = 1; i < ChildCount; i++)
                {
                    res.Add(GetChild(i) as MethodDefNode);
                }

                return res;
            }
        }
    }
}
