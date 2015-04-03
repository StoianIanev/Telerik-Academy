
//Task 1- Write an if statement that examines two integer variables 
//        and exchanges their values if the first one is greater than the second one.

using System;

namespace _01.ExchangeOnValue
{
    class ExchangeOnValue
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int newNum;

            if (firstNum > secondNum)
            {
                newNum = secondNum;
                secondNum = firstNum;

                Console.WriteLine("The first number is  greater than the second number!");
                Console.WriteLine("The first number is now: {0} and the second number is: {1}", newNum, secondNum);
            }
            else
            {
                Console.WriteLine("The first number is not greater than the second number!");
                Console.WriteLine("{0} {1}",firstNum,secondNum);
            }
            
        }
    }
}
