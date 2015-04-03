
//Task 6- Write a program that enters the coefficients a, b and c of a quadratic equation
//		  a*x2 + b*x + c = 0
//        and calculates and prints its real roots. Note that quadratic equations 
//        may have 0, 1 or 2 real roots.

using System;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Please enter the value a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the value b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the value c: ");
            double c = double.Parse(Console.ReadLine());
            double x1;
            double x2;
            double D;


            D = (b * b) - (4 * a * c);

            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);

            if (D > 0)
            {
                Console.WriteLine("D= {0}", D);
                Console.WriteLine("x1 = {0} ", x1);
                Console.WriteLine("x2 = {0} ", x2);
            }
            if (D == 0)
            {
                Console.WriteLine("D= {0}", D);
                x1 = x2 = (-b / (2 * a));
                Console.WriteLine("x1 = x2 = {0} ", x1);

            }
            if (D < 0)
            {
                Console.WriteLine("The quadratic equation no decision!");
            }

        }
    }
}
