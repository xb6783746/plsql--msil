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
using plsql_msil.Codegeneration.Builders;
using plsql_msil.Codegeneration.SpecialNodes;
using BinaryOperator = plsql_msil.AstNodes.MathNodes.BinaryOperator;

namespace plsql_msil.Codegeneration
{
    class Codegen
    {

        private TypeStorage types;
        private ModuleBuilder builder;

        public string Generate(CommonTree tree, TypeStorage types)
        {
            this.types = types;

            builder = new ModuleBuilder(types.Libs);

            var defs = tree.Children.Where(x => x is ClassDefNode || x is PackageDefNode || x is EntryPointNode);

            foreach(dynamic item in defs)
            {
                Visit(item);
            }

            return builder.Generate();
        }

        private TypeInfo lastType;
        private VarInfo lastVar;

        private void Visit(EntryPointNode node)
        {
            var varList = new List<VarInfo>();

            foreach (dynamic item in node.DeclareItems)
            {
                var varInfo = GetVar(item, VarLocation.Local);
                varList.Add(varInfo);
            }

            var entryPointBuilder = builder.BuildEntryPoint(varList);

            Visit(node.CodeBlock, entryPointBuilder);

            entryPointBuilder.ClearStack();
            entryPointBuilder.Ret();
        }
        private void Visit(ClassDefNode node)
        {
            var type = types.GetType(node.ClassName) as ClassType;

            var classBuilder = builder.BuildClass(type);

            foreach (var item in node.ClassDefs)
            {
                Visit(item, classBuilder);
            }
        }
        private void Visit(PackageDefNode node)
        {
            var packageType = types.GetType(node.PackageName) as PackageType;

            var packageBuilder = builder.BuildPackage(packageType);

            foreach(var item in node.PackageDefs)
            {
                Visit(item, packageBuilder);
            }
        }

        private void Visit(MethodDefNode node, ClassBuilder builder)
        {
            var methodInfo = builder
                .ClassType
                .GetMethod(
                    node.MethodDecl.MethodName, 
                    GetArgs(node.MethodDecl), 
                    IsStatic(node.MethodDecl.Modifier)
                );

            var methodBuilder = builder.BuildMethod(methodInfo);

            Visit(node.Commands, methodBuilder);

            if (methodInfo.Ret.Equals(TypeInfo.Void))
            {
                methodBuilder.ClearStack();

                methodBuilder.Ret();
            }

        }

        private VarInfo GetVar(VarDefNode node, VarLocation location)
        {
            string name = node.VarName;
            string typeName = node.VarType.TypeName;

            var type = types.GetType(typeName);

            return new VarInfo(name, type, location);

        }

        private TypeInfo Visit(BoolNode node, MethodBuilder builder)
        {
            builder.LoadBool(node.Value);

            return SimpleType.Bool;
        }
        private TypeInfo Visit(CharNode node, MethodBuilder builder)
        {
            builder.LoadChar(node.Value);

            return SimpleType.Char;
        }      
        private TypeInfo Visit(FloatNode node, MethodBuilder builder)
        {
            builder.LoadFloat(node.Value);

            return SimpleType.Float;
        }
        private TypeInfo Visit(IntegerNode node, MethodBuilder builder)
        {
            builder.LoadInt(node.Value);

            return SimpleType.Int;
        }
        private TypeInfo Visit(RealNode node, MethodBuilder builder)
        {
            builder.LoadDouble(node.Value);

            return SimpleType.Double;
        }
        private TypeInfo Visit(StringNode node, MethodBuilder builder)
        {
            builder.LoadString(node.Value);

            return SimpleType.String;
        }

        private void Visit(CodeBlockNode node, MethodBuilder builder)
        {
            foreach (dynamic item in node.Commands)
            {
                Visit(item, builder);

                if(!(item is ReturnNode))
                {
                    builder.ClearStack();
                }
            }
        }

        private void Visit(VarDefNode node)
        {
        }

        private TypeInfo Visit(VarNode node, MethodBuilder builder)
        {

            builder.LoadToStack(null, node.VarInfo);

            return node.TypeInfo;
        }
        private TypeInfo Visit(PackageNameNode node, MethodBuilder builder)
        {
            return node.TypeInfo;
        }
        private TypeInfo Visit(SelfNode node, MethodBuilder builder)
        {
            builder.LoadThis();

            return node.TypeInfo;
        }

        private TypeInfo Visit(CreateInstanceNode node, MethodBuilder builder)
        {

            foreach(dynamic item in node.Arguments)
            {
                Visit(item, builder);
            }

            var classType = node.TypeInfo as ClassType;

            builder.Construct(classType, node.Constructor);

            return classType;
        }
        private TypeInfo Visit(MethodCallNode node, MethodBuilder builder)
        {
            Visit(node.Where as dynamic, builder);

            foreach (dynamic item in node.Arguments)
            {
                Visit(item, builder);
            }

            var methodInfo = node.MethodInfo;

            builder.Call(methodInfo);

            return methodInfo.Ret;
        }
        private TypeInfo Visit(CallvirtNode node, MethodBuilder builder)
        {
            Visit(node.Where as dynamic, builder);

            foreach (dynamic item in node.Args)
            {
                Visit(item, builder);
            }

            var methodInfo = node.Method;

            builder.Callvirt(methodInfo);

            return methodInfo.Ret;
        }

        private TypeInfo Visit(ExpressionNode node, MethodBuilder builder)
        {
            return Visit(node.Expression as dynamic, builder);
        }

        private TypeInfo Visit(PlusNode node, MethodBuilder builder)
        {

            return BinaryOperatorVisit(node, builder, (x) => x.Plus());
        }
        private TypeInfo Visit(MinusNode node, MethodBuilder builder)
        {
            if (node.isUnary)
            {
                var res = Visit(node.LeftOperand as dynamic, builder);
                builder.Neg();

                return res;
            }
            else
            {
                return BinaryOperatorVisit(node, builder, (x) => x.Minus());
            }
        }
        private TypeInfo Visit(MultNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Mult());
        }
        private TypeInfo Visit(DivNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Div());
        }
        private TypeInfo Visit(ModNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Mod());
        }

        private TypeInfo Visit(AndNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.And());
        }
        private TypeInfo Visit(OrNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Or());
        }
        private TypeInfo Visit(GreaterNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Greater());
        }
        private TypeInfo Visit(LessNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Less());
        }
        private TypeInfo Visit(GreaterOrEqualNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.GreaterOrEqual());
        }
        private TypeInfo Visit(LessOrEqualNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.LessOrEqual());
        }
        private TypeInfo Visit(EqualNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.Equal());
        }
        private TypeInfo Visit(NotEqualNode node, MethodBuilder builder)
        {
            return BinaryOperatorVisit(node, builder, (x) => x.NEqual());
        }
        private TypeInfo Visit(NotNode node, MethodBuilder builder)
        {
            var res = Visit(node.Operand as dynamic, builder);

            builder.Not();

            return res;
        }
        private TypeInfo Visit(CastNode node, MethodBuilder builder)
        {
            var res = Visit(node.Expression as dynamic, builder);

            var convType = node.Type as SimpleType;

            builder.Convert(convType.SType);

            return res;
        }

        private TypeInfo BinaryOperatorVisit(BinaryOperator binaryOperator,
            MethodBuilder builder, Action<MethodBuilder> action)
        {
            Visit(binaryOperator.LeftOperand as dynamic, builder);
            var res = Visit(binaryOperator.RightOperand as dynamic, builder);

            action(builder);

            return res;
        }

        private void Visit(AssignNode node, MethodBuilder builder)
        {
            Visit(node.LValue as dynamic, builder);
            Visit(node.Expression, builder);

            builder.Assign(lastType, lastVar);
        }
        private void Visit(ForNode node, MethodBuilder builder)
        {
            Visit(node.Init as dynamic, builder);

            int l1 = builder.PrepareJump(false);

            int nop2 = builder.Nop();

            Visit(node.CodeBlock as dynamic, builder);

            Visit(node.Iteration as dynamic, builder);

            int nop1 = builder.Nop();
            builder.MakeJump(l1, nop1, Jump.Always);

            Visit(node.Condition as dynamic, builder);

            int l2 = builder.PrepareJump(true);
            builder.MakeJump(l2, nop2, Jump.IfTrue);
        }
        private void Visit(WhileNode node, MethodBuilder builder)
        {
            int start = builder.Nop();

            Visit(node.Condition, builder);

            int exit = builder.PrepareJump(true);

            Visit(node.Command, builder);

            builder.MakeJump(builder.Nop(), start, Jump.Always);

            int end = builder.Nop();

            builder.MakeJump(exit, end, Jump.IfFalse);
        }
        private void Visit(DoWhileNode node, MethodBuilder builder)
        {
            int nop = builder.Nop();

            Visit(node.Command, builder);
            Visit(node.Condition, builder);

            int jmp = builder.PrepareJump(true);
            builder.MakeJump(jmp, nop, Jump.IfFalse);
        }
        private void Visit(IfNode node, MethodBuilder builder)
        {
            Visit(node.Condition, builder);

            int label1 = builder.PrepareJump(true);

            Visit(node.IfTrue, builder);

            if (node.IfFalse != null)
            {
                int label2 = builder.PrepareJump(false);
                int elseLabel = builder.Nop();

                builder.MakeJump(label1, elseLabel, Jump.IfFalse);

                Visit(node.IfFalse, builder);

                int label3 = builder.Nop();

                builder.MakeJump(label2, label3, Jump.Always);
            }
            else
            {
                int label2 = builder.Nop();
                builder.MakeJump(label1, label2, Jump.IfFalse);
            }
        }

        private TypeInfo Visit(IndexNode node, MethodBuilder builder)
        {

            var genericFirst = new GenericType();
            var genericSecond = new GenericType(1);

            var methodInfo = new MethodInfo("get_Item", genericSecond, false, node.TableType);
            methodInfo.AddArg("a", genericFirst);

            Visit(node.Where as dynamic, builder);
            Visit(node.Index, builder);

            builder.Callvirt(methodInfo);

            return node.TableType.ItemsType;
        }
        private TypeInfo Visit(MemberCallNode node, MethodBuilder builder)
        {
            var whereType = Visit(node.Where as dynamic, builder);

            VarInfo varInfo = types.GetType(whereType.Name).GetField(node.MemberName);

            lastType = whereType;
            lastVar = varInfo;

            builder.LoadToStack(whereType, varInfo);

            return varInfo.Type;
        }

        private TypeInfo Visit(AssignIndexNode node, MethodBuilder builder)
        {

            throw new NotImplementedException();
        }
        private TypeInfo Visit(AssignMemberCallNode node, MethodBuilder builder)
        {
            var whereType = Visit(node.MemberCallNode.Where as dynamic, builder);

            VarInfo varInfo = types.GetType(whereType.Name).GetField(node.MemberCallNode.MemberName);

            lastType = whereType;
            lastVar = varInfo;

            return varInfo.Type;
        }
        private TypeInfo Visit(AssignVarNode node, MethodBuilder builder)
        {
            lastVar = node.VarInfo;

            return node.VarInfo.Type;
        }

        private TypeInfo Visit(ReturnNode node, MethodBuilder builder)
        {
            builder.ClearStack();

            var res = Visit(node.Expression, builder);

            builder.Ret();

            return res;
        }


        private List<TypeInfo> GetArgs(MethodDeclNode node)
        {

            var res = new List<TypeInfo>();

            foreach (var item in node.Vars)
            {
                var type = types.GetType(item.VarType.TypeName);

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
