using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    enum BinaryOperatorEnum
    {
        Plus, Minus, Mul, Div, Mod
    }

    class OperatorTable
    {

        public TypeInfo GetType(BinaryOperatorEnum op, TypeInfo operand1, TypeInfo operand2)
        {
            return GetOperatorType(op, operand1 as SimpleType, operand2 as SimpleType);
        }

        private TypeInfo GetOperatorType(BinaryOperatorEnum op, SimpleType operand1, SimpleType operand2)
        {
            if (operand1 == null || operand2 == null)
            {
                return null;
            }

            if (operand1.IsNumeric() && operand2.IsNumeric())
            {
                return operand1.SType < operand2.SType ? operand2 : operand1;
            }

            return null;
        }
    }
}
