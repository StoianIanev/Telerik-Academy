
//Task 1- Write a program that reads 3 integer numbers from the console 
//        and prints their sum.

using System;

namespace _01.SumOfTheThreeNumbers
{
    class SumOfTheThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers:");
            Console.Write("First: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Second: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Third: ");
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of three numbers is: {0} + {1} + {2} = {3}",firstNum,secondNum,thirdNum,firstNum+secondNum+thirdNum);


        }
    }
}
