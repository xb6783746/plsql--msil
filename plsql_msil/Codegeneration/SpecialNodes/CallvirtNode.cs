using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.SpecialNodes
{
    class CallvirtNode :BasicNode
    {
        public CallvirtNode(MethodInfo method, BasicNode where, List<ExpressionNode> args)
            : base(new CommonToken(-1, "Callvirt"))
        {
            Method = method;
            Where = where;
            Args = args;
        }

        public MethodInfo Method { get; private set; }
        public BasicNode Where { get; private set; }
        public List<ExpressionNode> Args { get; private set; }

    }
}
