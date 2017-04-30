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
    public class MethodCallNode :BasicNode
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
        public MethodCallNode(string name, BasicNode where, List<BasicNode> args )
            : base(new CommonToken(0, "MethodCall"))
        {
            var node = new BasicNode(new CommonToken(0, name));
            this.InsertChild(0, node);
            node.Parent = this;

            var argsNode = new BasicNode(new CommonToken(0, "Args"));
            this.InsertChild(1, argsNode);
            argsNode.Parent = this;

            for (int i = 0; i < args.Count; i++)
            {
                argsNode.InsertChild(i, args[i]);
                args[i].Parent = argsNode;
            }

            this.InsertChild(2, where);
            where.Parent = this;


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
