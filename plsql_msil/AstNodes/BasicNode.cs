using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.Types;

namespace plsql_msil.AstNodes
{
    class BasicNode :CommonTree
    {
        public BasicNode(CommonTree node)
            : base(node)
        {

        }

        public BasicNode(IToken t)
            : base(t)
        {

        }

        //public virtual TypeInfo TypeInfo { get; set; }

    }
}
