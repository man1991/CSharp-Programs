using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int vowelCount = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine().ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("Your total number of vowels is: {0}", vowelCount);
            Console.ReadLine();
            ////Using LINQ
            //int vowelCount  = sentence.Count(c => vowels.Contains(c));
            //int vowelCount  = sentence.Count(c => "aeiou".Contains(char.ToLower(c))); -- without declaring extra variable for storing vowel 

            //Using Switch Case
            //var vowelCount = 0;
            //foreach (char c in sentence.ToLower())
            //{
            //    switch (c)
            //    {
            //        case 'a':
            //        case 'e':
            //        case 'i':
            //        case 'o':
            //        case 'u':
            //            vowelCount++;
            //            break;
            //        default: continue;
            //    }

            //}
            //Console.WriteLine(vowelCount.ToString());
        }
    }
}
