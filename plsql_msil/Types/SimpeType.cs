using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    public enum SimpleTypeEnum
    {
        Int, Char, Bool, String, Double, Float, Void, Null, Undefined
    }

    class SimpleType :TypeInfo
    {

        public SimpleType(SimpleTypeEnum type) :base(type.ToString().ToLower(), true)
        {
            this.SType = type;
        }

        public override Type Type
        {
            get { return Type.Simple; }
        }

        public SimpleTypeEnum SType
        {
            get;
            private set;
        }

    }
}
