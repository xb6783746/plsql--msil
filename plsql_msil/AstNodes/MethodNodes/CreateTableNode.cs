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
    class CreateTableNode :BasicNode
    {
        public CreateTableNode(CommonTree node)
            : base(node)
        {

        }
        public CreateTableNode(IToken t)
            : base(t)
        {

        }
        public CreateTableNode(int t)
            : base(new CommonToken(t, "CreateTable"))
        {

        }

        public override ITree DupNode()
        {
            return new CreateTableNode(Type);
        }


        public TypeNode TypeNode
        {
            get { return GetChild(0) as TypeNode; }
        }

        public TypeInfo TableType { get; set; }
    }
}
