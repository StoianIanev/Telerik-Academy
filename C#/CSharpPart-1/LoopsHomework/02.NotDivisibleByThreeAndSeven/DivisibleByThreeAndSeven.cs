
//Task 2- Write a program that prints all the numbers from 1 to N, 
//        that are not divisible by 3 and 7 at the same time.

using System;

namespace _02.DivisibleByThreeAndSeven
{
    class DivisibleByThreeAndSeven
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
