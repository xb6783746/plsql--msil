using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class GenericClassType :ClassType
    {

        public GenericClassType(string realName, string name, TypeInfo[] types)
            : base(name)
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

        public override bool CanBeAssignedWith(TypeInfo info)
        {
            var genericType = info as GenericClassType;

            return genericType != null && TypeInfo.Compare(ItemsType, genericType.ItemsType);
        }
    }
}
