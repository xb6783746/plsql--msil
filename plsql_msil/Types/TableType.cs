using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class TableType :ClassType
    {

        public TableType(string packageName, string name, TypeInfo itemsType)
            : this(packageName + "." + name, itemsType)
        {
        }
        public TableType(string name, TypeInfo itemsType)
            : base(name, true)
        {
            ItemsType = itemsType;
        }

        public TypeInfo ItemsType { get; private set; }

        public override Type Type
        {
            get
            {
                return Type.Table;
            }
        }

    }
}
