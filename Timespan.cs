using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimes
{
    class Date
    {
        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2022,08,02,17,00,00);
            DateTime date2 = new DateTime(2022,07,04,10,00,00);
            DateAndTimes.Difference.CalcDiff(date1,date2);
        }

    }

    class Difference

    {
        public static void CalcDiff(DateTime date1,DateTime date2)
        {
            TimeSpan timediff = date1 - date2;
            Console.WriteLine("Time difference between two days is: " + timediff);
        }
    }


}