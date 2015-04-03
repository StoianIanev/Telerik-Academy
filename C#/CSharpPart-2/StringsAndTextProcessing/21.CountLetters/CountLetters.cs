
//Task 21- Write a program that reads a string from the console and prints all different letters 
//         in the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.CountLetters
{
    class CountLetters
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            var sortLetters = str.OrderBy(x => x);
            foreach (var words in sortLetters.GroupBy(x=>x))
	        {
                Console.WriteLine("{0}-> {1} times",words.Key,words.Count());
		 
	        } 
            
        }
    }
}
