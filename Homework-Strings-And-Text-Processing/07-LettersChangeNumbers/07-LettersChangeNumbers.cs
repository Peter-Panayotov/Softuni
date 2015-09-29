using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string [] inputStrings = Console.ReadLine().Split();
            double sum = 0;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string number;
            double totalSum = 0;
            for (int i = 0; i < inputStrings.Length; i++)
            {
                if (inputStrings[i] != "")
                {
                    number = inputStrings[i].Remove(inputStrings[i].Length - 1);
                    number = number.Remove(0, 1);
                    
                    if (inputStrings[i][0].ToString().ToUpper().Equals(inputStrings[i][0].ToString()))
                    {
                        sum += double.Parse(number) / (alphabet.IndexOf(inputStrings[i][0].ToString().ToLower()) + 1);
                        

                    }
                    else
                    {
                        sum +=double.Parse(number) * (alphabet.IndexOf(inputStrings[i][0].ToString().ToLower()) + 1);
                       
                    }
                    if (inputStrings[i][inputStrings[i].Length - 1].ToString().ToUpper().Equals(inputStrings[i][inputStrings[i].Length - 1].ToString()))
                    {
                        sum -= (alphabet.IndexOf(inputStrings[i][inputStrings[i].Length - 1].ToString().ToLower()) + 1);
                       
                    }
                    else
                    {
                        sum += (alphabet.IndexOf(inputStrings[i][inputStrings[i].Length - 1].ToString().ToLower()) + 1);
                        
                    }
                    totalSum += sum;
                    sum = 0;
                }
            }
            Console.WriteLine("{0:f2}",totalSum);


        }
    }
}
