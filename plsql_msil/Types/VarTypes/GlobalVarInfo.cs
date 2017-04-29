namespace plsql_msil.Types.VarTypes
{
    //enum VarLocation
    //{
    //    Local, Global, Argument
    //}

    class GlobalVarInfo :VarInfo
    {
        public GlobalVarInfo(string name, TypeInfo type, TypeInfo where)
            :base(name, type)
        {
            Name = name;
            Type = type;
            Where = where;
        }

        public string Name { get; private set; }
        public TypeInfo Type { get; private set; }
        public TypeInfo Where { get; private set; }

    }
}
