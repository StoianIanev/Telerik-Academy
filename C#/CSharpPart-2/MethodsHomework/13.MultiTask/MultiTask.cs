
//Task 13- Write a program that can solve these tasks:

//       - Reverses the digits of a number
//       - Calculates the average of a sequence of integers
//       - Solves a linear equation a * x + b = 0

//       Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//      - The decimal number should be non-negative
//      - The sequence should not be empty
//      - a should not be equal to 0

using System;

namespace _13.MultiTask
{
    class MultiTask
    {

        static int ReverseNumber(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num = num / 10;
            }

            return result;
        }
        static decimal AverageOfNumber(int[] arr)
        {
            decimal sum = 0m;
            decimal average = 0m;
           
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            
            return average = sum / arr.Length;

        }

        static decimal LinearEquation(decimal a, decimal b)
        {
            decimal result = (b * (-1) / a);
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Which task you want to solve: ");
            Console.WriteLine("1. Reverses the digits of a number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");
            Console.Write("You chose: ");
            int chose = int.Parse(Console.ReadLine());

            if (chose == 1)
            {
                Console.Write("Enter the number that you want to reverse: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                       Console.WriteLine("Negative number!");
                }
                else
	            {
                    Console.WriteLine("The reversed number is: {0}",ReverseNumber(num));
	            }
                
            }
            else if (chose == 2)
            {
                Console.Write("How number you will enter: ");
                int len = int.Parse(Console.ReadLine());
                if (len == 0)
                {
                    Console.WriteLine("Empty sequence!");
                }
                else
                {
                    int[] arr = new int[len];
                    Console.WriteLine("Enter your number: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("The average of {0} number is: {1}",len,AverageOfNumber(arr));
                }
                
            }
            else if (chose == 3)
            {
                Console.Write("Enter the coefficient a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the coefficient b:");
                int b = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Invalid coefficient a !");
                }
                else
                {
                    Console.WriteLine("x = {0}",LinearEquation(a, b));
                }

            }
            else
            {
                Console.WriteLine("Error!");
            }


        }
    }
}
