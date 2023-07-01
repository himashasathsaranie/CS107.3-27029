using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine("Number of vowels: " + vowelCount);

            Console.ReadLine();
        }
        static int CountVowels(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsVowel(char c)
        {
            char lowerC = char.ToLower(c);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach(char vowel in vowels)
            {
                if(lowerC == vowel)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
