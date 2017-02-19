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
    class MethodDeclNode :BasicNode
    {
        public MethodDeclNode(CommonTree node)
            : base(node)
        {

        }
        public MethodDeclNode(IToken t)
            : base(t)
        {

        }
        public MethodDeclNode(int t)
            : base(new CommonToken(t, "MethodDecl"))
        {

        }

        public override ITree DupNode()
        {
            return new MethodDeclNode(Type);
        }

        public string MethodName
        {
            get { return GetChild(0).Text; }
        }

        public List<VarDefNode> Vars
        {
            get 
            {
                List<VarDefNode> res = new List<VarDefNode>();

                var varList = GetChild(1);

                for (int i = 0; i < varList.ChildCount; i++ )
                {
                    res.Add(varList.GetChild(i) as VarDefNode);
                }

                return res;
            }
        }

        public TypeNode Ret
        {
            get 
            {
                return GetChild(2) as TypeNode;
            }
        }

        public string Modifier
        {
            get
            {
                return GetChild(3).Text;
            }
        }
    }
}
