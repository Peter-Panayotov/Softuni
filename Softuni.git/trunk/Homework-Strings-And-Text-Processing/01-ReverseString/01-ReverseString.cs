using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.Append( Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = input.Length-1; i >=0 ; i--)
            {
                result.Append(input[i]);
            }

            Console.WriteLine(result);
        }
    }
}
