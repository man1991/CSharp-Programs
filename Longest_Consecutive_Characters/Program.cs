using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Consecutive_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string desired_Str;
            Console.Write("Enter A String : ");
            desired_Str = Console.ReadLine();
            Char[] c = desired_Str.ToCharArray();
            string longest = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < c.Length; i++)
            {
                char curr = c[i];
                char next = i != c.Length - 1 ? c[i + 1] : '\0'; // check whether the current char is the last
                sb.Append(curr);
                if (curr != next)
                {
                    string temp = sb.ToString();
                    if (temp.Length > longest.Length)
                    {
                        longest = temp; // if the new string with the new chars is longer, replace the longest string
                    }
                    sb.Clear(); // clear the StringBuilder
                }
            }
            Console.WriteLine("Longest repeating sequence of charachters is '{0}'  is at position '{1}'", longest[0], desired_Str.IndexOf(longest));
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
