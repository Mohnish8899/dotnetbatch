using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapno
{
    class swap
    {
        public static void Main (string[] args)
        {
            string a="M" ;
            string b="Q" ;
            driver d= new driver();
            d.methodbyref(ref a,ref b);
            Console.WriteLine("value of a"+a);
            Console.WriteLine("value of b"+b);
        
        }
    }
    class driver
    {
        public void methodbyref(ref String a,ref String b)
        {
            a="Q";
            b="M";
        }
    }
}