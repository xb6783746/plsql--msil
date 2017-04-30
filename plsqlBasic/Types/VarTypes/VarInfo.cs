namespace plsql_msil.Types.VarTypes
{
    public class VarInfo
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
