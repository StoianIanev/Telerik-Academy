
// Task 3 - Write a program that safely compares floating-point numbers 
//         with precision of 0.000001. 
//        Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

namespace _03.FloatingPointNumbers
{
    class FloatingPointNumbers 
    {
        static void Main()
        {
            float a = 5.3f;
            float b = 6.01f;
            Console.WriteLine(a==b);

            float num = 5.00000001f;
            float number = 5.00000003f;
            Console.WriteLine(num==number);
        }
    }
}
