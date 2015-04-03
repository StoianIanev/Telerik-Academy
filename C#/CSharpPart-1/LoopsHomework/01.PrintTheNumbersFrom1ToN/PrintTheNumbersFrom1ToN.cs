
//Task 1- Write a program that prints all the numbers from 1 to N.

using System;

namespace _01.PrintTheNumbersFrom1ToN
{
    class PrintTheNumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
