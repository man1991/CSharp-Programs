using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_MergeSort
{
    class Program
    {
        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }
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
            //Console.WriteLine("The Array Before Selection Sort is: ");
            //for (int j = 0; j < array_size; j++)
            //{
            //    Console.WriteLine(array[j]);
            //}
            //int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            //int len = 9;
            Console.WriteLine("MergeSort By Recursive Method");
            MergeSort_Recursive(array, 0, array_size - 1);
            for (int k = 0; k < array_size; k++)
                Console.WriteLine(array[k]);
        }
    }
}
