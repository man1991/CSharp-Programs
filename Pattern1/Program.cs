﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Levels:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultant Pattern Is:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
