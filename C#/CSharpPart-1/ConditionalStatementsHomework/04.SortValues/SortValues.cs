
//Task 4- Sort 3 real values in descending order using nested if statements.

using System;

namespace _04.SortValues
{
    class SortValues
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int temp = 0;

            if (b > a)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (c > a)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (c > b)
            {
                temp = c;
                c = b;
                b = temp;
            }
            Console.WriteLine("The sort numbers are: {0}, {1}, {2}", a, b, c);


        }
    }
}
