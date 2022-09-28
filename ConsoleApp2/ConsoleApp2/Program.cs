using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService1 myMathService = new localhost.WebService1();
            Console.Write("4 + 7 = {0}", myMathService.Add(4, 7));
       
        }
    }
}
