using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.TypeNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MethodNodes
{
    class MethodDefNode :BasicNode
    {
        public MethodDefNode(CommonTree node)
            : base(node)
        {

        }
        public MethodDefNode(IToken t)
            : base(t)
        {

        }
        public MethodDefNode(int t)
            : base(new CommonToken(t, "MethodDef"))
        {

        }

        public override ITree DupNode()
        {
            return new MethodDefNode(Type);
        }

        public DeclareBlockNode DeclareBlock
        {
            get 
            {
                return GetChild(0) as DeclareBlockNode;
            }
        }
        public MethodDeclNode MethodDecl
        {
            get 
            {
                return GetChild(1) as MethodDeclNode;
            }
        }

        public CodeBlockNode Commands
        {
            get
            {
                return GetChild(2) as CodeBlockNode;
            }
        }
    }
}
