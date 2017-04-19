using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types;

namespace plsql_msil.AstNodes.MethodNodes
{
    class CreateInstanceNode :BasicNode
    {
        public CreateInstanceNode(CommonTree node)
            : base(node)
        {

        }
        public CreateInstanceNode(IToken t)
            : base(t)
        {

        }
        public CreateInstanceNode(int t)
            : base(new CommonToken(t, "CreateInstance"))
        {

        }

        public override ITree DupNode()
        {
            return new CreateInstanceNode(Type);
        }

        public string TypeName
        {
            get { return GetChild(0).Text; }
            set { ReplaceChildren(0, 0, new CommonTree(new CommonToken(0, value))); }
        }

        public List<BasicNode> Arguments
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

        public List<TypeInfo> Constructor { get; set; }
    }
}
