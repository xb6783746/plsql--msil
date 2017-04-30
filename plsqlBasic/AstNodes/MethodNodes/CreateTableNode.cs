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
    public class CreateTableNode :TypeNode
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

        public bool IsTable
        {
            get { return ChildCount == 1; }
        }
        public TypeNode TypeNode
        {
            get { return GetChild(0) as TypeNode; }
        }

        public override string TypeName
        {
            get { return string.Format("table({0})", TypeNode.TypeName); }
        }
        public TypeNode ValueTypeNode
        {
            get { return GetChild(1) as TypeNode; }
        }

    }
}
