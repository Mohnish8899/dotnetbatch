using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class operations
    {
         static void Main(string[] args)
         {
            math.Addition.Add();
            math.Substraction.sub();
            math.Multiplication.Mul();
            math.Division.Div();
         } 

     }
    class Addition
    {
        public static void Add()
        {
            int num1 = 20;
            int num2 = 10;
            int resultAdd;

            resultAdd = num1 + num2;
            Console.WriteLine("Addition is {0}", resultAdd);
        }
    }
    class Substraction
    {
        public static void sub()
        {
            int num1 = 20;
            int num2 = 10;
            int resultSub;

            resultSub = num1 - num2;
            Console.WriteLine("Substraction is {0}", resultSub);
        }
    }
    class Multiplication
    {
        public static void Mul()
        {
            int num1 = 20;
            int num2 = 10;
            int resultMul;

            resultMul = num1 * num2;
            Console.WriteLine("Multiplication is {0}", resultMul);
        }
    }
    class Division
    {
        public static void Div()
        {
            int num1 = 20;
            int num2 = 10;
            int resultDiv;

            resultDiv = num1 / num2;
            Console.WriteLine("Division is {0}", resultDiv);
        }
    }
}
 
    