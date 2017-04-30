using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    class RecordType : ClassType
    {
        public RecordType(string packageName, string name)
            : base(packageName + "." + name)
        {

            PackageName = packageName;
            RecordName = name;
        }


        public string PackageName { get; private set; }
        public string RecordName { get; private set; }

        public override Type Type
        {
            get
            {
                return Type.Record;
            }
        }
    }
}
