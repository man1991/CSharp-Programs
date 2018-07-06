﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//An anagram of a string is another string that contains same characters, only the order of characters can be different.
//For example, “abcd” and “dabc” are anagram of each other.

namespace AnagramCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();

            //Add optional validation of input words if needed.  
            //.....  

            //step 1  
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //Step 2  
            Array.Sort(char1);
            Array.Sort(char2);

            //Step 3  
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //Step 4  
            //ToLower allows to compare the words in same case, in this case, lower case.  
            //ToUpper will also do exact same thing in this context  
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }

            //Hold Console screen alive to view the results.  
            Console.ReadLine();
        }
    }
}
    

