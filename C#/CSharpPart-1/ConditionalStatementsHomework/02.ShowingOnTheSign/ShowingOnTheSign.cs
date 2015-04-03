
//Task 2- Write a program that shows the sign (+ or -) of the product of three real numbers 
//        without calculating it. Use a sequence of if statements.


using System;

namespace _02.ShowingOnTheSign
{
    class ShowingOnTheSign
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            int count = 0;


            if (Math.Sign(a)  == -1)
            {
                count++;
            }
            if (Math.Sign(b) == -1)
            {
                count++;
            }
            if (Math.Sign(c)  == -1)
            {
                count++;
            }
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product of three numbers is Zero!");

            }
            else if (count % 2 == 0)
            {
                Console.WriteLine("The product of three numbers is positive!");
            }
            else
            {
                Console.WriteLine("The product of three numbers is negative!");
            }

        }
    }
}
