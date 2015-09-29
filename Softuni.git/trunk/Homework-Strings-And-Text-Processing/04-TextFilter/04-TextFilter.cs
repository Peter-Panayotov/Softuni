using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = new List<string>();
            bannedWords = Console.ReadLine().Split(',',' ').Where(p => p.Length!=0).ToList();
            string text = Console.ReadLine();
            foreach (string s in bannedWords)
            {
               text = text.Replace(s, new string('*', s.Length));
                
            }
            Console.WriteLine(text);
        }
    }
}
