﻿namespace plsql_msil.Types.VarTypes
{
    public class GlobalVarInfo :VarInfo
    {
        public GlobalVarInfo(string name, TypeInfo type, TypeInfo where)
            :base(name, type)
        {
            Where = where;
        }

        public TypeInfo Where { get; private set; }

    }
}
