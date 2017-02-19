using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.OtherNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes
{
    class DeclareBlockNode :BasicNode
    {
        public DeclareBlockNode(CommonTree node)
            : base(node)
        {

        }
        public DeclareBlockNode(IToken t)
            : base(t)
        {

        }
        public DeclareBlockNode(int t)
            : base(new CommonToken(t, "DeclareBlock"))
        {

        }

        public override ITree DupNode()
        {
            return new DeclareBlockNode(Type);
        }

        public List<VarDefNode> Decls
        {
            get
            {
                return Children == null ? new List<VarDefNode>() : Children.Select(x => x as VarDefNode).ToList();
            }
        }

        
    }
}
