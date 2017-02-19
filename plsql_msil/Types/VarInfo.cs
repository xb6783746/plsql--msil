using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    enum VarLocation
    {
        Local, Global, Argument
    }

    class VarInfo
    {
        public VarInfo(string name, TypeInfo type, VarLocation location)
        {
            Name = name;
            Type = type;
            Location = location;
        }

        public string Name { get; private set; }
        public TypeInfo Type { get; private set; }
        public VarLocation Location { get; private set; }

        public override bool Equals(object obj)
        {
            var varInfo = obj as VarInfo;

            return varInfo != null 
                && Name == varInfo.Name
                && Location == varInfo.Location;
        }


    }
}
