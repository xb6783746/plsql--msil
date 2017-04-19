using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class PackageType : ClassType
    {
        public PackageType(string libName, string namespace_, string name, bool isImplemented = false)
            : base(libName, namespace_, name, isImplemented)
        {
        }
        public PackageType(string name) :base(name)
        {
        }

        private List<TypeInfo> innerTypes = new List<TypeInfo>();

        public override Type Type
        {
            get { return Type.Package; }
        }

        public override List<TypeInfo> Types
        {
            get
            {
                return innerTypes;
            }
        }

        public override TypeInfo GetType(string typeName)
        {
            return innerTypes.FirstOrDefault(x => x.Name == typeName);
        }
        public bool AddType(TypeInfo type)
        {
            bool ok = GetType(type.Name) == null;

            if (ok)
            {
                innerTypes.Add(type);
            }

            return ok;
        }

    }
}
