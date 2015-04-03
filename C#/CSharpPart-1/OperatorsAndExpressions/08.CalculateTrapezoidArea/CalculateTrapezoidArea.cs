
//Task 8- Write an expression that calculates trapezoid's area 
//      by given sides a and b and height h.

using System;

namespace _08.CalculateTrapezoidArea
{
    class CalculateTrapezoidArea
    {
        static void Main()
        {
            Console.Write("Enter side 'a' on trapezoid: ");
            double a = int.Parse(Console.ReadLine());

            Console.Write("Enter side 'b' on trapezoid: ");
            double b = int.Parse(Console.ReadLine());

            Console.Write("Enter height on trapezoid: ");
            double h = int.Parse(Console.ReadLine());

            Console.WriteLine("The area on trapezoid is: {0}",(a+b) * h / 2 );
        }
    }
}
