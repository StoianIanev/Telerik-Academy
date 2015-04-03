
//Task 7- Write an expression that checks if given positive integer number n (n ≤ 100) 
//        is prime. E.g. 37 is prime.

using System;

namespace _07.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            Console.Write("Please enter some psitive number from 1 to 100: ");
            int num = int.Parse(Console.ReadLine());

           
            if ((num == 2) || (num==3) || (num==5) || (num==7))
            {
                Console.WriteLine("The number is prime");
            }
            else if ((num % 2)==0 || (num %3)==0 || (num % 5)==0 || (num % 7)==0)
            {
                Console.WriteLine("The number is not prime");
            }
            else
            {
                Console.WriteLine("The number is prime");
            }

        }
    }
}
