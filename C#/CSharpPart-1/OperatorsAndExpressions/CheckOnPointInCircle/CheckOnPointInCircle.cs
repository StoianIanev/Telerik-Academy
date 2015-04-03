
//Task 6- Write an expression that checks if given point (x,  y) 
//        is within a circle K(O, 5).

using System;

namespace CheckOnPointInCircle
{
    class CheckOnPointInCircle
    {
        static void Main()
        {
            Console.Write("Please enter point x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Please enter point y: ");
            int y = int.Parse(Console.ReadLine());

            int r = 5;

            if (x * x + y * y < r * r)
            {
                Console.WriteLine("The point is in the circle");
            }
            else if (x * x + y * y == r * r)
            {
                Console.WriteLine("The point lies on the circle");
            }
            else
            {
                Console.WriteLine("The point is not in the circle");
            }
        }
    }
}
