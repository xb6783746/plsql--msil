using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.AstNodes.MethodNodes;

namespace plsql_msil.AstNodes.SpecialMethodNodes
{
    public class SpecialMethodCallNode : MethodCallNode
    {
        public SpecialMethodCallNode(CommonTree node)
            : base(node)
        {

        }
        public SpecialMethodCallNode(IToken t)
            : base(t)
        {

        }
        public SpecialMethodCallNode(string methodName, BasicNode where, List<BasicNode> args )
            : base(new CommonToken(0, "SpecialMethodCall"))
        {
            this.methodName = methodName;
            this.where = where;
            this.args = args;
        }

        public override ITree DupNode()
        {
            return new SpecialMethodCallNode(methodName, where, args);
        }

        private string methodName;
        private BasicNode where;
        private List<BasicNode> args;

        public override string MethodName { get { return methodName; } }
        public override BasicNode Where { get { return where; } }
        public override List<BasicNode> Arguments { get { return args; } }

        public MethodInfo MethodInfo { get; set; }
    }
}
