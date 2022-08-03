using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_and_builder
{
    class program
    {
        static void Main(string[] args)
        {
            string str1 = "Mohnish ";
            string str2 = "Baviskar";
            string_and_builder.build.builder();
            string_and_builder.string_concatenate.concatenate(str1,str2);

        }
    }
    class build
    {
        public static void builder()
        {
            StringBuilder addWord = new StringBuilder("Mohnish ");
            addWord.Append("Manoj ");
            addWord.Append("Baviskar. ");
            Console.WriteLine(addWord);

        }


    }
    class string_concatenate
    {
        public static void concatenate(string str1, string str2)
        {
            string resultCon;
            resultCon = str1 + str2;
            Console.WriteLine(" The string concetanation is: " + resultCon);
        }
    }
}
