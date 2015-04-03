
//Task 24- Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.SortWords
{
    class SortWords
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string[] str = Console.ReadLine().Split(' ', ',', '.');
           
            var sortedArray = str.OrderBy(x => x); // <=> Array.Sort()
            Console.Write("The sorted array is: ");
            foreach (var arr in sortedArray)
            {
                Console.Write("{0}",arr);
                
            }
            Console.WriteLine();
        }
    }
}
