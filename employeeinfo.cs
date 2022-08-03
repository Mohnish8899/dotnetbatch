using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    class details
    {
        static void Main(string[] args)
        {
            empinfo P1 = new empinfo();
            P1.emp();

        }
    }
    class empinfo
    {
        public void emp()
        {
            Console.WriteLine("First Employee Details:");
            string name1 = "Employee 1";
            Console.WriteLine(name1);
            string Address1 = "United states";
            Console.WriteLine(Address1);
            Console.WriteLine("Second Employee Details:");
            string name2 = "Employee 2";
            Console.WriteLine(name2);
            string Address2 = "India";
            Console.WriteLine(Address2);
            Console.WriteLine("First Employee Details:");
            string name3 = "Employee 3";
            Console.WriteLine(name3);
            string Address3 = "Australia";
            Console.WriteLine(Address3);
        }
    }
}