using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.SpecialNodes;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration
{
    class AssignPass :IPreGenPass
    {

        private GenericType genericFirst = new GenericType();
        private GenericType genericSecond = new GenericType(1);

        public void Pass(CommonTree tree)
        {
            Visit(tree);
        }

        private void Visit(CommonTree node) 
        {
            if(node.Children == null)
            {
                return;
            }

            for (int i = 0; i < node.ChildCount; i++)
            {
                var item = node.GetChild(i);

                if (item is AssignNode)
                {
                    Visit(item as AssignNode);
                }

                Visit(item as CommonTree);
            }
        }

        private void Visit(AssignNode node) 
        {
            CommonTree replace = null;
            CommonTree parent = node.LValue;
            int index = node.LValue.ChildIndex;

            var lvalue = node.LValue.Expression;

            if (lvalue is VarNode)
            {
                replace = new AssignVarNode(lvalue as VarNode);
            }
            else if (lvalue is MemberCallNode)
            {

                replace = new AssignMemberCallNode(lvalue as MemberCallNode);
            }
            else if (lvalue is IndexNode)
            {
                var indexNode = lvalue as IndexNode;

                var methodInfo = new MethodInfo("set_Item", TypeInfo.Void, false, indexNode.TableType);
                methodInfo.AddArg("a", genericFirst);
                methodInfo.AddArg("b", genericSecond);

                parent = node.Parent as CommonTree;
                index = node.ChildIndex;

                replace = new CallvirtNode(
                    methodInfo, 
                    indexNode.Where, 
                    new List<ExpressionNode>() { indexNode.Index, node.Expression }
                    );
            }


            Replace(parent, replace, index);
        }

        private void Replace(CommonTree parent, CommonTree newNode, int index)
        {
            if (newNode != null)
            {
                parent.ReplaceChildren(index, index, newNode);
            }
        }

    }
}
