using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.MathNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Types;

namespace plsql_msil.AstNodes.MethodNodes
{
    public class CreateArrayNode :TypeNode
    {
        public CreateArrayNode(CommonTree node)
            : base(node)
        {

        }
        public CreateArrayNode(IToken t)
            : base(t)
        {

        }
        public CreateArrayNode(int t)
            : base(new CommonToken(t, "CreateArray"))
        {

        }

        public override ITree DupNode()
        {
            return new CreateArrayNode(Type);
        }

        public TypeNode TypeNode
        {
            get { return GetChild(0) as TypeNode; }
        }

        public ExpressionNode Length
        {
            get { return GetChild(1) as ExpressionNode; }
        }
    }
}
