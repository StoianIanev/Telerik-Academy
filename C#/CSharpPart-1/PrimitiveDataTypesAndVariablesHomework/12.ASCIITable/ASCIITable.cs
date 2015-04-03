
// Task 12 - Find online more information about ASCII 
//  (American Standard Code for Information Interchange) 
//  and write a program that prints the entire ASCII table of characters on the console.


using System;

namespace _12.ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            for (int i = 0; i < 255; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
