
//Task 9- Write a program to print the first 100 members of the sequence of 
//       Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

namespace _09.Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            BigInteger num1 = 0;
            BigInteger num2 = 1;
            BigInteger num3 = 0;

            for (int i = 0; i < 100; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
