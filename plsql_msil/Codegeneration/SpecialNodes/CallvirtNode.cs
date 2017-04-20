using System.Collections.Generic;
using Antlr.Runtime;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.Types;

namespace plsql_msil.Codegeneration.SpecialNodes
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
