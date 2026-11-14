using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {

        public float printAddition(float x, float y)
        {
            return x + y;
        }

        public float printSubtraction(float x, float y)
        {
            return x - y;
        }

        public float printMultiplication(float x, float y)
        {
            return x * y;
        }

        public float printDivision(float x, float y)
        {

            if(x == 0 || y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero. Please Try Again.");
            }
            return x / y;
        }
    }
}
