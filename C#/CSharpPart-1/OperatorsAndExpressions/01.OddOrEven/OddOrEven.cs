
//Task- Write an expression that checks if given integer is odd or even.

using System;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Please enter some number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2==0)
            {
                Console.WriteLine("Your number {0} is even!",num);
            }
            else
            {
                Console.WriteLine("Your number {0} is odd!",num);
            }
        }
    }
}
