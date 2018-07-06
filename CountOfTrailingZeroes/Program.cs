using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CountOfTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to calculate factorial and trailing zeroes:");
            int n = int.Parse(Console.ReadLine());
            int zero = 0;
            long fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine("Factorial is:" + fac);
            ab:
            if (fac % 10 == 0)
            {
                fac = fac / 10;
                zero++;
                goto ab;
            }
            else
            {
                Console.WriteLine("Count of trailing 0s in {0} is {1} ",n,zero);
                Console.WriteLine("After Removing Trailing Zeroes:" + fac);
            }
            Console.ReadLine();
        }
        //Console.WriteLine("Enter an integer:");
        //int n = int.Parse(Console.ReadLine());
        //int k = 0;
        //int trailingZero = 0;
        //while (Math.Pow(5, k) < n)
        //{
        //    k++;
        //    trailingZero += n / (int)(Math.Pow(5, k));
        //}
        //Console.WriteLine("Count of trailing 0s in {0} is {} ",n,trailingZero);
    }
    }
    

