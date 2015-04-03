
//Task 12- Write a program that creates an array containing all letters 
//         from the alphabet (A-Z). 
//    Read a word from the console and print the index of each of its letters in the array.

using System;

namespace _12.PrintLetterIndex
{
    class PrintLetterIndex
    {
        static void Main()
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine().ToUpper();

            char[] letters = new char[27];
            int initializization = 65;

            for (int i = 1; i < letters.Length; i++)
            {
                letters[i] = (char) initializization;
                initializization++;
            }

            foreach (char letter in word)
            {
                for (int i = 1; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                    {
                        Console.WriteLine("The index of the letter {0} is {1}", letter, i);
                        break;
                    }
                }
            }
            
        }
    }
}
