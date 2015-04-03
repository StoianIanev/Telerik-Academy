
//Task 7- Write a program that finds the greatest of given 5 variables.

using System;

namespace _07.TheGreatestNumberOfFiveVariables
{
    class TheGreatestNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int e = int.Parse(Console.ReadLine());
            
            int bigNum = a;

            if (bigNum < b)
            {
                bigNum = b;
            }
            if (bigNum < c)
            {
                bigNum = c;
            }
            if (bigNum < d)
            {
                bigNum = d;
            }
            if (bigNum < e)
            {
                bigNum = e;
            }

            Console.WriteLine("The greatest number of five variables is: {0}",bigNum);
            



        }
    }
}
