using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MethodNodes
{
    class MethodCallNode :BasicNode
    {
        public MethodCallNode(CommonTree node)
            : base(node)
        {

        }
        public MethodCallNode(IToken t)
            : base(t)
        {

        }
        public MethodCallNode(int t)
            : base(new CommonToken(t, "MethodCall"))
        {

        }

        public override ITree DupNode()
        {
            return new MethodCallNode(Type);
        }

        public virtual string MethodName
        {
            get { return GetChild(0).Text; }
        }

        public virtual List<BasicNode> Arguments
        {
            get 
            {
                List<BasicNode> res = new List<BasicNode>();

                var exprList = GetChild(1);

                for(int i = 0; i < exprList.ChildCount; i++)
                {
                    res.Add(exprList.GetChild(i) as BasicNode);
                }

                return res;
            }
        }

        public virtual BasicNode Where
        {
            get
            {
                return GetChild(2) as BasicNode;
            }
        }

        //public MethodInfo MethodInfo { get; set; }
    }
}
