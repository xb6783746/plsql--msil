using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    public class TypeStorage
    {
        public TypeStorage()
        {

        }

        private List<TypeInfo> types = new List<TypeInfo>();
        private List<LibraryInfo> libs = new List<LibraryInfo>();
        private List<GenericTemplate> genericTemplates = new List<GenericTemplate>();

        public List<TypeInfo> Types { get { return types; } }

        public List<LibraryInfo> Libs { get { return libs; } }

        public bool AddType(TypeInfo type)
        {
            bool ok = Exists(type.Name);

            if(!ok)
            {
                types.Add(type);
            }

            return ok;
        }

        public bool AddTemplate(GenericTemplate template)
        {
            bool ok = genericTemplates.Exists(x => x.Name == template.Name);

            if (!ok)
            {
                genericTemplates.Add(template);
            }

            return ok;
        }

        public TypeInfo GetType(string name)
        {

            var type = types.FirstOrDefault(x => x.Name.Equals(name));

            return type;
        }
        public GenericTemplate GetTemplate(string name)
        {

            return genericTemplates.FirstOrDefault(x => x.Name.Equals(name));
        }

        public bool Exists(string name)
        {

            return types.FirstOrDefault(x => x.Name.Equals(name)) != null;
        }

        public TypeStorage Clone()
        {
            var typeStorage = new TypeStorage();

            typeStorage.types = new List<TypeInfo>(types);
            typeStorage.libs = new List<LibraryInfo>(libs);
            typeStorage.genericTemplates = new List<GenericTemplate>(genericTemplates);

            return typeStorage;
        }


    }
}
