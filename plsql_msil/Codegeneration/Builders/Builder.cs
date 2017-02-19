using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration.Builders
{
    abstract class Builder : IBuilder
    {

        protected List<IBuilder> builders = new List<IBuilder>();

        protected string GetCode()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in builders)
            {
                builder.AppendLine(item.Generate());
            }

            return builder.ToString();
        }

        public virtual string Generate()
        {
            return GetCode();
        }
    }
}
