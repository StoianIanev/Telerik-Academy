
//Task 3- Write an expression that calculates rectangle’s area by given width and height.

using System;

namespace _03.CalculatesRectangleArea
{
    class CalculatesRectangleArea
    {
        static void Main()
        {
            Console.Write("Please enter width on rectangle: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Please enter height on rectangle: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("The are of rectangle is: {0}",(width*height)/2);

        }
    }
}
