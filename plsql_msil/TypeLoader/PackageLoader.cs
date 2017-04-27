using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types;

namespace plsql_msil.TypeLoader
{
    class PackageLoader : AbstractTypeLoader
    {
        public PackageLoader(TypeStorage storage, CSNameConvertor nameConvertor)
            : base(storage, nameConvertor)
        {
        }


        public void Build(ClassType classType, System.Type type)
        {
            base.Build(classType, type, (x) => x.IsPublic && x.IsStatic, (x) => x.IsPublic && x.IsStatic);
        }
    }
}
