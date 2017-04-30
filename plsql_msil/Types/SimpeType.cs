using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    public enum GenericTypeEnum
    {
        Table, Dictionary, Array
    }

    public enum SimpleTypeEnum
    {
        Bool, Byte, Char, Int, Float, Double, String, Void, Null, Undefined
    }

    class SimpleType :TypeInfo
    {


        public SimpleType(SimpleTypeEnum type) :base(type.ToString().ToLower())
        {
            this.SType = type;
        }

        private static SimpleTypeEnum[] order = new SimpleTypeEnum[]
        {
            SimpleTypeEnum.Byte,
            SimpleTypeEnum.Char,
            SimpleTypeEnum.Int, 
            SimpleTypeEnum.Float,
            SimpleTypeEnum.Double
        };

        public override Type Type
        {
            get { return Type.Simple; }
        }

        public SimpleTypeEnum SType
        {
            get;
            private set;
        }

        public bool IsNumeric()
        {
            return order.Contains(SType);
        }

    }
}
