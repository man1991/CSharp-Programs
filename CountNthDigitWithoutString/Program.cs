using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNthDigitWithoutString
{
    class Program
    {
        public static int nthDigit(int value, int n)
        {
            if (n < 0) throw new ArgumentException();
            if (value < 0) throw new ArgumentException();

            while (n-- > 0)
            {
                value /= 10;
            }

            int digit = value % 10;
            return digit;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter digits:");
            int ent_digit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter digit to be found:");
            int desired_digit = Convert.ToInt32(Console.ReadLine());
            int result = nthDigit(ent_digit,desired_digit);
            Console.WriteLine("Found Nth Digit is \"{0}\"", result);
        }
    }
}
