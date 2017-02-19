using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration.Builders
{
    class CommandBuilder
    {
        public CommandBuilder()
        {
            commandNames = CommandNames.Instance;
        }

        protected int counter;
        protected int currentStack;
        protected int maxStack;
        protected CommandNames commandNames;

        protected List<Command> commands = new List<Command>();

        public int Stack { get { return currentStack; } }

        public void LoadToStack(TypeInfo where, VarInfo field)
        {

            Code code = Code.Nop;
            string val = "";
            int pushCount = 1;

            switch (field.Location)
            {
                case VarLocation.Local:
                    code = Code.LoadLocal;
                    val = field.Name;
                    break;
                case VarLocation.Argument:
                    code = Code.LoadArg;
                    val = field.Name;
                    break;
                case VarLocation.Global:
                    bool isPackage = where.Type == Types.Type.Package;
                    code = isPackage ? Code.LoadStaticGlobal : Code.LoadGlobal;
                    if(!isPackage)
                    {
                        pushCount = 0;
                    }
                    val = GetMemberCallString(where, field);
                    break;
            }

            Push(pushCount);

            AddCommand(code, val);
        }

        public void LoadInt(int val)
        {
            Push();

            AddCommand(Code.LInt, val.ToString());
        }
        public void LoadChar(char val)
        {
            LoadInt((int)val);
        }
        public void LoadDouble(double val)
        {
            Push();

            AddCommand(Code.LDouble, val.ToString());
        }
        public void LoadFloat(float val)
        {
            Push();

            AddCommand(Code.LFloat, val.ToString());
        }
        public void LoadString(string val)
        {
            Push();

            AddCommand(Code.LString, String.Format("\"{0}\"", val));
        }
        public void LoadBool(bool val)
        {
            LoadInt(val ? 1 : 0);
        }
        public void LoadNull(bool val)
        {
            Push();

            AddCommand(Code.LNull, "");
        }
        public void LoadThis()
        {
            Push();

            AddCommand(Code.This, "");
        }


        public void Call(MethodInfo method)
        {
            Call(method, Code.Call);
        }
        public void Callvirt(MethodInfo method)
        {
            Call(method, Code.Callvirt);
        }

        private void Call(MethodInfo method, Code code)
        {
            string val = String.Format(
                "{0} {1}",
                method.Where.Type == Types.Type.Package ? "" : "instance",
                GetMethodSignature(method)
                );

            if (!method.Ret.Equals(TypeInfo.Void))
            {
                Push();
            }

            if(!method.IsStatic)
            {
                Pop();
            }

            Pop(method.Arguments.Count);

            AddCommand(code, val);
        }

        public void Construct(TypeInfo type, List<TypeInfo> args)
        {
            string val = String.Format(
                "instance void {0}::.ctor({1})",
                GetMSILTypeName(type),
                GetTypeList(args)
                );

            Pop(args.Count);

            Push();

            AddCommand(Code.Newobj, val);
        }

        public void DefaultConstructor(TypeInfo where)
        {
            string val = String.Format(
                "instance void {0}::.ctor()",
                GetMSILTypeName(where)
                );

            Push();

            AddCommand(Code.Newobj, val);
        }

        public virtual void Assign(TypeInfo where, VarInfo field)
        {
            Code code = Code.Nop;
            string arg = "";

            int popCount = 1;
            switch (field.Location)
            {
                case VarLocation.Local:
                    code = Code.LoadFromStackLocal;
                    arg = field.Name;
                    break;
                case VarLocation.Argument:
                    code = Code.LoadFromStackArg;
                    arg = field.Name;
                    break;
                case VarLocation.Global:
                    bool isPackage = where.Type == Types.Type.Package;
                    code = isPackage ? Code.LoadFromStackStaticGlobal : Code.LoadFromStackGlobal;
                    if(!isPackage)
                    {
                        popCount++;
                    }
                    arg = GetMemberAssignString(where, field);
                    break;
            }

            Pop(popCount);

            AddCommand(code, arg);

        }

        public void Plus()
        {
            Pop();

            AddCommand(Code.Plus, "");
        }
        public void Minus()
        {
            Pop();

            AddCommand(Code.Minus, "");
        }
        public void Mult()
        {
            Pop();

            AddCommand(Code.Mult, "");
        }
        public void Div()
        {
            Pop();

            AddCommand(Code.Div, "");
        }
        public void Mod()
        {
            Pop();

            AddCommand(Code.Mod, "");
        }
        public void Neg()
        {
            AddCommand(Code.Neg, "");
        }

        public void Greater()
        {
            Pop();

            AddCommand(Code.Greater, "");
        }
        public void Less()
        {
            Pop();

            AddCommand(Code.Less, "");
        }
        public void Equal()
        {
            Pop();

            AddCommand(Code.Equal, "");
        }
        public void NEqual()
        {
            Pop();

            AddCommand(Code.Equal, "");
            LoadInt(0);
            AddCommand(Code.Equal, "");
        }
        public void LessOrEqual()
        {
            Pop();

            AddCommand(Code.Greater, "");
            LoadInt(0);
            AddCommand(Code.Equal, "");
        }
        public void GreaterOrEqual()
        {
            Pop();

            AddCommand(Code.Less, "");
            LoadInt(0);
            AddCommand(Code.Equal, "");
        }
        public void And()
        {
            Pop();

            AddCommand(Code.And, "");
        }
        public void Or()
        {
            Pop();

            AddCommand(Code.Or, "");
        }
        public void Not()
        {
            LoadInt(0);
            Equal();
        }

        public int Nop()
        {
            int tmp = counter;

            AddCommand(Code.Nop, "");

            return tmp;
        }

        public int PrepareJump()
        {
            Pop();

            return Nop();
        }

        public void MakeJump(int from, Jump jump)
        {
            MakeJump(from, Nop(), jump);
        }
        public void MakeJump(int from, int to, Jump jump)
        {
            Code code = Code.Nop;

            switch (jump)
            {
                case Jump.IfTrue:
                    code = Code.Brtrue;
                    break;
                case Jump.IfFalse:
                    code = Code.Brfalse;
                    break;
                case Jump.Always:
                    code = Code.Br;
                    break;

            }

            Replace(from, code, Format(to));
        }

        public void Ret()
        {
            AddCommand(Code.Ret, "");
        }

        public void PopFromStack()
        {
            Pop();

            AddCommand(Code.Pop, "");
        }
        public void PopFromStack(int count)
        {
            for (int i = 0; i < count; i++)
            {
                PopFromStack();
            }
        }

        public void ClearStack()
        {
            PopFromStack(currentStack);

        }

        private void Push()
        {
            Push(1);
        }
        private void Push(int i)
        {
            currentStack += i;

            maxStack = Math.Max(currentStack, maxStack);
        }
        private void Pop(int i)
        {
            currentStack -= i;
        }
        private void Pop()
        {
            currentStack--;
        }

        protected void AddCommand(Code code, string value)
        {
            commands.Add(new Command(counter, value, code));

            counter++;
        }

        protected void Replace(int num, Code code, string value)
        {

            commands[num] = new Command(num, value, code);

        }

        protected string Format(int num)
        {
            return String.Format("IL_{0}", num.ToString("X4"));
        }

        protected string GetMethodSignature(MethodInfo method)
        {
            return String.Format(
                "{0} {1}::{2}({3})",
                GetMSILTypeNameWithClass(method.Ret),
                GetMSILTypeName(method.Where),
                method.Name,
                GetTypeList(method.Arguments.Select(x => x.Type).ToList()));
        }
        protected string GetTypeList(List<TypeInfo> types)
        {
            StringBuilder builder = new StringBuilder(" ");

            foreach (var item in types)
            {
                builder.AppendFormat(" {0},", GetMSILTypeNameWithClass(item));
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }
        protected string GetMemberCallString(TypeInfo where, VarInfo member)
        {
            return String.Format("{0} {1}::{2}", GetMSILTypeNameWithClass(member.Type), GetMSILTypeName(where), member.Name);
        }
        protected string GetMemberAssignString(TypeInfo where, VarInfo member)
        {
            return String.Format("{0} {1}::{2}", GetMSILTypeNameWithClass(member.Type), GetMSILTypeName(where), member.Name);
        }

        protected string GetMSILTypeNameWithClass(TypeInfo type)
        {

            if (type.Type == Types.Type.Class || type.Type == Types.Type.Record)
            {
                return "class " + GetMSILTypeName(type);
            }

            return GetMSILTypeName(type);
        }
        protected string GetMSILTypeName(TypeInfo type)
        {
            return NameConvertor.Convert(type);
        }

        protected string GetCode()
        {
            var builder = new StringBuilder();

            foreach (var item in commands)
            {
                builder.AppendFormat(
                    "\t{0}: {1} {2}{3}",
                    Format(item.Number),
                    commandNames.GetCode(item.Code),
                    item.Value,
                    Environment.NewLine);
            }

            return builder.ToString();
        }
    }
}
