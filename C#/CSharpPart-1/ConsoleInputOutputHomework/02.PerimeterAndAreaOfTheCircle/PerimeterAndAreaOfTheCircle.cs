
//Task 2- Write a program that reads the radius r of a circle 
//        and prints its perimeter and area.

using System;

namespace _02.PerimeterAndAreaOfTheCircle
{
    class PerimeterAndAreaOfTheCircle
    {
        static void Main()
        {
            Console.Write("Enter the radius of the circle: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the circle is: {0}",2*Math.PI*r);
            Console.WriteLine("The area of the circle is: {0}", Math.PI * r * r);

        }
    }
}
