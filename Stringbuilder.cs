using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAppend
{
    class BuilderAppend
    {
        static void Main()
        {
            StringBuilder addWord = new StringBuilder("Mohnish ");
            addWord.Append("Manoj ");
            addWord.Append("Baviskar.");

            Console.WriteLine(addWord);

        }
    }
}