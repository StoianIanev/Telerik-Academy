
//Task 10- Write a boolean expression that returns if the bit at position p 
//        (counting from 0) in a given integer number v has value of 1. 
//        Example: v=5; p=1  false.

using System;

namespace _10.TheBitAtPositionP
{
    class TheBitAtPositionP 
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine()); ;

            int mask = 1 << p;
            int number = mask & v;

            int theBit = number >> p;

            Console.WriteLine("Is the bit {0} in number {1} with value 1? {2}",p,v,(theBit != 0 ));

        }
    }
}
