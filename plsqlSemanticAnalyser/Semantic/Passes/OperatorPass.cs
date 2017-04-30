using System.Collections.Generic;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.SpecialMethodNodes;

namespace plsql_msil.Semantic.Passes
{

    class OperatorPass: IPass
    {


        public bool Check(CommonTree tree)
        {
            Visit(tree);

            return true;
        }

        private void Visit(CommonTree node)
        {
            if (node == null || node.ChildCount == 0)
            {
                return;
            }

            for(int i = 0; i < node.ChildCount; i++)
            {
                Visit(node.GetChild(i) as dynamic);
            }

        }

        private void Visit(ExpressionNode node)
        {
            Visit(node.Expression as dynamic);

        }

        private void Visit(AssignNode node)
        {
            if (node.LValue.Expression is IndexNode)
            {
                var indexNode = node.LValue.Expression as IndexNode;

                var where = indexNode.Where;
                var args = new List<BasicNode>() {indexNode.Index, node.Expression};

                var method = new MethodCallNode("Set", where, args);

                ReplaceNode(node.Parent, node.ChildIndex, method);

                Visit(indexNode.Where as dynamic);
                Visit(node.Expression as dynamic);
            }
            else
            {
                Visit(node.LValue as dynamic);

                Visit(node.Expression as dynamic);
            }
        }
        //private void Visit(PlusNode node)
        //{
        //     BinaryOperator(node, "Plus");
        //}
        //private void Visit(MinusNode node)
        //{
        //    BinaryOperator(node, "Minus");
        //}
        //private void Visit(MultNode node)
        //{
        //     BinaryOperator(node, "Mul");
        //}
        //private void Visit(DivNode node)
        //{
        //     BinaryOperator(node, "Div");
        //}
        //private void Visit(ModNode node)
        //{
        //     BinaryOperator(node, "Mod");
        //}
        //private void Visit(EqualNode node)
        //{
        //     BinaryOperator(node, "Equals");
        //}
        //private void Visit(NotEqualNode node)
        //{
        //     BinaryOperator(node, "NotEquals");
        //}
        private void Visit(IndexNode node)
        {
            var where = node.Where;
            var args = new List<BasicNode>() { node.Index };

            var method = new MethodCallNode("Get", where, args);

            ReplaceNode(node.Parent, node.ChildIndex, method);

            Visit(where as dynamic);
            Visit(node.Index as dynamic);

        }

        private void BinaryOperator(BinaryOperator node, string methodName)
        {
            var where = node.LeftOperand;
            var args = new List<BasicNode>() {node.RightOperand};

            var method = new SpecialMethodCallNode(methodName, where, args);

            ReplaceNode(node.Parent, node.ChildIndex, method);


        }

       

        void ReplaceNode(ITree parent, int index, BasicNode node)
        {
            parent.ReplaceChildren(index, index, node);
            node.Parent = parent;
            node.ChildIndex = index;
        }

    }
}
