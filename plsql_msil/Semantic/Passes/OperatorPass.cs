using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.SpecialMethodNodes;
using plsql_msil.Loggers;
using plsql_msil.Optimization.Passes;
using plsql_msil.Types;

namespace plsql_msil.Semantic.Passes
{

    class OperatorPass: IPass
    {


        public bool Check(CommonTree tree, ILogger logger)
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

            foreach (var item in node.Children)
            {
                Visit(item as dynamic);
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

                var method = new SpecialMethodCallNode("Set", where, args);

                node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, method);

                Visit(indexNode.Where);
                Visit(node.Expression);
            }
            else
            {
                Visit(node.LValue);

                Visit(node.Expression);
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

            var method = new SpecialMethodCallNode("Get", where, args);

            node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, method);
        }

        private void BinaryOperator(BinaryOperator node, string methodName)
        {
            var where = node.LeftOperand;
            var args = new List<BasicNode>() {node.RightOperand};

            var method = new SpecialMethodCallNode(methodName, where, args);

            node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, method);
        }

       

        void ReplaceNode(ITree parent, int index, BasicNode node)
        {
           
        }

    }
}
