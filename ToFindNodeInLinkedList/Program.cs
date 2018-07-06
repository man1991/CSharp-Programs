using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFindNodeInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linked = new LinkedList<string>();
            //
            // First add three elements to the linked list.
            //
            linked.AddLast("A");
            linked.AddLast("B");
            linked.AddLast("C");
            //
            // Insert a node before the second node (after the first node)
            //
            LinkedListNode<string> node = linked.Find("A");
            linked.AddAfter(node, "inserted");
            //
            // Loop through the linked list.
            //
            foreach (var value in linked)
            {
                Console.WriteLine(value);
            }
        }
    }
}
