using System.Collections.Generic;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    public class GenericType :TypeInfo
    {
        public GenericType(int num)
            : base("")
        {
            Number = num;

        }

        public int Number { get; private set; }

        public static TypeInfo Get(int num)
        {
            return new GenericType(num);
        }

    }
}
