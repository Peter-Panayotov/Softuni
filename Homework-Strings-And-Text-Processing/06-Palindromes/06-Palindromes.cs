using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            SortedSet<string> palindromes = new SortedSet<string>();
            var input = Console.ReadLine().Split(',', ' ', '?', '.', '!').Where(p => p != "");

            char[] word;
            foreach (var v in input)
            {
                    
                    palindromes.Add(v.ToString());
                
            }
            foreach (string s in palindromes)
            {
                word = s.ToCharArray();
                Array.Reverse(word);
                if (s.Equals(new string(word)))
                    Console.Write(s + ", ");
            }
            

        }
    }
}
