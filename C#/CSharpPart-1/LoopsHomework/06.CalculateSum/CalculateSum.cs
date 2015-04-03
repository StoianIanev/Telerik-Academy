
//Task 6- Write a program that, for a given two integer numbers N and X, 
//        calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

namespace _06.CalculateSum
{
    class CalculateSum
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Incorrect input!");
            }

            double sum = 1;
            double fact = 1;
            double XpowN = 1;


            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                XpowN *= x;
                sum += fact / XpowN;
            }
            Console.WriteLine(sum);
        }
    }
}
