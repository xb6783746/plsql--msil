using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.TypeNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.OtherNodes
{
    public class CodeBlockNode : BasicNode
    {
        public CodeBlockNode(CommonTree node)
            : base(node)
        {

        }
        public CodeBlockNode(IToken t)
            : base(t)
        {

        }
        public CodeBlockNode(int t)
            : base(new CommonToken(t, "CodeBlock"))
        {

        }

        public override ITree DupNode()
        {
            return new CodeBlockNode(Token);
        }

        public List<BasicNode> Commands
        {
            get 
            {
                List<BasicNode> res = new List<BasicNode>();

                for (int i = 0; i < ChildCount; i++)
                {
                    res.Add(GetChild(i) as BasicNode);
                }

                return res;
            }
        }
    }
}
