
//Task 5- Write a program that gets two numbers from the console and prints the greater of them. 
//         Don’t use if statements.

using System;

namespace _05.GreatestNumber
{
    class GreatestNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is: {0}",Math.Max(firstNum,secondNum));
            Console.WriteLine("The smaller number is: {0}", Math.Min(firstNum, secondNum));
        }
    }
}
