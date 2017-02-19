using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes
{
    abstract class BasicNode :CommonTree
    {

        public BasicNode(CommonTree node)
            : base(node)
        {

        }
        public BasicNode(IToken t)
            : base(t)
        {

        }

        public virtual TypeInfo TypeInfo { get; set; }

    }
}
