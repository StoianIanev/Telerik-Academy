
//Task 9- Write an expression that checks for given point (x, y) 
//        if it is within the circle K( (1,1), 3) and out of 
//        the rectangle R(top=1, left=-1, width=6, height=2).

using System;

namespace _09.PointInCircleAndOutsideRectangle
{
    class PointInCircleAndOutsideRectangle
    {
        static void PointInCircle(int x, int y)
        {
            int r = 3;

            if ((x-1) * (x-1) + (y-1) * (y-1) < r * r)
            {
                Console.WriteLine("The point is in the circle");
            }
            else if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= r * r)
            {
                Console.WriteLine("The point lies on the circle");
            }
            else
            {
                Console.WriteLine("The point is not in the circle");
            }

        }
        static void PointOutsideRectangle(int x, int y)
        {
            //Set the rectangle's coordinates
            int top = 1;
            int left = -1;
            int width = 6;
            int height = 2;

            if ((x < left) || (x > width) || (top < y) || (y > height))
            {
                Console.WriteLine("The point is not in the rectangle");
            }
            else
            {
                Console.WriteLine("The point is in the rectangle");
            }


        }

        static void Main()
        {
            Console.Write("Please enter point x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Please enter point y: ");
            int y = int.Parse(Console.ReadLine());
            PointInCircle(x,y);
            PointOutsideRectangle(x, y);


        }
    }
}
