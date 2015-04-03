
//Task 13- Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

namespace _13.ExchangesBits
{
    class ExchangesBits
    {

        static int GetTheBit(uint n, int position)
        {
            uint pthBit = (n >> position) & 1;
            return (int)pthBit;


        }
        static uint SetTheBit(uint n, int position, int bit)
        {
            uint mask = (uint)bit << position;
            n = n & (~((uint)1 << position));
            uint result = n | mask;
            return result;

        }

        static void Main()
        {
            Console.Write("Enter some number: ");
            uint n = uint.Parse(Console.ReadLine());


            int bitAtPosition3 = GetTheBit(n, 3);
            int bitAtPosition4 = GetTheBit(n, 4);
            int bitAtPosition5 = GetTheBit(n, 5);
            int bitAtPosition24 = GetTheBit(n, 24);
            int bitAtPosition25 = GetTheBit(n, 25);
            int bitAtPosition26 = GetTheBit(n, 26);


            n = SetTheBit(n, 3, bitAtPosition24);
            n = SetTheBit(n, 4, bitAtPosition25);
            n = SetTheBit(n, 5, bitAtPosition26);
            n = SetTheBit(n, 24, bitAtPosition3);
            n = SetTheBit(n, 25, bitAtPosition4);
            n = SetTheBit(n, 26, bitAtPosition5);

            Console.WriteLine(n);
        }
    }
}
