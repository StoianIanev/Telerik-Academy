
//Task 10- Write a program to calculate n! for each n in the range [1..100]. 
//         Hint: Implement first a method that multiplies a number represented as array 
//         of digits by given integer number. 

using System;
using System.Numerics;

namespace _10.NFac
{
    class NFac
    {
        static BigInteger Factorial(int n)
        {
            BigInteger product = 1;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }

            return product;
        }
        static void Main()
        {
            Console.WriteLine("Enter N! - form 0 to 100: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}",n,Factorial(n));
        }
    }
}
