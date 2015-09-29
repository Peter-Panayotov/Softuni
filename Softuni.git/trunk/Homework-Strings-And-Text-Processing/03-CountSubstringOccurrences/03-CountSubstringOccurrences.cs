using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string searchString=Console.ReadLine();
            int count = 0;
            for (int i = 0; i <= text.Length-searchString.Length; i++)
            {
                if (string.Compare(searchString, text.Substring(i, searchString.Length), true) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
