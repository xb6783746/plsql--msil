namespace plsql_msil.Types.VarTypes
{
    class GenericParameterInfo : MethodVarInfo
    {
        public GenericParameterInfo(string name, TypeInfo type, int genericPosition)
            :base(name, type, MethodVarType.Argument)
        {
            Name = name;
            Type = type;
            GenericPosition = genericPosition;
        }

        public string Name { get; private set; }
        public TypeInfo Type { get; private set; }
        //public MethodInfo Where { get; private set; }
        public int GenericPosition { get; private set; }

        public override bool Equals(object obj)
        {
            var varInfo = obj as MethodVarInfo;

            return varInfo != null 
                && Type.Equals(varInfo.Type)
                && Name == varInfo.Name;
        }


    }
}
