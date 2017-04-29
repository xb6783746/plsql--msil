using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Loggers;
using plsql_msil.Types;
using plsql_msil.Types.VarTypes;
using BinaryOperator = plsql_msil.AstNodes.MathNodes.BinaryOperator;

namespace plsql_msil.Semantic.Passes
{
    class DefinitionAnalyser : Analyser, IPass
    {

        public DefinitionAnalyser(TypeStorage types)
        {
            this.types = types;

            context = new Context(types);
            operatorTable = new OperatorTable();
        }

        private Context context;
        private OperatorTable operatorTable;

        public bool Check(CommonTree tree, ILogger logger)
        {
            this.logger = logger;

            Func<ITree, bool> predicate = x =>
                   x is DeclareBlockNode
                || x is ClassDefNode
                || x is PackageDefNode
                || x is EntryPointNode;


            foreach (dynamic item in tree.Children.Where(predicate))
            {
                Visit(item);
            }

            var notImplemented = context.Types.Types.Where(x => !x.IsImplemented);

            if (notImplemented.Count() != 0)
            {
                string names = "";

                foreach (var item in notImplemented)
                {
                    names += item.ToString() + " ";
                }

                Log(String.Format("Типы {0} не реализованы", names), null);

            }

            return !Error;
        }

        private TypeDescriptor Visit(EntryPointNode node)
        {
            var entryPoint = new MethodInfo("", TypeInfo.Void, false, null);

            context.CurrentMethod = entryPoint;

            foreach (dynamic item in node.DeclareItems)
            {
                Visit(item);
            }

            Visit(node.CodeBlock);

            return null;
        }

        private TypeDescriptor Visit(ClassDefNode node)
        {
            var type = context.GetType(node.Name) as ClassType;

            if (type == null)
            {
                Log(String.Format("Класс {0} определяет тело, но не определяет интерфейс", node.Name), node);

                return null;
            }

            if (type.IsImplemented)
            {
                Log(String.Format("Класс {0} уже определил тело", node.Name), node);

                return null;
            }

            context.EnterClass(type);

            List<MethodInfo> allMethods = new List<MethodInfo>(type.Methods);

            foreach (var item in node.Defs)
            {
                var method = Visit(item, type);

                if (method != null)
                {
                    allMethods.RemoveAll(x => x.Name == method.Name && TypeInfo.Compare(x.ArgTypes, method.ArgTypes));
                }
            }

            if (allMethods.Count != 0)
            {
                string methods = "";

                foreach (var item in allMethods)
                {
                    methods += item.Name + " ";
                }

                Log(String.Format("В классе {0} методы {1}объявлены, но не реализованы", node.Name, methods), node);
            }

            context.ExitClass();

            type.IsImplemented = true;

            var constructor = new ConstructorInfo(false, type);

            foreach (var item in type.Fields)
            {
                constructor.AddArg(item.Name, item.Type);
            }

            type.AddConstructor(constructor);

            return null;
        }
        private TypeDescriptor Visit(PackageDefNode node)
        {
            var type = context.GetType(node.Name) as PackageType;

            if (type == null)
            {
                Log(String.Format("Пакет {0} определяет тело, но не определяет интерфейс", node.Name), node);

                return null;
            }

            if (type.IsImplemented)
            {
                Log(String.Format("Пакет {0} уже определил тело", node.Name), node);

                return null;
            }

            List<MethodInfo> allMethods = new List<MethodInfo>(type.Methods);

            foreach (var item in node.Defs)
            {
                var method = Visit(item, type);

                if (method != null)
                {
                    allMethods.RemoveAll(x => x.Name == method.Name && TypeInfo.Compare(x.ArgTypes, method.ArgTypes));
                }
            }

            if (allMethods.Count != 0)
            {
                string methods = "";

                foreach (var item in allMethods)
                {
                    methods += item.Name + " ";
                }

                Log(String.Format("В пакете {0} методы {1} объявлены, но не реализованы", node.Name, methods), node);
            }

            type.IsImplemented = true;

            return null;

        }

        private MethodInfo Visit(MethodDefNode node, ClassType type)
        {

            var defined = GetMethod(node.MethodDecl);

            var declared = type.GetMethod(defined.Name, defined.Args.Select(x => x.Type).ToList(), IsStatic(node.MethodDecl.Modifier));

            if (declared == null)
            {
                Log(
                    String.Format("Метод {0} определен в теле пакета {1}, но не определен в интерфейсе",
                        node.MethodDecl.MethodName,
                        type.Name),
                    node);

            }

            //context.EnterBlock();

            //foreach (var item in declared.Arguments)
            //{
            //    context.Vars.AddVar(item);
            //}

            context.CurrentMethod = declared;

            var locals = GetLocalVars(node.DeclareBlock);

            foreach (var item in locals)
            {
                declared.AddVar(item.Name, item.Type);
                //context.Vars.AddVar(item.Name, item.Type, VarLocation.Local);
            }

            Visit(node.Commands);

            context.CurrentMethod = null;
            //context.ExitBlock();

            return declared;
        }

        private TypeDescriptor Visit(BoolNode node)
        {
            return TypeDescriptor.Bool;
        }
        private TypeDescriptor Visit(CharNode node)
        {
            return TypeDescriptor.Char;
        }
        private TypeDescriptor Visit(FloatNode node)
        {
            return TypeDescriptor.Float;
        }
        private TypeDescriptor Visit(IntegerNode node)
        {
            return TypeDescriptor.Int;
        }
        private TypeDescriptor Visit(RealNode node)
        {
            return TypeDescriptor.Double;
        }
        private TypeDescriptor Visit(StringNode node)
        {
            return TypeDescriptor.String;
        }

        private TypeDescriptor Visit(CodeBlockNode node)
        {
            if (node.ChildCount == 0)
            {
                return null;
            }

            foreach (dynamic item in node.Children)
            {
                Visit(item);
            }

            return null;
        }

        private TypeDescriptor Visit(VarDefNode node)
        {
            var var = GetVar(node);

            if (context.CurrentMethod != null)
            {
                bool res = context.CurrentMethod.AddVar(var.Name, var.Type);

                if (!res)
                {
                    Log(String.Format("Переменная {0} уже определена", node.VarName), node);
                }
            }

            return null;
        }

        private TypeDescriptor Visit(VarNode node)
        {
            var var = context.GetVar(node.VarName);

            if (var == null)
            {
                var type = context.GetType(node.VarName);

                if (type == null)
                {
                    Log(String.Format("Переменная {0} не существует", node.VarName), node);

                    return TypeDescriptor.Undefined;
                }
                else
                {
                    int index = node.ChildIndex;

                    var packageNameNode = new PackageNameNode(node.VarName);
                    //packageNameNode.TypeInfo = type;

                    node.Parent.ReplaceChildren(index, index, packageNameNode);

                    return new TypeDescriptor(false, type);
                }
            }

            //node.TypeInfo = var.Type;
            //node.VarInfo = var;

            return new TypeDescriptor(true, var.Type, true);
        }
        private TypeDescriptor Visit(SelfNode node)
        {
            if (context.Self == null || context.CurrentMethod == null || context.CurrentMethod.IsStatic)
            {
                Log("Self не может вызываться в данном контексте", node);

                return TypeDescriptor.Undefined;
            }

            //node.TypeInfo = context.Self;

            return new TypeDescriptor(false, context.Self, true);
        }

        private TypeDescriptor Visit(CreateInstanceNode node)
        {
            var type = context.GetType(node.TypeName);

            if(type == null || type.Type != Types.Type.Class)
            {
                Log(String.Format("Класс {0} не существует", node.TypeName), node);

                return TypeDescriptor.Undefined;
            }

            var typeList = new List<TypeInfo>();

            foreach(dynamic item in node.Arguments)
            {
                typeList.Add(Visit(item).Type);
            }

            if(!type.ContainsConstructor(typeList))
            {
                Log(string.Format("У класса {0} нет конструктора, принимающего данные аргументы", node.TypeName), node);

                return TypeDescriptor.Undefined;
            }

            //node.TypeInfo = type;
            //node.Constructor = typeList;

            return new TypeDescriptor(false, type, true);
        }
        private TypeDescriptor Visit(CreateTableNode node)
        {
            //node.TableType = context.GetType(node.TypeName);

            TypeInfo res;

            if (!node.IsTable)
            {
                res = GenerateDictionaryType(node.TypeNode, node.ValueTypeNode);
            }
            else
            {
                res = GenerateTableType(node.TypeNode);
            }

            node.TableType = res;
            context.Types.AddType(res);

            return new TypeDescriptor(false, res, true);
        }
        private TypeDescriptor Visit(MethodCallNode node)
        {
            TypeDescriptor where = Visit(node.Where as dynamic);

            List<TypeInfo> types = new List<TypeInfo>();
            foreach (dynamic item in node.Arguments)
            {
                var argType = Visit(item);

                types.Add(argType.Type);
            }

            var method = where.Type.GetMethod(node.MethodName, types, !where.IsObject);

            if (method == null)
            {
                Log(String.Format("Метод {0} с данными аргументами не существует", node.MethodName), node);

                return TypeDescriptor.Undefined;
            }

            //node.MethodInfo = method;

            return new TypeDescriptor(false, method.Ret);
        }

        private TypeDescriptor Visit(ExpressionNode node)
        {
            return Visit(node.Expression as dynamic);
        }

        private TypeDescriptor Visit(PlusNode node)
        {
            return MathOperator(node);
        }
        private TypeDescriptor Visit(MinusNode node)
        {
            if (node.isUnary)
            {
                var operand = Visit(node.LeftOperand as dynamic);

                if (!IsNumericType(operand))
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
            else
            {
                return MathOperator(node);
            }
        }
        private TypeDescriptor Visit(MultNode node)
        {
            return MathOperator(node);
        }
        private TypeDescriptor Visit(DivNode node)
        {
            return MathOperator(node);
        }
        private TypeDescriptor Visit(ModNode node)
        {
            return MathOperator(node);
        }

        private TypeDescriptor MathOperator(BinaryOperator node)
        {
            var lOperand = Visit(node.LeftOperand as dynamic);
            var rOperand = Visit(node.RightOperand as dynamic);

            if (!IsNumericType(lOperand.Type) || !IsNumericType(rOperand.Type))
            {
                Log(
                    string.Format("Оператор {0} не может применяться для типов {1} и {2}",
                        node.Text,
                        lOperand.Type.ToString(),
                        rOperand.Type.ToString()),
                    node);

                return TypeDescriptor.Undefined;
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

        private TypeDescriptor Visit(AndNode node)
        {
            return LogicOperator(node);
        }
        private TypeDescriptor Visit(OrNode node)
        {
            return LogicOperator(node);
        }
        private TypeDescriptor Visit(NotNode node)
        {
            var operand = Visit(node.Operand as dynamic);

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

        private TypeDescriptor Visit(GreaterNode node)
        {
            return LogicOperator(node);
        }
        private TypeDescriptor Visit(LessNode node)
        {
            return LogicOperator(node);
        }
        private TypeDescriptor Visit(GreaterOrEqualNode node)
        {
            return LogicOperator(node);
        }
        private TypeDescriptor Visit(LessOrEqualNode node)
        {
            return LogicOperator(node);
        }
        private TypeDescriptor Visit(EqualNode node)
        {
            return LogicOperator(node);
        }
        private TypeDescriptor Visit(NotEqualNode node)
        {
            return LogicOperator(node);
        }

        private TypeDescriptor LogicOperator(BinaryOperator node)
        {
            var lOperand = Visit(node.LeftOperand as dynamic);
            var rOperand = Visit(node.RightOperand as dynamic);

            if (!IsNumericType(lOperand.Type) || !IsNumericType(rOperand.Type))
            {
                Log(
                    String.Format("Оператор {0} не может применяться для типов {1} и {2}",
                        node.Text,
                        lOperand.Type.ToString(),
                        rOperand.Type.ToString()),
                    node);

                return TypeDescriptor.Undefined;
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

        private TypeDescriptor Visit(CastNode node)
        {
            var expType = Visit(node.Expression as dynamic);
            var convertType = context.GetType(node.TypeNode.TypeName);

            if (!IsNumericType(expType.Type) || !IsNumericType(convertType))
            {
                Log(
                    "Явное преобразование может применяться только для числовых типов",
                    node);

                return TypeDescriptor.Undefined;
            }

            node.Type = convertType;

            return new TypeDescriptor(false, convertType);

        }

        private TypeDescriptor Visit(AssignNode node)
        {
            TypeDescriptor lValue = Visit(node.LValue as dynamic);
            var rValue = Visit(node.Expression as dynamic);

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
        private TypeDescriptor Visit(ForNode node)
        {
            Visit(node.Init as dynamic);

            var type = Visit(node.Condition as dynamic);

            Visit(node.Iteration as dynamic);

            Visit(node.CodeBlock);

            if (!IsBoolType(type.Type))
            {
                Log(
                    "В цикле for условие должно быть типа bool",
                    node);
            }

            return null;
        }
        private TypeDescriptor Visit(WhileNode node)
        {
            Visit(node.Condition);

            Visit(node.Command);

            return null;
        }
        private TypeDescriptor Visit(DoWhileNode node)
        {
            Visit(node.Condition);

            Visit(node.Command);

            return null;
        }
        private TypeDescriptor Visit(IfNode node)
        {
            Visit(node.Condition);

            Visit(node.IfTrue);

            if (node.IfFalse != null)
            {
                Visit(node.IfFalse);
            }

            return null;
        }
        private TypeDescriptor Visit(IndexNode node)
        {
            //var obj = Visit(node.Where as dynamic);

            //var index = Visit(node.Index);

            //var tableType = obj.Type as TableType;

            //if (!obj.IsObject || tableType == null)
            //{
            //    Log("Оператор [] может применяться только для экземпляра типа Table", node);

            //    return TypeDescriptor.Undefined;
            //}

            //var indexType = index.Type as SimpleType;

            //if (indexType == null || indexType.SType != SimpleTypeEnum.Int)
            //{
            //    Log("Индексом может быть только целое число", node);

            //    return TypeDescriptor.Undefined;
            //}

            //node.TableType = tableType;

            //return new TypeDescriptor(true, tableType.ItemsType, true);

            return TypeDescriptor.Undefined;
        }
        private TypeDescriptor Visit(MemberCallNode node)
        {
            var where = Visit(node.Where as dynamic);
            var field = where.Type.GetField(node.MemberName);

            if (field == null)
            {
                Log(String.Format("Поля {0} не существует", node.MemberName), node);

                return TypeDescriptor.Undefined;
            }

            if (!where.IsObject && where.Type.Type != Types.Type.Package)
            {
                Log(String.Format("Невозможно вызвать поле {0} не на экземпляре", node.MemberName), node);

                return TypeDescriptor.Undefined;
            }

            return new TypeDescriptor(true, field.Type, true);
        }
        private TypeDescriptor Visit(ReturnNode node)
        {
            TypeDescriptor type = Visit(node.Expression);

            if (!context.CurrentMethod.Ret.CanBeAssignedWith(type.Type))
            {
                Log(String.Format("Попытка вернуть тип {0}, возвращаемый тип метода - {1}", 
                        type.ToString(),
                        context.CurrentMethod.Ret.ToString()
                    ), 
                    node);

                return TypeDescriptor.Undefined;
            }

            return type;
        }

        private List<VarStruct> GetLocalVars(DeclareBlockNode node)
        {

            var vars = new List<VarStruct>();

            foreach(var item in node.Decls)
            {
                var varInfo = GetVar(item);

                if (vars.Exists(x => x.Name == varInfo.Name))
                {
                    Log(
                        String.Format("Невозможно создать локальную переменную с именем {0}", varInfo.Name),
                        item);
                }
                else
                {
                    vars.Add(varInfo);
                }
            }

            return vars;
        }

        private SimpleType Convert(SimpleType l, SimpleType r)
        {
            return l.SType < r.SType ? r : l;
        }
        private void InsertCastNode(CommonTree parent, int index, TypeInfo type)
        {
            CastNode newNode = new CastNode(new CommonToken(-1, "Cast"));
            newNode.Type = type;
            newNode.Parent = parent;

            var oldNode = parent.GetChild(index);

            oldNode.Parent = newNode;
            newNode.AddChild(oldNode);

            parent.DeleteChild(index);
            parent.InsertChild(index, newNode);


        }

        private bool IsNumericType(TypeInfo type)
        {
            SimpleTypeEnum[] types = new SimpleTypeEnum[]
            {
                SimpleTypeEnum.Byte,
                SimpleTypeEnum.Char,
                SimpleTypeEnum.Double,
                SimpleTypeEnum.Float,
                SimpleTypeEnum.Int,
            };

            var simpleType = type as SimpleType;

            return simpleType != null
                && types.Contains(simpleType.SType);
        }
        private bool IsBoolType(TypeInfo type)
        {
            var boolType = type as SimpleType;

            return boolType != null
                && boolType.SType == SimpleTypeEnum.Bool;
        }

    }
}
