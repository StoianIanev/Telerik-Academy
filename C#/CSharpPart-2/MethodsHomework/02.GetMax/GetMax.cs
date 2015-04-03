
//Task 2- Write a method GetMax() with two parameters that returns the bigger of two integers. 
//        Write a program that reads 3 integers from the console and prints 
//        the biggest of them using the method GetMax().

using System;

namespace _02.GetMax
{
    class GetMax
    {
        static int GetMaxNum(int firstNum,int secondNum)
        {
            int max = firstNum;
            if (max < secondNum)
            {
                max = secondNum;
            }

            return max;
        }
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            int tempBig = GetMaxNum(firstNum, secondNum);

            Console.WriteLine("The biggest number is: {0}",GetMaxNum(tempBig,thirdNum));
        }
    }
}
