using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class program
    {
        static void Main(string[] args)
        {
            int side = 5;
            int width = 6;
            int length = 4;
            area.square.area_of_square(side);
            area.rectangle.area_of_rectangle(width,length);
        }
    }
    class square
    {
        public static void area_of_square(int side)
        {
            int resultarea;
            resultarea = side*side;
            Console.WriteLine("Area of Square is: "+ resultarea);
        }
    }
    class rectangle
    {
        public static void area_of_rectangle(int width, int length)
        {
            int resultrec;
            resultrec = width*length;
            Console.WriteLine("Area of rectangle is: "+ resultrec);
        }
    }
}