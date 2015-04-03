
// Task 12* - Write a program to read your age from the console and print 
//            how old you will be after 10 years.

using System;

namespace AfterTenYears
{
    class AfterTenYears
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("After Ten years you will be {0} old.", age + 10);
        }
    }
}
