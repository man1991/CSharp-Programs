//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SwapNumberWithoutTemp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double first, second;
//            first = 2340.12134;
//            second = 200.21234;
//            //a = a + b;
//            //b = a – b;
//            //a = a – b;
//            //Or
//            //a = a ^ b;
//            //b = b ^ a;
//            //a = a ^ b;
//            first = first + second;
//            second = first - second;
//            first = first - second;
//            Console.WriteLine(first.ToString());
//            Console.WriteLine(second.ToString());
//            Console.ReadLine();
//        }
//    }
//}
using System;
 
class Program
{
    static void Main()
    {
        int first, second;
        first = 100;
        second = 200;
        //swap numbers using XOR

        first = second ^ first;
        second = second ^ first;
        first = first ^ second;

        Console.WriteLine("first = " + first);
        Console.WriteLine("second = " + second);
        Console.ReadLine();

    }
}