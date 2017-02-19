using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration
{
    class GenericType :TypeInfo
    {
        public GenericType(int num)
            : base("!"+num.ToString())
        {

        }
        public GenericType():base("!0")
        {

        }
    }
}
