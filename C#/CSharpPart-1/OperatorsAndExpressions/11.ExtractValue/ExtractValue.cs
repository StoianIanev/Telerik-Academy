
//Task 11- Write an expression that extracts from a given integer i the value of a given bit number b. 
//         Example: i=5; b=2  value=1.


using System;

namespace _11.ExtractValue
{
    class ExtractValue
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int b = int.Parse(Console.ReadLine());

            int mask = 1 << b;
            int number = mask & i;

            int theBit = number >> b;

            Console.WriteLine("Bit on position {0} is: {1}", b, number != 0 ? "1" : "0");
            
        }
    }
}
