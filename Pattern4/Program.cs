using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for displaying pattern of *.");
            Console.Write("Enter the maximum number of *: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHere is the Pattern of Stars\n");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("*");
                }

                if (i != n - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" * ");
                }
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
