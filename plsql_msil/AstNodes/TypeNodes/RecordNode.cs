using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes.OtherNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.AstNodes.TypeNodes
{
    class RecordNode :BasicNode
    {
        public RecordNode(CommonTree node)
            : base(node)
        {

        }
        public RecordNode(IToken t)
            : base(t)
        {

        }
        public RecordNode(int t)
            : base(new CommonToken(t, "RecordNode"))
        {

        }

        public override ITree DupNode()
        {
            return new RecordNode(Type);
        }

        public string Name
        {
            get
            {
                return GetChild(0).Text;
            }
        }

        public List<VarDefNode> Vars
        {
            get
            {
                List<VarDefNode> res = new List<VarDefNode>();

                var varList = GetChild(1);

                for (int i = 0; i < varList.ChildCount; i++)
                {
                    res.Add(varList.GetChild(i) as VarDefNode);
                }

                return res;
            }
        }
    }
}
