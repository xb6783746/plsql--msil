using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration
{
    public enum Code
    {
        LInt,
        LDouble,
        LFloat,
        LChar,
        LNull,
        LString,
        This,

        LoadFromStackLocal,
        LoadFromStackStaticGlobal,
        LoadFromStackGlobal,
        LoadFromStackArg,

        LoadArg,
        LoadLocal,
        LoadStaticGlobal,
        LoadGlobal,
        LoadAddressLocal,
        LoadAddressStaticGlobal,
        LoadAddressGlobal,
        LoadAddressArg,

        DereferenceInt,
        DereferenceChar,
        DereferenceDouble,
        DereferencePointer,

        AssignByAddressInt,
        AssignByAddressChar,
        AssignByAddressDouble,
        AssignByAddressNativeInt,

        Newobj,

        ConvertToNativeInt,

        Brtrue,
        Brfalse,
        Br,

        Plus,
        Minus,
        Mult,
        Div,
        Mod,
        Neg,

        Greater,
        Less,
        Equal,
        And,
        Or,

        Call,
        Callvirt,
        Ret,
        Pop,

        CastInt,
        CastChar,
        CastDouble,

        IndexVal,
        IndexRef,

        SetByIndexInt,
        SetByIndexChar,
        SetByIndexDouble,
        SetByIndexNativeInt,

        ArrayInit,

        Dup,

        SizeOf,

        Nop
    }

    class CommandNames
    {
        private static Dictionary<Code, string> codes = new Dictionary<Code, string>()
            {
                {Code.LInt, "ldc.i4"},
                {Code.LDouble, "ldc.r8"},
                {Code.LFloat, "ldc.r4"},
                {Code.LChar, "ldc.i4"},
                {Code.LNull, "ldnull"},
                {Code.LString, "ldstr"},
                {Code.This, "ldarg.0"},
                
                {Code.LoadFromStackLocal, "stloc"},
                {Code.LoadFromStackArg, "starg.s"},
                {Code.LoadFromStackGlobal, "stfld"},
                {Code.LoadFromStackStaticGlobal, "stsfld"},

                {Code.LoadStaticGlobal, "ldsfld"},
                {Code.LoadGlobal, "ldfld"},
                {Code.LoadArg, "ldarg"},
                {Code.LoadLocal, "ldloc"},
                {Code.LoadAddressGlobal, "ldflda"},
                {Code.LoadAddressLocal, "ldloca.s"},
                {Code.LoadAddressStaticGlobal, "ldsflda"},
                {Code.LoadAddressArg, "ldarga.s"},

                {Code.DereferenceInt, "ldind.i4"},
                {Code.DereferenceChar, "ldind.u2"},
                {Code.DereferenceDouble, "ldind.r8"},
                {Code.DereferencePointer, "ldind.i"},

                {Code.AssignByAddressInt, "stind.i4"},
                {Code.AssignByAddressChar, "stind.I2"},
                {Code.AssignByAddressDouble, "stind.r8"},
                {Code.AssignByAddressNativeInt, "stind.i"},

                {Code.Newobj, "newobj"},

                {Code.ConvertToNativeInt, "conv.u"},

                {Code.Br, "br"},
                {Code.Brtrue, "brtrue"},
                {Code.Brfalse, "brfalse"},

                {Code.Plus, "add"},
                {Code.Minus, "sub"},
                {Code.Mult, "mul"},
                {Code.Div, "div"},
                {Code.Mod, "rem"},
                {Code.Neg, "neg"},

                {Code.Greater, "cgt"},
                {Code.Less, "clt"},
                {Code.Equal, "ceq"},
                {Code.And, "and"},
                {Code.Or, "or"},

                {Code.Call, "call"},
                {Code.Callvirt, "callvirt"},
                {Code.Ret, "ret"},
                {Code.Pop, "pop"},

                {Code.CastInt, "conv.i4"},
                {Code.CastChar, "conv.i2"},
                {Code.CastDouble, "conv.r8"},

                {Code.IndexVal, "ldelem"},
                {Code.IndexRef, "ldelema"},

                {Code.SetByIndexChar, "stelem.i2"},
                {Code.SetByIndexInt, "stelem.i4"},
                {Code.SetByIndexDouble, "stelem.r8"},
                {Code.SetByIndexNativeInt, "stelem.i"},

                {Code.ArrayInit, "newarr"},

                {Code.Dup, "dup"},

                {Code.SizeOf, "sizeof"},

                {Code.Nop, "nop"},
            };


        private static CommandNames instance;

        public string GetCode(Code code)
        {
            return codes[code];
        }
        public static CommandNames Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommandNames();
                }

                return instance;
            }
        }
    }
}
