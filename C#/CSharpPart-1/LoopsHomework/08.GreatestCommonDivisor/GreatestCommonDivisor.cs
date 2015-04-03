
//Task 8- Write a program that calculates the greatest common divisor (GCD) 
//       of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

namespace _08.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {

        static int GCD(int a, int b)
        {
            if (a < 0)
            {
                a = a * (-1);
            }
            if (b < 0)
            {
                b = b * (-1);
            }
            bool result = a > b;
            if (result == true)
            {
                while (a > b)
                {
                    a = a - b;
                }
            }
            else
            {
                while (b > a)
                {
                    a = b - a;
                }
            }
            
            return a;
        }
        static void Main()
        {
            Console.Write("Ener a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ener b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The greatest common divisor on {0} and {1} is: {2}",a,b,GCD(a, b));
        }
    }
}
