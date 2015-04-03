
// Task 13 - Create a program that assigns null values to an integer and to double variables. 
// Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

namespace _13.IntegerAndDouble
{
    class Program
    {
        static void Main()
        {
            int? i = null;
            double? d = null;
            Console.WriteLine(i);
            Console.WriteLine(d);

            i = 5;
            d = 1.2234;

            Console.WriteLine(i);
            Console.WriteLine(d);


        }
    }
}
