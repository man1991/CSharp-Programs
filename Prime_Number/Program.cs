using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any value");
            num = int.Parse(Console.ReadLine());
            //IEnumerable result= Primes01(num);
            // foreach (int result_Prime in result)
            // {
            //     Console.WriteLine(result_Prime);
            // }
            //long result = FindPrimeNumber(num);
            //Console.ReadLine();

        }
        //static IEnumerable Primes01(int num)
        //{
        //    return Enumerable.Range(1, Convert.ToInt32(Math.Floor(Math.Sqrt(num))))
        //        .Aggregate(Enumerable.Range(1, num).ToList(),
        //        (result, index) =>
        //        {
        //            result.RemoveAll(i => i > result[index] && i % result[index] == 0);
        //            return result;
        //        }
        //        );
        //}
        //static  long FindPrimeNumber(long num)
        //{
        //    //int max = (int)Math.Sqrt(num) + 1;  //round down

        //    for (long i = 1; i <= num; i++)
        //    {
        //        int totalFactors = 0;
        //        for (int j = 1; j <= i; j++)
        //        {
        //            if (i % j == 0)
        //            {
        //                totalFactors = totalFactors + 1;
        //            }
        //        }
        //        if (totalFactors == 2)
        //        {
        //            Console.WriteLine(i);
        //        }
        //        return i;
        //    }
            
        //}

    }
}
