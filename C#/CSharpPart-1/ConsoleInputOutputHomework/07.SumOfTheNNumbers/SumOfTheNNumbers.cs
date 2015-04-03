
//Task 7- Write a program that gets a number n and after that gets more n numbers and 
//        calculates and prints their sum. 

using System;

namespace _07.SumOfTheNNumbers
{
    class SumOfTheNNumbers
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Please enter the next number n{0} ", i);
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("The sum of this {0} numbers is: {1}",n,sum);
        }
    }
}
