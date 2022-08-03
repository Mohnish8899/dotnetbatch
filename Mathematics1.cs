using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class operations
    {
        static void Main()
        {
            int num1 = 20;
            int num2 = 30;
            int result;

            result = num1 + num2;
            Console.WriteLine("Addition is {0}", result);

            result = num1 - num2;
            Console.WriteLine("Substraction is {0}", result);

            result = num1 * num2;
            Console.WriteLine("Multiplication is {0}", result);

            result = num1 / num2;
            Console.WriteLine("Division is {0}", result);

        }
    }
}