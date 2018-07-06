using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str, reversestring = "";
            int Length;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reversestring);
            Console.ReadLine();
        }
    }
}
