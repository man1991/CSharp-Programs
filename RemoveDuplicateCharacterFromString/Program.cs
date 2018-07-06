using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharacterFromString
{
    class Program
    {
        //public static string RemoveDuplicates(string input)
        //{
        //    return new string(input.ToCharArray().Distinct().ToArray());
        //}
        static void Main(string[] args)
        {
            string Str,distinctstring = "";
            //int Length;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            distinctstring = new string(Str.ToCharArray().Distinct().ToArray());
            Console.WriteLine("Distinct String After Removal Of Duplicate String Is: {0}", distinctstring);
            Console.ReadLine();

        }
    }
}
