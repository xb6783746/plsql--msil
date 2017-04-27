namespace plsql_msil.Types
{
    class GenericType :TypeInfo
    {
        public GenericType(int num)
            : base("!"+num.ToString())
        {
            Number = num;
        }
        public GenericType():base("!0")
        {

        }

        public int Number { get; private set; }

        public static TypeInfo Get(int num)
        {
            return new GenericType(num);
        }
    }
}
