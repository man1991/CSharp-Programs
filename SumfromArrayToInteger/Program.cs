using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumfromArrayToInteger
{

    public static class SumfromArrayToInteger
    {
        //Brute force solution, O(n^2) time complexity
        public static bool TwoIntegersSumToTarget(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (i != k)
                    {
                        int sum = arr[i] + arr[k];
                        if (sum == target)
                            return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Define Array Size? ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter numbers:\n");
            int[] arr = new int[number];
            int i;
            for (i = 0; i < number; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Desired Value Of Sum:");
            int AddSum = int.Parse(Console.ReadLine());
            bool result = TwoIntegersSumToTarget(arr,AddSum);
            Console.WriteLine("Result Is: {0}",result);
            Console.ReadLine();
        }
    }
}
