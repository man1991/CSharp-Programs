using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "aaaabbcddddddddddeeffffg";
            string Str;//, reversestring = "";
            //int Length;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            var qry = (from c in Str
                       group c by c into grp
                       orderby grp.Count() descending
                       select new
                       {
                           Character = grp.Key,
                           Count = grp.Count()
                       }).Take(1);

            foreach (var v in qry)
            {
                Console.WriteLine("'{0}' is counted {1} time(s)", v.Character, v.Count);
            }
        }
    }
}
