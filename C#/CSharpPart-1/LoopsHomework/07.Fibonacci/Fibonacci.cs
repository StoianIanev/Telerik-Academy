
//Task 7- Write a program that reads a number N and calculates the sum of the first N members 
//  of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

namespace _07.Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger num1 = 0;
            BigInteger num2 = 1;
            BigInteger sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + num1 + num2;
                Console.WriteLine(sum);
                num1 = num2;
                num2 = sum;
            }

        }
    }
}
