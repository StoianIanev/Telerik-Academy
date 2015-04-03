
//Task 4- Write a program that reads two positive integer numbers and prints how many numbers p exist between 
//        them such that the reminder of the division by 5 is 0 (inclusive). 
//         Example: p(17,25) = 2.

using System;

namespace _04.TwoNumbers
{
    class TwoNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers- first number > second number");
            Console.Write("First number: " );
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            //int count = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    //count++;

                }
            }
            //Console.WriteLine("The number between {0} and {1} which divide by 5 are: {2}",firstNum,secondNum,count);


        }

    }
}
