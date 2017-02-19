using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class TypeStorage
    {
        public TypeStorage()
        {

        }

        private List<TypeInfo> types = new List<TypeInfo>();
        private List<TypeInfo> declaredTypes = new List<TypeInfo>();
        private List<LibraryInfo> libs = new List<LibraryInfo>();

        public List<TypeInfo> Types { get { return types; } }
        public List<TypeInfo> DeclaredTypes { get { return declaredTypes; } }

        public List<LibraryInfo> Libs { get { return libs; } }

        public bool AddType(TypeInfo type, bool isDeclared)
        {
            bool ok = Exists(type.Name);
            var list = isDeclared ? declaredTypes : types;

            if(!ok)
            {
                list.Add(type);
            }

            return ok;
        }

        public TypeInfo GetType(string name)
        {

            return types.Union(declaredTypes).FirstOrDefault(x => x.Name == name);
        }

        public bool Exists(string name)
        {

            return GetType(name) != null;
        }

        public TypeStorage Clone()
        {
            var typeStorage = new TypeStorage();

            typeStorage.types = new List<TypeInfo>(types);
            typeStorage.declaredTypes = new List<TypeInfo>(declaredTypes);
            typeStorage.libs = new List<LibraryInfo>(libs);

            return typeStorage;
        }


    }
}
