using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any value");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                if (prime)
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(i);
                }
            }
        }
    }
}
