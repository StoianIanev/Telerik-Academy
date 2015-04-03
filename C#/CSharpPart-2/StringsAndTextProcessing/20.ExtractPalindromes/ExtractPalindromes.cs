
//Task 20- Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ExtractPalindromes
{
    class ExtractPalindromes
    {
        static void Main()
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            bool equal = true;
            for (int i = 0; i <= word.Length/2; i++)
            {
                if (word[i] != word[word.Length-i-1])
                {
                    equal = false;
                    break;
                }
            }
            Console.WriteLine("Is the word is palindrome: {0}",equal);

        }
    }
}
