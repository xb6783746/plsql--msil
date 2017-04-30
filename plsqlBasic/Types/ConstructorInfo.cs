using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    public class ConstructorInfo :MethodInfo
    {

        public ConstructorInfo(bool isStatic, ClassType where) :base("", TypeInfo.Void, isStatic, where)
        {
        }
    }
}
