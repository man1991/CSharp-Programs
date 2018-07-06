using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisks_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Program for displaying pattern of *.");
            Console.Write("Enter number of layer to print Pyramid *: ");
            int numberoflayer = Convert.ToInt32(Console.ReadLine());
            int Space, Number;
            Console.WriteLine("Print Pyramid");
            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++)  // Loop For Space
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value
                    //Console.Write(Number);
                Console.Write("*");
                for (Number = (i - 1); Number >= 1; Number--)  //decrease the value
                    //Console.Write(Number);
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}

