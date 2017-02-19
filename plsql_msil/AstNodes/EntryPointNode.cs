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
    class EntryPointNode :BasicNode
    {
        public EntryPointNode(CommonTree node)
            : base(node)
        {

        }
        public EntryPointNode(IToken t)
            : base(t)
        {

        }
        public EntryPointNode(int t)
            : base(new CommonToken(t, "EntryPoint"))
        {

        }

        public override ITree DupNode()
        {
            return new EntryPointNode(Type);
        }

        public List<BasicNode> DeclareItems
        {
            get
            {
                List<BasicNode> res = new List<BasicNode>();

                var declareNode = GetChild(0);

                for (int i = 0; i < declareNode.ChildCount; i++)
                {
                    res.Add(declareNode.GetChild(i) as BasicNode);
                }

                return res;
            }
        }

        public CodeBlockNode CodeBlock
        {
            get
            {
                return GetChild(1) as CodeBlockNode;
            }
        }
    }
}
