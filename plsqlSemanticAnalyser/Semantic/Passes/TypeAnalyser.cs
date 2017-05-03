using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsqlBasic.Loggers;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.Semantic;
using plsql_msil.Types;
using BinaryOperator = plsql_msil.AstNodes.MathNodes.BinaryOperator;

namespace plsqlSemanticAnalyser.Semantic.Passes
{
    class TypeAnalyser : Analyser
    {

        public TypeAnalyser(TypeStorage types, ILogger logger)
            :base(types, logger)
        {
        }

        public bool Check(CodeBlockNode node, Context context)
        {
            Visit(node, context);

            return !Error;
        }

        //TODO ПЛОХО
        private Dictionary<string, string> operatorMethodsName = new Dictionary<string, string>()
        {
            {"+", "Plus"},
            {"-", "Minus"},
            {"*", "Mul"},
            {"/", "Div"},
            {"%", "Mod"}
        };

        private TypeDescriptor Visit(BoolNode node, Context context)
        {
            return TypeDescriptor.Bool;
        }
        private TypeDescriptor Visit(CharNode node, Context context)
        {
            return TypeDescriptor.Char;
        }
        private TypeDescriptor Visit(FloatNode node, Context context)
        {
            return TypeDescriptor.Float;
        }
        private TypeDescriptor Visit(IntegerNode node, Context context)
        {
            return TypeDescriptor.Int;
        }
        private TypeDescriptor Visit(RealNode node, Context context)
        {
            return TypeDescriptor.Double;
        }
        private TypeDescriptor Visit(StringNode node, Context context)
        {
            return TypeDescriptor.String;
        }

        private TypeDescriptor Visit(CodeBlockNode node, Context context)
        {
            if (node.ChildCount == 0)
            {
                return null;
            }

            foreach (dynamic item in node.Children)
            {
                Visit(item, context);
            }

            return null;
        }  

        private TypeDescriptor Visit(VarNode node, Context context)
        {
            var var = context.GetVar(node.VarName);

            if (var == null)
            {
                var type = context.GetType(node.VarName);

                if (type == null)
                {
                    Log(string.Format("Переменная {0} не существует", node.VarName), node);

                    return TypeDescriptor.Undefined;
                }
                else 
                {
                    int index = node.ChildIndex;

                    var packageNameNode = new PackageNameNode(node.VarName);

                    node.Parent.ReplaceChildren(index, index, packageNameNode);

                    return new TypeDescriptor(false, type);
                }
            }

            return new TypeDescriptor(true, var.Type, true);
        }
        private TypeDescriptor Visit(SelfNode node, Context context)
        {
            if (context.Self == null || context.CurrentMethod == null || context.CurrentMethod.IsStatic)
            {
                Log("Self не может вызываться в данном контексте", node);

                return TypeDescriptor.Undefined;
            }

            return new TypeDescriptor(false, context.Self, true);
        }

        private TypeDescriptor Visit(CreateInstanceNode node, Context context)
        {
            var type = context.GetType(node.TypeName) as ClassType;

            if(type == null)
            {
                Log(string.Format("Класс {0} не существует", node.TypeName), node);

                return TypeDescriptor.Undefined;
            }

            var typeList = new List<TypeInfo>();

            foreach(dynamic item in node.Arguments)
            {
                typeList.Add(Visit(item, context).Type);
            }

            if(!type.ContainsConstructor(typeList))
            {
                Log(string.Format("У класса {0} нет конструктора, принимающего данные аргументы", node.TypeName), node);

                return TypeDescriptor.Undefined;
            }

            return new TypeDescriptor(false, type, true);
        }
        private TypeDescriptor Visit(CreateTableNode node, Context context)
        {

            TypeInfo res;

            if (!node.IsTable)
            {
                res = builder.GenerateDictionaryType(node.TypeNode, node.ValueTypeNode);
            }
            else
            {
                res = builder.GenerateTableType(node.TypeNode);
            }

            context.Types.AddType(res);

            return new TypeDescriptor(false, res, true);
        }

        private TypeDescriptor Visit(CreateArrayNode node, Context context)
        {

            TypeInfo res = builder.GenerateArrayType(node.TypeNode);

            return new TypeDescriptor(false, res, true);
        }

        private TypeDescriptor Visit(MethodCallNode node, Context context)
        {
            TypeDescriptor where = Visit(node.Where as dynamic, context);

            var whereType = where.Type as ClassType;

            if (whereType == null)
            {
                Log(string.Format("Невозможно вызвать метод {0}", node.MethodName), node);

                return TypeDescriptor.Undefined;
            }

            List<TypeInfo> types = new List<TypeInfo>();
            foreach (dynamic item in node.Arguments)
            {
                var argType = Visit(item, context);

                types.Add(argType.Type);
            }

            var method = whereType.GetMethod(node.MethodName, types, !where.IsObject);

            if (method == null)
            {
                Log(string.Format("Метод {0} с данными аргументами не существует", node.MethodName), node);

                return TypeDescriptor.Undefined;
            }

            return new TypeDescriptor(false, method.Ret, true);
        }

        private TypeDescriptor Visit(ExpressionNode node, Context context)
        {
            return Visit(node.Expression as dynamic, context);
        }

        private TypeDescriptor Visit(PlusNode node, Context context)
        {
            return MathOperator(node, context);
        }
        private TypeDescriptor Visit(MinusNode node, Context context)
        {
            if (node.isUnary)
            {
                var operand = Visit(node.LeftOperand as dynamic, context);

                if (TypeInfo.IsNumeric(operand))
                {
                    Log(
                        string.Format("Оператор {0} не может применяться для типа {1}",
                            node.Text,
                            operand.Type.ToString()),
                        node);

                    return TypeDescriptor.Undefined;
                }

                return operand;
            }
            else
            {
                return MathOperator(node, context);
            }
        }
        private TypeDescriptor Visit(MultNode node, Context context)
        {
            return MathOperator(node, context);
        }
        private TypeDescriptor Visit(DivNode node, Context context)
        {
            return MathOperator(node, context);
        }
        private TypeDescriptor Visit(ModNode node, Context context)
        {
            return MathOperator(node, context);
        }

        private TypeDescriptor MathOperator(BinaryOperator node, Context context)
        {
            var lOperand = Visit(node.LeftOperand as dynamic, context);
            var rOperand = Visit(node.RightOperand as dynamic, context);

            if (!TypeInfo.IsNumeric(lOperand.Type) || !TypeInfo.IsNumeric(rOperand.Type))
            {
                return TryToOverload(node, lOperand, rOperand, context);
            }

            var type = Convert(lOperand.Type as SimpleType, rOperand.Type as SimpleType);

            if (!lOperand.Type.Equals(type))
            {
                InsertCastNode(node, node.LeftOperand.ChildIndex, type);
            }
            if (!rOperand.Type.Equals(type))
            {
                InsertCastNode(node, node.RightOperand.ChildIndex, type);
            }

            return new TypeDescriptor(false, type);

        }

        private TypeDescriptor Visit(GreaterNode node, Context context)
        {
            return RelationOperator(node, context);
        }
        private TypeDescriptor Visit(LessNode node, Context context)
        {
            return RelationOperator(node, context);
        }
        private TypeDescriptor Visit(GreaterOrEqualNode node, Context context)
        {
            return RelationOperator(node, context);
        }
        private TypeDescriptor Visit(LessOrEqualNode node, Context context)
        {
            return RelationOperator(node, context);
        }
        private TypeDescriptor Visit(EqualNode node, Context context)
        {
            return RelationOperator(node, context);
        }
        private TypeDescriptor Visit(NotEqualNode node, Context context)
        {
            return RelationOperator(node, context);
        }

        private TypeDescriptor RelationOperator(BinaryOperator node, Context context)
        {
            var lOperand = Visit(node.LeftOperand as dynamic, context);
            var rOperand = Visit(node.RightOperand as dynamic, context);

            if (!TypeInfo.IsNumeric(lOperand.Type) || !TypeInfo.IsNumeric(rOperand.Type))
            {
                return TryToOverload(node, lOperand, rOperand, context);
            }

            var type = Convert(lOperand.Type as SimpleType, rOperand.Type as SimpleType);

            if (!lOperand.Type.Equals(type))
            {
                InsertCastNode(node, node.LeftOperand.ChildIndex, type);
            }
            if (!rOperand.Type.Equals(type))
            {
                InsertCastNode(node, node.RightOperand.ChildIndex, type);
            }

            return TypeDescriptor.Bool;
        }

        private TypeDescriptor Visit(AndNode node, Context context)
        {
            return LogicOperator(node, context);
        }
        private TypeDescriptor Visit(OrNode node, Context context)
        {
            return LogicOperator(node, context);
        }
        private TypeDescriptor Visit(NotNode node, Context context)
        {
            var operand = Visit(node.Operand as dynamic, context);

            if (!IsBoolType(operand.Type))
            {
                Log(
                    String.Format("Оператор {0} не может применяться для типа {1}",
                        node.Text,
                        operand.Type.ToString()),
                    node);

                return TypeDescriptor.Undefined;
            }

            return operand;
        }

        private TypeDescriptor LogicOperator(BinaryOperator node, Context context)
        {
            var lOperand = Visit(node.LeftOperand as dynamic, context);
            var rOperand = Visit(node.RightOperand as dynamic, context);

            if (!TypeInfo.IsBool(lOperand.Type) || !TypeInfo.IsBool(rOperand.Type))
            {
                return TryToOverload(node, lOperand, rOperand, context);
            }

            var type = Convert(lOperand.Type as SimpleType, rOperand.Type as SimpleType);

            if (!lOperand.Type.Equals(type))
            {
                InsertCastNode(node, node.LeftOperand.ChildIndex, type);
            }
            if (!rOperand.Type.Equals(type))
            {
                InsertCastNode(node, node.RightOperand.ChildIndex, type);
            }

            return TypeDescriptor.Bool;
        }

        private TypeDescriptor Visit(CastNode node, Context context)
        {
            var expType = Visit(node.Expression as dynamic, context);
            var convertType = context.GetType(node.TypeNode.TypeName);

            if (!TypeInfo.IsNumeric(expType.Type) || !TypeInfo.IsNumeric(convertType))
            {
                Log(
                    "Явное преобразование может применяться только для числовых типов",
                    node);

                return TypeDescriptor.Undefined;
            }

            node.Type = convertType;

            return new TypeDescriptor(false, convertType);

        }

        private TypeDescriptor Visit(AssignNode node, Context context)
        {
            TypeDescriptor lValue = Visit(node.LValue as dynamic, context);
            var rValue = Visit(node.Expression as dynamic, context);

            if (lValue.Type.Equals(TypeInfo.Undefined) || rValue.Type.Equals(TypeInfo.Undefined))
            {
                return TypeDescriptor.Undefined;
            }

            if (!lValue.IsLvalue)
            {
                Log("Выражение не lvalue", node);

                return TypeDescriptor.Undefined;
            }

            if (!lValue.Type.CanBeAssignedWith(rValue.Type))
            {
                Log(
                    string.Format("Типы {0} и {1} не совместимы",
                        lValue.Type.ToString(),
                        rValue.Type.ToString()),
                    node);

                return TypeDescriptor.Undefined;
            }

            return lValue;
        }
        private TypeDescriptor Visit(ForNode node, Context context)
        {
            Visit(node.Init as dynamic, context);

            var type = Visit(node.Condition as dynamic, context);

            Visit(node.Iteration as dynamic, context);

            Visit(node.CodeBlock, context);

            if (!IsBoolType(type.Type))
            {
                Log(
                    "В цикле for условие должно быть типа bool",
                    node);
            }

            return null;
        }
        private TypeDescriptor Visit(WhileNode node, Context context)
        {
            Visit(node.Condition, context);

            Visit(node.Command, context);

            return null;
        }
        private TypeDescriptor Visit(DoWhileNode node, Context context)
        {
            Visit(node.Condition, context);

            Visit(node.Command, context);

            return null;
        }
        private TypeDescriptor Visit(IfNode node, Context context)
        {
            Visit(node.Condition, context);

            Visit(node.IfTrue, context);

            if (node.IfFalse != null)
            {
                Visit(node.IfFalse, context);
            }

            return null;
        }
        
        private TypeDescriptor Visit(MemberCallNode node, Context context)
        {
            var where = Visit(node.Where as dynamic, context);
            var field = where.Type.GetField(node.MemberName);

            if (field == null)
            {
                Log(string.Format("Поля {0} не существует", node.MemberName), node);

                return TypeDescriptor.Undefined;
            }

            if (!where.IsObject && !(where.Type is PackageType))
            {
                Log(string.Format("Невозможно вызвать поле {0} не на экземпляре", node.MemberName), node);

                return TypeDescriptor.Undefined;
            }

            return new TypeDescriptor(true, field.Type, true);
        }
        private TypeDescriptor Visit(ReturnNode node, Context context)
        {
            TypeDescriptor type = Visit(node.Expression, context);

            if (!context.CurrentMethod.Ret.CanBeAssignedWith(type.Type))
            {
                Log(string.Format("Попытка вернуть тип {0}, возвращаемый тип метода - {1}", 
                        type,
                        context.CurrentMethod.Ret
                    ), 
                    node);

                return TypeDescriptor.Undefined;
            }

            return type;
        }


        private TypeDescriptor TryToOverload(BinaryOperator node,
            TypeDescriptor leftType, TypeDescriptor rightType, Context context)
        {
            if (!leftType.IsObject || !operatorMethodsName.ContainsKey(node.Text))
            {
                Log(
                    String.Format("Оператор {0} не может применяться для типов {1} и {2}",
                        node.Text,
                        leftType.Type,
                        rightType.Type),
                    node);
                return TypeDescriptor.Undefined;
            }

            var classType = leftType.Type as ClassType;

            var method = classType.GetMethod(
                operatorMethodsName[node.Text],
                new List<TypeInfo>() {rightType.Type},
                false);

            if (method == null)
            {

                Log(
                    String.Format("Оператор {0} не может применяться для типов {1} и {2}",
                        node.Text,
                        leftType.Type,
                        rightType.Type),
                    node);
                return TypeDescriptor.Undefined;
            }

            var methodCallNode = new MethodCallNode(
                method.Name,
                node.LeftOperand,
                new List<BasicNode>() {node.RightOperand});

            ReplaceNode(node.Parent as CommonTree, node.ChildIndex, methodCallNode);

            return new TypeDescriptor(false, method.Ret, true);

        }

        private SimpleType Convert(SimpleType l, SimpleType r)
        {
            return l.SType < r.SType ? r : l;
        }
        private void InsertCastNode(CommonTree parent, int index, TypeInfo type)
        {
            CastNode newNode = new CastNode(new CommonToken(-1, "Cast"));
            newNode.Type = type;

            ReplaceNode(parent, index, newNode);

        }

        void ReplaceNode(ITree parent, int index, BasicNode node)
        {
            parent.ReplaceChildren(index, index, node);
            node.Parent = parent;
            node.ChildIndex = index;
        }

      
        private bool IsBoolType(TypeInfo type)
        {
            var boolType = type as SimpleType;

            return boolType != null
                && boolType.SType == SimpleTypeEnum.Bool;
        }

    }

}
