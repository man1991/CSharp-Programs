using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Character:");
            //var parts = System.Text.RegularExpressions.Regex.Matches();
            char ch1 =Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Second Character:");
            char ch2 = Convert.ToChar(Console.ReadLine());
            for (char i = ch1; i <= ch2; i++)
            {
                for (char j = ch1; j <= ch2; j++)
                {
                    //Console.Write(i);Pattern2
                    Console.Write(j);//Pattern3
                }
                Console.Write("\n");
            }
            Console.ReadLine();


        }
    }
}
