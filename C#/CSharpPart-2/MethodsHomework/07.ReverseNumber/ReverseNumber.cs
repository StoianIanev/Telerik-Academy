
//Task 7- Write a method that reverses the digits of given decimal number. 
//        Example: 256  652

using System;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static int ReverseOfNumber(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num = num / 10;
            }

            return result;
        }
        static void Main()
        {
            Console.Write("Enter the number that you want to reverse: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseOfNumber(num));

        }
    }
}
