using System.Collections.Generic;
using Antlr.Runtime.Tree;
using plsqlBasic.Loggers;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.Semantic;
using plsql_msil.Types;

namespace plsqlSemanticAnalyser.Semantic.Passes
{

    class OperatorPass: Analyser, IPass
    {

        public OperatorPass(TypeStorage types, ILogger logger)
            :base(types, logger)
        {
        }

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
        //private TypeInfo Visit(PlusNode node)
        //{
        //    return BinaryOperator(node, "Plus");
        //}
        //private TypeInfo Visit(MinusNode node)
        //{
        //    return BinaryOperator(node, "Minus");
        //}
        //private TypeInfo Visit(MultNode node)
        //{
        //    return BinaryOperator(node, "Mul");
        //}
        //private TypeInfo Visit(DivNode node)
        //{
        //    return BinaryOperator(node, "Div");
        //}
        //private TypeInfo Visit(ModNode node)
        //{
        //    return BinaryOperator(node, "Mod");
        //}
        //private TypeInfo Visit(EqualNode node)
        //{
        //    return BinaryOperator(node, "Equals");
        //}
        //private TypeInfo Visit(NotEqualNode node)
        //{
        //    return BinaryOperator(node, "NotEquals");
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

        //private TypeInfo BinaryOperator(BinaryOperator node, string methodName)
        //{

        //    var lType = Visit(node.LeftOperand as dynamic);
        //    var rType = Visit(node.RightOperand as dynamic);

        //    if (TypeInfo.IsNumeric(lType))
        //    {
        //        return lType;
        //    }

        //    var where = node.LeftOperand;
        //    var args = new List<BasicNode>() { node.RightOperand };

        //    var method = new SpecialMethodCallNode(methodName, where, args);

        //    ReplaceNode(node.Parent, node.ChildIndex, method);

        //    var classType = lType as ClassType;

        //    if (classType == null)
        //    {
        //        Log("Индексная операция не может быть применена", node);
        //        return TypeInfo.Undefined;
        //    }

        //    var methodInfo = classType.GetMethod(methodName, new List<TypeInfo>() { rType }, false);

        //    if (methodInfo == null)
        //    {
        //        Log(string.Format("Операция {0} не может быть применена", methodName), node);
        //        return TypeInfo.Undefined;
        //    }

        //    return methodInfo.Ret;

        //}

       

        void ReplaceNode(ITree parent, int index, BasicNode node)
        {
            parent.ReplaceChildren(index, index, node);
            node.Parent = parent;
            node.ChildIndex = index;
        }

    }
}
