using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.AstNodes.MathNodes;

namespace plsql_msil.AstNodes.TypeNodes
{
    public class ArrayTypeNode :TypeNode
    {
        public ArrayTypeNode(CommonTree node)
            : base(node)
        {

        }
        public ArrayTypeNode(IToken t)
            : base(t)
        {

        }
        public ArrayTypeNode(int t)
            : base(new CommonToken(t, "ArrayTypeNode"))
        {

        }

        public override ITree DupNode()
        {
            return new ArrayTypeNode(Type);
        }

        public TypeNode TypeNode
        {
            get
            {
                return GetChild(0) as TypeNode;
            }
        }

        public ExpressionNode EpressionNode
        {
            get
            {
                return GetChild(1) as ExpressionNode;
            }
        }

        public override string TypeName
        {
            get { return string.Format("array({0})", TypeNode.TypeName); }
        }
    }
}
