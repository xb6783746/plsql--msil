using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    public interface INameConvertor
    {

        string Convert(TypeInfo type);
        string FromPlatformName(string name);
    }
}
