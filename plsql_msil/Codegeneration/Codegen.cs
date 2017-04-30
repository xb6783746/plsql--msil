using Antlr.Runtime.Tree;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.ClassNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.Semantic;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Codegeneration.Builders;
using plsql_msil.Codegeneration.SpecialNodes;
using plsql_msil.Types.VarTypes;
using BinaryOperator = plsql_msil.AstNodes.MathNodes.BinaryOperator;

namespace plsql_msil.Codegeneration
{
    class Codegen
    {
        class CodegenContext
        {
            public ClassType CurrentClass { get; set; }
            public VarInfo LastVar { get; set; }

        }

        private TypeStorage types;
        private ModuleBuilder builder;
        private MethodInfo entryPoint;

        private TypesBuilder typeBuilder;

        public string Generate(CommonTree tree, TypeStorage types, INameConvertor nameConvertor)
        {
            this.types = types;
            typeBuilder = new TypesBuilder(types);

            builder = new ModuleBuilder(types.Libs, nameConvertor);

            var defs = tree.Children.Where(x => x is ClassDefNode || x is EntryPointNode);

            var context = new CodegenContext();

            foreach(dynamic item in defs)
            {
                Visit(item, context);
            }

            return builder.Generate();
        }

        private void Visit(EntryPointNode node, CodegenContext context)
        {
            var varList = new List<VarInfo>();

            foreach (dynamic item in node.DeclareItems)
            {
                var varInfo = GetVar(item);
                varList.Add(varInfo);
            }

            var entryPointBuilder = builder.BuildEntryPoint(varList);
            Visit(node.CodeBlock, entryPointBuilder, context);

            entryPointBuilder.ClearStack();
            entryPointBuilder.Ret();
        }
        private void Visit(ClassDefNode node, CodegenContext context)
        {
            var type = types.GetType(node.Name) as ClassType;

            context.CurrentClass = type;

            var classBuilder = builder.BuildClass(type);

            foreach (var item in node.Defs)
            {
                Visit(item, classBuilder, context);
            }
        }
        private void Visit(PackageDefNode node, CodegenContext context)
        {
            var packageType = types.GetType(node.Name) as PackageType;

            var packageBuilder = builder.BuildPackage(packageType);

            foreach(var item in node.Defs)
            {
                Visit(item, packageBuilder, context);
            }
        }

        private void Visit(MethodDefNode node, ClassBuilder builder, CodegenContext context)
        {
            var methodInfo = builder
                .ClassType
                .GetMethod(
                    node.MethodDecl.MethodName, 
                    GetArgs(node.MethodDecl), 
                    IsStatic(node.MethodDecl.Modifier)
                );

            var methodBuilder = builder.BuildMethod(methodInfo);

            Visit(node.Commands, methodBuilder, context);

            if (methodInfo.Ret.Equals(TypeInfo.Void))
            {
                methodBuilder.ClearStack();

                methodBuilder.Ret();
            }

        }

        private VarInfo GetVar(VarDefNode node)
        {
            string name = node.VarName;

            var type = typeBuilder.Build(node.VarType);

            return new MethodVarInfo(name, type, MethodVarType.Local);

        }       


        private TypeInfo Visit(BoolNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.LoadBool(node.Value);

            return SimpleType.Bool;
        }
        private TypeInfo Visit(CharNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.LoadChar(node.Value);

            return SimpleType.Char;
        }      
        private TypeInfo Visit(FloatNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.LoadFloat(node.Value);

            return SimpleType.Float;
        }
        private TypeInfo Visit(IntegerNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.LoadInt(node.Value);

            return SimpleType.Int;
        }
        private TypeInfo Visit(RealNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.LoadDouble(node.Value);

            return SimpleType.Double;
        }
        private TypeInfo Visit(StringNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.LoadString(node.Value);

            return SimpleType.String;
        }

        private void Visit(CodeBlockNode node, MethodBuilder builder, CodegenContext context)
        {
            foreach (dynamic item in node.Commands)
            {
                Visit(item, builder, context);

                if(!(item is ReturnNode))
                {
                    builder.ClearStack();
                }
            }
        }

        private void Visit(VarDefNode node)
        {
        }

        private TypeInfo Visit(VarNode node, MethodBuilder builder, CodegenContext context)
        {
            context.LastVar = builder.MethodInfo.GetVar(node.VarName);

            if (context.LastVar == null)
            {
                context.LastVar = context.CurrentClass.GetField(node.VarName);
            }

            builder.LoadToStack(context.LastVar);

            return context.LastVar.Type;
        }
        private TypeInfo Visit(PackageNameNode node, MethodBuilder builder, CodegenContext context)
        {
            return types.GetType(node.PackageName);
        }
        private TypeInfo Visit(SelfNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.LoadThis();

            return context.CurrentClass;
        }

        private TypeInfo Visit(CreateInstanceNode node, MethodBuilder builder, CodegenContext context)
        {

            var typeList = new List<TypeInfo>();

            foreach(dynamic item in node.Arguments)
            {
                var type = Visit(item, builder, context);

                typeList.Add(type);
            }

            var classType = types.GetType(node.TypeName);

            builder.Construct(classType, typeList);

            return classType;
        }
        private TypeInfo Visit(CreateTableNode node, MethodBuilder builder, CodegenContext context)
        {
            TypeInfo type = null;

            if (node.IsTable)
            {
                type = typeBuilder.GenerateTableType(node.TypeNode);
            }
            else
            {
                type = typeBuilder.GenerateDictionaryType(node.TypeNode, node.ValueTypeNode);
            }

            builder.DefaultConstructor(type);

            return type;
        }
        private TypeInfo Visit(CreateArrayNode node, MethodBuilder builder, CodegenContext context)
        {
            //node.TableType = context.GetType(node.TypeName);

            Visit(node.Length, builder, context);

            //var itemsType = Visit(node.TypeNode as dynamic);
            var arrType = typeBuilder.GenerateArrayType(node.TypeNode);

            builder.Construct(arrType, new List<TypeInfo>() { TypeInfo.Int });

            return arrType;
        }
        private TypeInfo Visit(MethodCallNode node, MethodBuilder builder, CodegenContext context)
        {
            ClassType type = Visit(node.Where as dynamic, builder, context) as ClassType;

            var argList = new List<TypeInfo>();

            foreach (dynamic item in node.Arguments)
            {
                var arg = Visit(item, builder, context);

                argList.Add(arg);
            }

            //TODO ПЛОХО
            var methodInfo = type.GetMethod(node.MethodName, argList, type is PackageType);

            builder.Call(methodInfo);

            return methodInfo.Ret;
        }
        private TypeInfo Visit(CallvirtNode node, MethodBuilder builder, CodegenContext context)
        {
            Visit(node.Where as dynamic, builder, context);

            foreach (dynamic item in node.Args)
            {
                Visit(item, builder, context);
            }

            var methodInfo = node.Method;

            builder.Callvirt(methodInfo);

            return methodInfo.Ret;
        }

        private TypeInfo Visit(ExpressionNode node, MethodBuilder builder, CodegenContext context)
        {
            return Visit(node.Expression as dynamic, builder, context);
        }

        private TypeInfo Visit(PlusNode node, MethodBuilder builder, CodegenContext context)
        {

            return BinaryOperatorVisit(node, builder, (x) => x.Plus(), context);
        }
        private TypeInfo Visit(MinusNode node, MethodBuilder builder, CodegenContext context)
        {
            if (node.isUnary)
            {
                var res = Visit(node.LeftOperand as dynamic, builder, context);
                builder.Neg();

                return res;
            }
            else
            {
                return BinaryOperatorVisit(node, builder, (x) => x.Minus(), context);
            }
        }
        private TypeInfo Visit(MultNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Mult(), context);
        }
        private TypeInfo Visit(DivNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Div(), context);
        }
        private TypeInfo Visit(ModNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Mod(), context);
        }

        private TypeInfo Visit(AndNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.And(), context);
        }
        private TypeInfo Visit(OrNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Or(), context);
        }
        private TypeInfo Visit(GreaterNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Greater(), context);
        }
        private TypeInfo Visit(LessNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Less(), context);
        }
        private TypeInfo Visit(GreaterOrEqualNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.GreaterOrEqual(), context);
        }
        private TypeInfo Visit(LessOrEqualNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.LessOrEqual(), context);
        }
        private TypeInfo Visit(EqualNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Equal(), context);
        }
        private TypeInfo Visit(NotEqualNode node, MethodBuilder builder, CodegenContext context)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.NEqual(), context);
        }
        private TypeInfo Visit(NotNode node, MethodBuilder builder, CodegenContext context)
        {
            var res = Visit(node.Operand as dynamic, builder, context);

            builder.Not();

            return res;
        }
        private TypeInfo Visit(CastNode node, MethodBuilder builder, CodegenContext context)
        {
            var res = Visit(node.Expression as dynamic, builder, context);

            var convType = node.Type as SimpleType;

            builder.Convert(convType.SType);

            return convType;
        }

        private TypeInfo BinaryOperatorVisit(BinaryOperator binaryOperator,
            MethodBuilder builder, Action<MethodBuilder> action, CodegenContext context)
        {
            Visit(binaryOperator.LeftOperand as dynamic, builder, context);
            var res = Visit(binaryOperator.RightOperand as dynamic, builder, context);

            action(builder);

            return res;
        }

        private void Visit(AssignNode node, MethodBuilder builder, CodegenContext context)
        {
            Visit(node.LValue as dynamic, builder, context);

            var varInfo = context.LastVar;

            Visit(node.Expression, builder, context);

            builder.Assign(varInfo);
        }
        private void Visit(ForNode node, MethodBuilder builder, CodegenContext context)
        {
            Visit(node.Init as dynamic, builder, context);

            int l1 = builder.PrepareJump(false);

            int nop2 = builder.Nop();

            Visit(node.CodeBlock as dynamic, builder, context);

            Visit(node.Iteration as dynamic, builder, context);

            int nop1 = builder.Nop();
            builder.MakeJump(l1, nop1, Jump.Always);

            Visit(node.Condition as dynamic, builder, context);

            int l2 = builder.PrepareJump(true);
            builder.MakeJump(l2, nop2, Jump.IfTrue);
        }
        private void Visit(WhileNode node, MethodBuilder builder, CodegenContext context)
        {
            int start = builder.Nop();

            Visit(node.Condition, builder, context);

            int exit = builder.PrepareJump(true);

            Visit(node.Command, builder, context);

            builder.MakeJump(builder.Nop(), start, Jump.Always);

            int end = builder.Nop();

            builder.MakeJump(exit, end, Jump.IfFalse);
        }
        private void Visit(DoWhileNode node, MethodBuilder builder, CodegenContext context)
        {
            int nop = builder.Nop();

            Visit(node.Command, builder, context);
            Visit(node.Condition, builder, context);

            int jmp = builder.PrepareJump(true);
            builder.MakeJump(jmp, nop, Jump.IfFalse);
        }
        private void Visit(IfNode node, MethodBuilder builder, CodegenContext context)
        {
            Visit(node.Condition, builder, context);

            int label1 = builder.PrepareJump(true);

            Visit(node.IfTrue, builder, context);

            if (node.IfFalse != null)
            {
                int label2 = builder.PrepareJump(false);
                int elseLabel = builder.Nop();

                builder.MakeJump(label1, elseLabel, Jump.IfFalse);

                Visit(node.IfFalse, builder, context);

                int label3 = builder.Nop();

                builder.MakeJump(label2, label3, Jump.Always);
            }
            else
            {
                int label2 = builder.Nop();
                builder.MakeJump(label1, label2, Jump.IfFalse);
            }
        }

        private TypeInfo Visit(IndexNode node, MethodBuilder builder, CodegenContext context)
        {

            //var genericFirst = new GenericType();
            //var genericSecond = new GenericType(1);

            //var methodInfo = new MethodInfo("get_Item", genericSecond, false, node.TableType);
            //methodInfo.AddArg("a", genericFirst);

            //Visit(node.Where as dynamic, builder, context);
            //Visit(node.Index, builder, context);

            //builder.Callvirt(methodInfo);

            //return node.TableType.ItemsType;

            return null;
        }
        private TypeInfo Visit(MemberCallNode node, MethodBuilder builder, CodegenContext context)
        {
            var whereType = Visit(node.Where as dynamic, builder, context);

            context.LastVar = types.GetType(whereType.Name).GetField(node.MemberName);

            //lastType = whereType;
            //lastVar = varInfo;
            // TODO Я НЕ ПОМНЮ, ЗАЧЕМ ЭТО

            builder.LoadToStack(context.LastVar);

            return context.LastVar.Type;
        }

        private TypeInfo Visit(AssignMemberCallNode node, MethodBuilder builder, CodegenContext context)
        {
            var whereType = Visit(node.MemberCallNode.Where as dynamic, builder, context);

            VarInfo varInfo = types.GetType(whereType.Name).GetField(node.MemberCallNode.MemberName);

            context.LastVar = varInfo;

            return varInfo.Type;
        }
        private TypeInfo Visit(AssignVarNode node, MethodBuilder builder, CodegenContext context)
        {
            context.LastVar = builder.MethodInfo.GetVar(node.VarName);

            if (context.LastVar == null)
            {
                context.LastVar = context.CurrentClass.GetField(node.VarName);
            }

            return context.LastVar.Type;
        }

        private TypeInfo Visit(ReturnNode node, MethodBuilder builder, CodegenContext context)
        {
            builder.ClearStack();

            var res = Visit(node.Expression, builder, context);

            builder.Ret();

            return res;
        }


        private List<TypeInfo> GetArgs(MethodDeclNode node)
        {

            var res = new List<TypeInfo>();

            foreach (var item in node.Vars)
            {
                var type = typeBuilder.Build(item.VarType);

                res.Add(type);
            }

            return res;

        }


        private bool IsStatic(string str)
        {
            return str.Trim().ToLower() == "static";
        }
     
    }
}
