using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class RecordType :TypeInfo
    {
        public RecordType(string libName, string namespace_, string packageName, string name)
            : this(packageName, name, new List<VarInfo>())
        {
            LibName = libName;
            Namespace = namespace_;
            IsLibClass = true;
        }
        public RecordType(string packageName, string name, List<VarInfo> vars)
            : base(packageName + "." + name, true)
        {

            PackageName = packageName;
            RecordName = name;
            Vars = vars;
        }


        public string PackageName { get; private set; }
        public string RecordName { get; private set; }
        public List<VarInfo> Vars { get; private set; }

        public override Type Type
        {
            get
            {
                return Type.Record;
            }
        }

        public bool AddVar(string name, TypeInfo type)
        {
            var varInfo = Vars.FirstOrDefault(x => x.Name == name);

            bool res = varInfo == null;

            if(res)
            {
                Vars.Add(new VarInfo(name, type, VarLocation.Global));
            }

            return res;
        }

        public override VarInfo GetField(string memberName)
        {
            return Vars.FirstOrDefault(x => x.Name == memberName);
        }
    }
}
