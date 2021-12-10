using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Project
{
    class MathFirstClass
    {
        public static int sum(int operand1, int operand2)
        {
            int result = operand1 + operand2;
            return result;
        }
        public static int sub(int operand1, int operand2)
        {
            int result = operand1 - operand2;
            return result;
        }
        public static int mul(int operand1, int operand2)
        {
            int result = operand1 * operand2;
            return result;
        }
        public static int div(int operand1, int operand2)
        {
            int result = operand1 / operand2;
            return result;
        }
        public static int mod(int operand1, int operand2)
        {
            int result = operand1 % operand2;
            return result;
        }

       
    }
}
