using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration
{
    public struct Command
    {
        public Command(int number, string val, Code code)
        {
            this.number = number;
            this.val = val;
            this.code = code;
        }

        private int number;
        private string val;
        private Code code;


        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Value
        {
            get { return val; }
            set { val = value; }
        }
        public Code Code
        {
            get { return code; }
            set { code = value; }
        }
    }
}
