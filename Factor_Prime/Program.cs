using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are: ");
            List<int> result = Factor(num);
            foreach (int result_Factor in result)
            {
                Console.Write(result_Factor + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Prime Factors are:");

            foreach (int result_Prime in result)
            {
                bool IsprimeNumber = true;
                long value = Convert.ToInt32(Math.Sqrt(result_Prime));
                if (result_Prime % 2 == 0)
                {
                    if (result_Prime == 2)
                    {
                        Console.Write(result_Prime + " ");
                    }
                    IsprimeNumber = false;
                }
                for (long i = 3; i <= value; i = i + 2)
                {
                    if (result_Prime % i == 0)
                    {
                        IsprimeNumber = false;
                        break;
                    }
                    else
                    {
                        if (IsprimeNumber == true)
                        Console.Write(value + " ");
                    }
                }
            }
            Console.ReadLine();
        }
        static List<int> Factor(int number)
        {
            List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(number);  //round down
            for (int factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    { // Don't add the square root twice!
                        factors.Add(number / factor);
                    }
                }
            }
            factors.Sort();
            return factors;
        }
    }
}
