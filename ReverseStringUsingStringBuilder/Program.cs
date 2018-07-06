using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringUsingStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to reverse :");
            string str = Console.ReadLine();

            StringBuilder revStr = new StringBuilder();

            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }

            Console.WriteLine(revStr.ToString());
        }
    }
}
