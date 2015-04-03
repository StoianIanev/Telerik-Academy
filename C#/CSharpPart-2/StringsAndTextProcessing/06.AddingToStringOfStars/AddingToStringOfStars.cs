
//Task 6- Write a program that reads from the console a string of maximum 20 characters. 
//        If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AddingToStringOfStars
{
    class AddingToStringOfStars
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string word = Console.ReadLine();
            char star = '*';

            if (word.Length > 20)
            {
                Console.WriteLine("The word is very long!");
            }
            else
            {
                Console.WriteLine(word.PadRight(20,star));
            }

           

        }
    }
}
