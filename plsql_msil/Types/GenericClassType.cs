using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class GenericClassType :ClassType
    {

        //public GenericClassType(string packageName, string name, TypeInfo[] types)
        //    : this(packageName + "." + name, types)
        //{
        //}
        public GenericClassType(string realName, string name, TypeInfo[] types)
            : base(name, true)
        {
            ItemsType = types;
            RealName = realName;
        }

        public TypeInfo[] ItemsType { get; private set; }
        public string RealName { get; private set; }

        public override Type Type
        {
            get
            {
                return Type.Generic;
            }
        }

        //public override bool Equals(object obj)
        //{
        //    var type = obj as GenericClassType;

        //    return type != null && type.ItemsType.Equals(this.ItemsType);
        //}
    }
}
