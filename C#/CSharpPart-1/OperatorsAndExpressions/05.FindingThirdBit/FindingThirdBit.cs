
//Task 5- Write a boolean expression for finding if the bit 3 
//       (counting from 0) of a given integer is 1 or 0.

using System;

namespace _05.FindingThirdBit
{
    class FindingThirdBit
    {
        static void Main()
        {
            Console.Write("Please enter some number: ");
            int num = int.Parse(Console.ReadLine());

            int mask = 8;
            int addMask = num & mask;

            int bit = addMask << 3;

            if (bit != 0)
            {
                Console.WriteLine("The third bit in your number is: 0");
            }
            else
            {
                Console.WriteLine("The third bit in your number is: 1");
            }
        }
    }
}
