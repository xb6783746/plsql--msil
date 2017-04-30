using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.Types;

namespace plsql_msil.Optimization.Passes
{
    class ValInfo
    {
        public ValInfo():this(null, SimpleTypeEnum.Undefined, false)
        {
            
        }

        public ValInfo(object val, SimpleTypeEnum type, bool isConst)
        {
            this.val = val;
            this.type = type;
            this.isConst = isConst;
        }

        public Object val;
        public SimpleTypeEnum type;
        public bool isConst;
    }

    class ConstantConvolution: IPass
    {


        public void Check(CommonTree tree)
        {
            Visit(tree);

        }

        private ValInfo Visit(CommonTree node)
        {
            if (node == null || node.ChildCount == 0)
            {
                return null;
            }

            for(int i = 0; i < node.ChildCount; i++)
            {
                Visit(node.GetChild(i) as dynamic);
            }

            return null;
        }

        private ValInfo Visit(ExpressionNode node)
        {
            Visit(node.Expression as dynamic);

            return null;
        }

        private ValInfo Visit(BoolNode node)
        {
            return new ValInfo(node.Value, SimpleTypeEnum.Bool, true);
        }
        private ValInfo Visit(CharNode node)
        {
            return new ValInfo(node.Value, SimpleTypeEnum.Char, true);
        }
        private ValInfo Visit(FloatNode node)
        {
            return new ValInfo(node.Value, SimpleTypeEnum.Float, true);
        }
        private ValInfo Visit(IntegerNode node)
        {
            return new ValInfo(node.Value, SimpleTypeEnum.Int, true);
        }
        private ValInfo Visit(RealNode node)
        {
            return new ValInfo(node.Value, SimpleTypeEnum.Double, true);
        }

        private ValInfo Visit(PlusNode node)
        {
            return BinaryOperator(node, (x, y) => x + y);
        }
        private ValInfo Visit(MinusNode node)
        {
            if (!node.isUnary) return BinaryOperator(node, (x, y) => x - y);

            ValInfo va = Visit(node.LeftOperand as dynamic);

            if (va.isConst)
            {
                object obj = -(dynamic) va.val;
                ReplaceNode(node.Parent, node.ChildIndex, obj, va.type);

                return new ValInfo(obj, va.type, true);
            }

            return new ValInfo();
        }
        private ValInfo Visit(MultNode node)
        {
            return BinaryOperator(node, (x, y) => x * y);
        }
        private ValInfo Visit(DivNode node)
        {
            return BinaryOperator(node, (x, y) => x / y);
        }
        private ValInfo Visit(ModNode node)
        {
            return BinaryOperator(node, (x, y) => x % y);
        }

        private ValInfo BinaryOperator(BinaryOperator node, Func<dynamic, dynamic, object> func)
        {
            ValInfo lV = Visit(node.LeftOperand as dynamic);
            ValInfo rV = Visit(node.RightOperand as dynamic);

            if (lV == null || rV == null)
            {
                return null;
            }

            if (lV.isConst && rV.isConst && lV.type == rV.type)
            {
                object val = func(lV.val, rV.val);

                ReplaceNode(node.Parent, node.ChildIndex, val, lV.type);
                return new ValInfo(val, rV.type, true);
            }

            return new ValInfo();
        }

        private ValInfo Visit(AndNode node)
        {
            return BinaryOperator(node, (x, y) => x && y);
        }
        private ValInfo Visit(OrNode node)
        {
            return BinaryOperator(node, (x, y) => x || y);
        }
        private ValInfo Visit(NotNode node)
        {
            ValInfo val = Visit(node.Operand as dynamic);

            if (val.isConst)
            {
                object obj = !(dynamic) val.val;
                ReplaceNode(node.Parent, node.ChildIndex, obj, val.type);

                return new ValInfo(obj, val.type, true);
            }

            return new ValInfo();
        }

        private ValInfo Visit(GreaterNode node)
        {
            return BinaryOperator(node, (x, y) => x > y);
        }
        private ValInfo Visit(LessNode node)
        {
            return BinaryOperator(node, (x, y) => x < y);
        }
        private ValInfo Visit(GreaterOrEqualNode node)
        {
            return BinaryOperator(node, (x, y) => x >= y);
        }
        private ValInfo Visit(LessOrEqualNode node)
        {
            return BinaryOperator(node, (x, y) => x <= y);
        }
        private ValInfo Visit(EqualNode node)
        {
            return BinaryOperator(node, (x, y) => x == y);
        }
        private ValInfo Visit(NotEqualNode node)
        {
            return BinaryOperator(node, (x, y) => x != y);
        }

        private ValInfo Visit(CastNode node)
        {
            ValInfo val = Visit(node.Expression);

            var type = node.Type as SimpleType;

            if (val == null)
            {
                return null;
            }

            if (val.isConst && type != null)
            {
                object obj = null;

                switch (type.SType)
                {
                    case SimpleTypeEnum.Bool:
                        obj = (bool)val.val;
                        break;
                    case SimpleTypeEnum.Byte:
                        obj = (byte)val.val;
                        break;
                    case SimpleTypeEnum.Char:
                        obj = (char)val.val;
                        break;
                    case SimpleTypeEnum.Int:
                        obj = (int)val.val;
                        break;
                    case SimpleTypeEnum.Float:
                        obj = (float)val.val;
                        break;
                    case SimpleTypeEnum.Double:
                        obj = (double)val.val;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return new ValInfo(obj, type.SType, true);
            }

            return new ValInfo();
        }

        void ReplaceNode(ITree parent, int index, object val, SimpleTypeEnum type)
        {
            CommonTree node = null;
            var token = new CommonToken(-1, val.ToString());
            switch (type)
            {
                case SimpleTypeEnum.Bool:
                    node = new BoolNode(token);
                    break;
                case SimpleTypeEnum.Byte:
                    node = new ByteNode(token);
                    break;
                case SimpleTypeEnum.Char:
                    node = new CharNode(token);
                    break;
                case SimpleTypeEnum.Int:
                    node = new IntegerNode(token);
                    break;
                case SimpleTypeEnum.Float:
                    node = new FloatNode(token);
                    break;
                case SimpleTypeEnum.Double:
                    node = new RealNode(token);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type", type, null);
            }

            parent.ReplaceChildren(index, index, node);
        }

    }
}
