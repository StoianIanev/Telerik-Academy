
// Task 10-Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
//         Sample input:
//         Hi !
//         Expected output:
//         \u0048\u0069\u0021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ConvertsAString
{
    class ConvertsAString
    {
        static void Main()
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            foreach (var words in word)
            {
                Console.Write("\\u{0:x4}",(int)words);
            }
            Console.WriteLine();
        }
    }
}
