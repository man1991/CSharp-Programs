using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define Array Size? ");
            int array_size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter numbers:\n");
            int[] array = new int[array_size];
            int i;
            for (i = 0; i < array_size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //int array_size = 10;
            //int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("The Array Before Selection Sort is: ");
            for (int j = 0; j < array_size; j++)
            {
                Console.WriteLine(array[j]);
            }
            int tmp, min_key;

            for (int k = 0; k < array_size - 1; k++)
            {
                min_key = k;

                for (int l = k + 1; l < array_size; l++)
                {
                    if (array[l] < array[min_key])
                    {
                        min_key = l;
                    }
                }

                tmp = array[min_key];
                array[min_key] = array[k];
                array[k] = tmp;
            }

            Console.WriteLine("The Array After Selection Sort is: ");
            for (int m = 0; m < array_size; m++)
            {
                Console.WriteLine(array[m]);
            }
            Console.ReadLine();
        }
    }
}
