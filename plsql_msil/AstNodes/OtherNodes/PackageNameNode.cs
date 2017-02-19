using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.OtherNodes
{
    class PackageNameNode : BasicNode
    {

        public PackageNameNode(string packageName)
            : base(new CommonToken(0, packageName))
        {
            PackageName = packageName;
        }

        public string PackageName
        {
            get;
            private set;
        }
    }
}
