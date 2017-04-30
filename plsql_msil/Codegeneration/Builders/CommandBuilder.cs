using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Codegeneration.Builders
{
    class CommandBuilder
    {
        public CommandBuilder(INameConvertor nameConvertor)
        {
            commandNames = CommandNames.Instance;
            this.nameConvertor = nameConvertor;
        }

        protected int counter;
        protected int currentStack;
        protected int maxStack;
        protected CommandNames commandNames;

        protected INameConvertor nameConvertor;
        protected List<Command> commands = new List<Command>();

        public int Stack { get { return currentStack; } }

        public void LoadToStack(VarInfo field)
        {

            Code code = Code.Nop;
            string val = "";
            int pushCount = 1;

            if (field is MethodVarInfo)
            {
                var methodVar = field as MethodVarInfo;

                code = methodVar.VarType == MethodVarType.Local ? Code.LoadLocal : Code.LoadArg;
                val = methodVar.Name;
            }
            else if(field is GlobalVarInfo)
            {
                var globalVar = field as GlobalVarInfo;

                bool isPackage = globalVar.Where.Type == Types.Type.Package;
                code = isPackage ? Code.LoadStaticGlobal : Code.LoadGlobal;
                if (!isPackage)
                {
                    pushCount = 0;
                }

                val = GetMemberCallString(globalVar.Where, field);
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

            AddCommand(Code.LDouble, val.ToString(CultureInfo.InvariantCulture));
        }
        public void LoadFloat(float val)
        {
            Push();

            AddCommand(Code.LFloat, val.ToString(CultureInfo.InvariantCulture));
        }
        public void LoadString(string val)
        {
            Push();

            AddCommand(Code.LString, string.Format("\"{0}\"", val));
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

        public virtual void Assign(VarInfo field)
        {
            Code code = Code.Nop;
            string arg = "";

            int popCount = 1;

            if (field is MethodVarInfo)
            {
                var methodVar = field as MethodVarInfo;

                code = methodVar.VarType == MethodVarType.Local ? Code.LoadFromStackLocal : Code.LoadFromStackArg;
                arg = methodVar.Name;
            }
            else if (field is GlobalVarInfo)
            {
                var globalVar = field as GlobalVarInfo;

                bool isPackage = globalVar.Where.Type == Types.Type.Package;
                code = isPackage ? Code.LoadFromStackStaticGlobal : Code.LoadFromStackGlobal;
                if (!isPackage)
                {
                    popCount++;
                }
                arg = GetMemberAssignString(globalVar.Where, field);
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

        public void Convert(SimpleTypeEnum stype)
        {
            Code c = Code.CastInt;
            switch (stype)
            {
                case SimpleTypeEnum.Bool:
                    c = Code.CastByte;
                    break;
                case SimpleTypeEnum.Byte:
                    c = Code.CastByte;
                    break;
                case SimpleTypeEnum.Char:
                    c = Code.CastChar;
                    break;
                case SimpleTypeEnum.Int:
                    c = Code.CastInt;
                    break;
                case SimpleTypeEnum.Float:
                    c = Code.CastFloat;
                    break;
                case SimpleTypeEnum.Double:
                    c = Code.CastDouble;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("stype", stype, null);
            }

            AddCommand(c, "");
        }

        public int Nop()
        {
            int tmp = counter;

            AddCommand(Code.Nop, "");

            return tmp;
        }

        public int PrepareJump(bool pop)
        {
            if (pop)
            {
                Pop();
            }
         
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
            string ret;

            if (method.Ret is GenericType)
            {
                var genericType = method.Ret as GenericType;
                ret = "!" + genericType.Number;

            }
            else
            {
                
            }

            return String.Format(
                "{0} {1}::{2}({3})",
                GetMSILTypeName(method.Ret),
                GetMSILTypeName(method.Where),
                method.Name,
                GetTypeList(method));
        }
        protected string GetTypeList(List<TypeInfo> types)
        {
            StringBuilder builder = new StringBuilder(" ");

            foreach (var item in types)
            {
                builder.AppendFormat(" {0},", GetMSILTypeName(item));
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }
        protected string GetTypeList(MethodInfo method)
        {
            StringBuilder builder = new StringBuilder(" ");

            foreach (var item in method.Arguments)
            {
                builder.AppendFormat(" {0},", GetMSILTypeName(item.Type));
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }
        protected string GetMemberCallString(TypeInfo where, VarInfo member)
        {
            return String.Format("{0} {1}::{2}", GetMSILTypeName(member.Type), GetMSILTypeName(where), member.Name);
        }
        protected string GetMemberAssignString(TypeInfo where, VarInfo member)
        {
            return String.Format("{0} {1}::{2}", GetMSILTypeName(member.Type), GetMSILTypeName(where), member.Name);
        }

        protected string GetMSILTypeName(TypeInfo type)
        {
           // return NameConvertor.Convert(type);

            //if (type.Type == Types.Type.Class || type.Type == Types.Type.Record)
            //{
            //    return NameConvertor.Convert(type);
            //}
            if (type.IsGenericImplementation)
            {
                return "!" + type.GenericPosition;
            }

            return nameConvertor.Convert(type);
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
