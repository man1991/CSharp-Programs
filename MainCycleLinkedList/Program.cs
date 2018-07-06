using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCycleLinkedList
{
    class LinkedListStack
    {
        static void Main(string[] args)
        {
            //    //Call in Program.cs to test
            LinkedListStack list = new LinkedListStack();
            list.Push("pushed first");
            list.Push("pushed second");
            list.Push("pushed third");
            Console.WriteLine(list.DetectCycle());
            list.CreateCycle();
            Console.WriteLine(list.DetectCycle());
        }
    }
}
