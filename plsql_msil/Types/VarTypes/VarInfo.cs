namespace plsql_msil.Types.VarTypes
{
    //enum VarLocation
    //{
    //    Local, Global, Argument
    //}

    class VarInfo
    {
        public VarInfo(string name, TypeInfo type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; private set; }
        public TypeInfo Type { get; private set; }

    }
}
