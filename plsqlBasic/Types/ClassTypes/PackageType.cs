﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    public class PackageType : ClassType
    {
        public PackageType(string name) :base(name)
        {
        }

        private List<TypeInfo> innerTypes = new List<TypeInfo>();

        public List<TypeInfo> Types
        {
            get
            {
                return innerTypes;
            }
        }

        public TypeInfo GetType(string typeName)
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
