namespace plsql_msil.Types.VarTypes
{

    class VarInfo
    {
        public VarInfo(string name, TypeInfo type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; protected set; }
        public TypeInfo Type { get; protected set; }

    }
}
