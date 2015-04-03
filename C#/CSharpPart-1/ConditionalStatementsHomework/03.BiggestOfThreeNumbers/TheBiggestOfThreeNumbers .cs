
//Task 3- Write a program that finds the biggest of three integers 
//         using nested if statements.

using System;

namespace _03.TheBiggestOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int bigNum = a;

            if (bigNum < b )
            {
                bigNum = b;
            }
            if (bigNum < c)
            {
                bigNum = c;
            }
            Console.WriteLine("The biggerst of the three numbers is: {0}", bigNum);
           
                
        }
    }
}
