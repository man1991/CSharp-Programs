using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CountOfCharacters  
{

  public static  class CountOfCharacters
    {
        public static int result;
        public static int countofrepeatedchar(string inputstring, char ch)
        {
            char[] Inputstring = inputstring.ToCharArray();
            char Ch = ch;
            result = 0;
            int cntofchar = Inputstring.Length;
            foreach (char chr in Inputstring)
            {
                if (chr == Ch)
                {
                    result++;
                }

            }


            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The String:");
            string word1 = Console.ReadLine();
            Console.Write("Enter Character To Be Found:");
            char word2 = Convert.ToChar(Console.ReadLine());
            int resy = countofrepeatedchar(word1, word2);
            Console.WriteLine("Count Of Charcters from \"{0}\" for character \"{1}\" is \"{2}\"", word1,word2,resy.ToString());
            Console.ReadLine();
        }
    }
}
