
// Task 2 - Which of the following values can be assigned to a variable of type float 
//  and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 
using System;

namespace _02.FloatAndDouble
{
    class FloatAndDouble
    {
        static void Main()
        {
            double d = 34.567839023;
            float f = 12.345f;
            double de = 8923.1234857;
            float ft = 3456.091f;

            Console.WriteLine("Double: {0}; {1}",d,de);
            Console.WriteLine();
            Console.WriteLine("Float: {0}; {1}", f, ft);
            Console.WriteLine();
        }
    }
}
