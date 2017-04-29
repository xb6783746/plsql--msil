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
            Name = name;
            Type = type;
            VarType = varType;
        }

        public string Name { get; private set; }
        public TypeInfo Type { get; private set; }
        //public MethodInfo Where { get; private set; }
        public MethodVarType VarType { get; private set; }

        public override bool Equals(object obj)
        {
            var varInfo = obj as MethodVarInfo;

            return varInfo != null 
                && Type.Equals(varInfo.Type)
                && Name == varInfo.Name;
        }


    }
}
