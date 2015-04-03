
//Task 22- Write a program that reads a string from the console and lists all different words 
//         in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.CountWords
{
    class CountWords
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string[] array = str.Split(' ');

            var sort = array.OrderBy(x => x);
            foreach (var word in sort.GroupBy(x=>x))
            {
                Console.WriteLine("{0}-> {1}",word.Key,word.Count());
            }

          
        }

    }
}
