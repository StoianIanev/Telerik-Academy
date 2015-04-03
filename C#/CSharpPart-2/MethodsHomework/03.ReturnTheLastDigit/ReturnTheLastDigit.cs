
//Task 3- Write a method that returns the last digit of given integer as an English word. 
//        Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

namespace _03.ReturnTheLastDigit
{
    class ReturnTheLastDigit
    {
        static void GetLastNumber(int number)
        {
            int rest = number % 10;
            switch (rest)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

        }
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            GetLastNumber(number);
        }
    }
}
