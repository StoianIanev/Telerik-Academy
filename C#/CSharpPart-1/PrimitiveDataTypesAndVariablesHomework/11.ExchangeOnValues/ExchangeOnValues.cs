
// Task 11 - Declare two integer variables and assign them with 5 and 10 
//          and after that exchange their values.

using System;

namespace _11.ExchangeOnValues
{
    class ExchangeOnValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("The old values are: {0} {1}",a,b);

            int c;
            c = b;
            b = a;
            a = c;
            Console.WriteLine("The new values are: {0} {1}", a, b);


        }
    }
}
