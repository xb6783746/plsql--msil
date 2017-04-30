namespace plsql_msil.Types.VarTypes
{

    enum MethodVarType
    {
        Local, Argument
    }

    class MethodVarInfo :VarInfo
    {
        public MethodVarInfo(string name, TypeInfo type, MethodVarType varType)
            :base(name, type)
        {
            VarType = varType;
        }

        public MethodVarType VarType { get; private set; }

        public override bool Equals(object obj)
        {
            var varInfo = obj as MethodVarInfo;

            return varInfo != null 
                && Type.Equals(varInfo.Type)
                && Name == varInfo.Name;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Type != null ? Type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) VarType;
                return hashCode;
            }
        }
    }
}
