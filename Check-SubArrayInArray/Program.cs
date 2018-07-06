using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_SubArrayInArray
{
    class Program
    {
        public static bool CheckEquality<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            var dictionary = new Dictionary<T, int>();

            Action<IEnumerable<T>, int> setCounts = (items, change) =>
            {
                foreach (var item in items)
                {
                    int count;
                    // if not found, count will be the default value of 0
                    dictionary.TryGetValue(item, out count);
                    dictionary[item] = count + change;
                }
            };

            setCounts(first, +1);
            setCounts(second, -1);

            return dictionary.Values.All(value => value == 0);
        }
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int[] arr1 = { 1, 5 };

            //var result = arr1.Intersect(arr);

            //if (result.Count() == arr1.Length)
            //    Console.WriteLine("arr contins arr1 completely");

            //string[] Arr1 = new string[] { "a", "a", "b", "y" };
            //string[] Arr2 = new string[] { "s", "a", "z", "b", "c", "a" };

            //List<string> arr2Copy = new List<string>(Arr2);

            //List<string> results = new List<string>();
            //foreach (string a in Arr1)
            //{
            //    if (arr2Copy.Contains(a))
            //    {
            //        results.Add(a);
            //        arr2Copy.RemoveAt(arr2Copy.IndexOf(a));
            //    }
            //}

            //StringBuilder sb = new StringBuilder();
            //foreach (string s in results)
            //    sb.Append(s + ", ");

            //Console.WriteLine(sb.ToString().TrimEnd(new char[] { ',', ' ' }));
        }
    }
}
