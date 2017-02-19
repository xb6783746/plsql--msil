using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.TypeNodes
{
    class TypeNode :BasicNode
    {
        public TypeNode(CommonTree node)
            : base(node)
        {

        }
        public TypeNode(IToken t)
            : base(t)
        {

        }
        public TypeNode(int t)
            : base(new CommonToken(t, "void"))
        {

        }

        public override ITree DupNode()
        {
            return new TypeNode(Type);
        }

        public virtual string PackageName
        {
            get
            {
                if(ChildCount == 0)
                {
                    return null;
                }
                else
                {
                    return GetChild(0).Text;
                }
            }
        }
        public virtual string TypeName
        {
            get
            {
                if (ChildCount == 0)
                {
                    return Text;
                }
                else
                {
                    return GetChild(0).Text + "." + GetChild(1).Text;
                }
            }
        }
    }
}
