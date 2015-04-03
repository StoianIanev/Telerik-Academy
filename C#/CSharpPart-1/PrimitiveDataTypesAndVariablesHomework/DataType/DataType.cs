
// Task 1 - Declare five variables choosing for each of them the most appropriate 
//     of the types byte, sbyte, short, ushort, int, uint, long, ulong 
//     to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

namespace DataType
{
    class DataType
    {
        static void Main()
        {
            sbyte sb = -115;
            byte by = 97;
            short sh = -10000;
            ushort ush = 52130;
            int it = 4825932;

            Console.WriteLine("{0}; {1}; {2}; {3}; {4}",sb,by,sh,ush,it);
        }
    }
}
