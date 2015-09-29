using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string resultString;
            string inputString = Console.ReadLine();
            if (inputString.Length>20)
            {
                resultString = inputString.Substring(0, 20);

            }
            else
            {
                resultString = inputString + new string('*', 20 - inputString.Length);

            }
            
            Console.WriteLine(resultString);
        }
    }
}
