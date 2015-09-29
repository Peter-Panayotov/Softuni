using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (char s in text)
            {
                Console.Write("\\u{0:x4}", (int)s);

            }
            Console.WriteLine();
           
        }
    }
}
