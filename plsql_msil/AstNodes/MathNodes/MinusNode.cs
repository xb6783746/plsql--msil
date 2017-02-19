﻿using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.MathNodes
{
    class MinusNode : BinaryOperator
    {

        public MinusNode(CommonTree node)
            : base(node)
        {

        }
        public MinusNode(IToken t)
            : base(t)
        {

        }
        public MinusNode(int t)
            : base(new CommonToken(t, "-"))
        {

        }

        public override ITree DupNode()
        {
            return new MinusNode(Type);
        }

        public bool isUnary
        {
            get { return ChildCount < 2; }
        }
    }
}
