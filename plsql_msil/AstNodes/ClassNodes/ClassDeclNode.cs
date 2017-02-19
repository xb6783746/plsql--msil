using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.ClassNodes
{
    class ClassDeclNode :BasicNode
    {
        public ClassDeclNode(CommonTree node)
            : base(node)
        {

        }
        public ClassDeclNode(IToken t)
            : base(t)
        {

        }

        public ClassDeclNode(int t)
            : base(new CommonToken(t, "ClassDecl"))
        {

        }

        public override ITree DupNode()
        {
            return new ClassDeclNode(Token);
        }

        public string ClassName
        {
            get
            {
                return GetChild(0).Text;
            }
        }

        public List<BasicNode> ClassDecls
        {
            get
            {
                List<BasicNode> res = new List<BasicNode>();

                for (int i = 1; i < ChildCount; i++)
                {
                    res.Add(GetChild(i) as BasicNode);
                }

                return res;
            }
        }
    }
}
