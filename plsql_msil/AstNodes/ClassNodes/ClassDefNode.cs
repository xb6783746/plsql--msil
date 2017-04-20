using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MethodNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.ClassNodes
{
    class ClassDefNode :BasicNode
    {
        public ClassDefNode(CommonTree node)
            : base(node)
        {

        }
        public ClassDefNode(IToken t)
            : base(t)
        {

        }

        public ClassDefNode(int t)
            : base(new CommonToken(t, "ClassDef"))
        {

        }

        public override ITree DupNode()
        {
            return new ClassDefNode(Token);
        }

        public string Name
        {
            get
            {
                return GetChild(0).Text;
            }
        }

        public virtual List<MethodDefNode> Defs
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
