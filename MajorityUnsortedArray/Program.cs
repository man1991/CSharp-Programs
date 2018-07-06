using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityUnsortedArray
{
    public class MajorityUnsortedArray
    {
        //Find majority element in an unsorted array
        //Ex. {1,2,3,4,5,2,2,2,2}, 2 is the majority element because it accounts for more than 50% of the array
        public static int GetMajorityElement(int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;

            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            //No majority element
            throw new Exception("No majority element in array");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Define Array Size? ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter numbers:\n");
            int[] arr = new int[number];
            int i;
            for ( i = 0; i < number; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    Console.Write("Array Index: " + j + " AND Array Item: " + arr[j].ToString());
            //}
            int resy = GetMajorityElement(arr);
            Console.WriteLine("Count Of majority element in an unsorted array{0} is {1}", arr[i], resy.ToString());
            Console.ReadLine();
        }
    }
}
