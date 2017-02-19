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

    class SimpeType :TypeInfo
    {

        public SimpeType(SimpleTypeEnum type) :base(type.ToString().ToLower())
        {
            this.SimpleType = type;
        }

        public override Type Type
        {
            get { return Type.Simple; }
        }

        public SimpleTypeEnum SimpleType
        {
            get;
            private set;
        }

    }
}
