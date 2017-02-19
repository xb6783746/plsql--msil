using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes
{
    class BinaryOperator :BasicNode
    {
        public BinaryOperator(CommonTree node)
            : base(node)
        {

        }
        public BinaryOperator(IToken t)
            : base(t)
        {

        }

        public BasicNode LeftOperand
        {
            get
            {
                return this.GetChild(0) as BasicNode;
            }
        }
        public BasicNode RightOperand
        {
            get
            {
                return this.GetChild(1) as BasicNode;
            }
        }
    }
}
