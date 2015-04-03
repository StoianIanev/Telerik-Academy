
// Task 2- Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end]. 
//         If an invalid number or non-number text is entered, the method should throw an exception.
//         Using this method write a program that enters 10 numbers:
//         a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadNumber
{
    class ReadNumber
    {
        static int num = 1;

        static void Main()
        {
            int start = 1;
            int end = 100;
            Console.WriteLine("Enter 10 integer numbers: ");

            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    ReadNumbers(start, end, number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your number is not valid!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Your number is not in the limits!");
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
            }
        }
        static void ReadNumbers(int start, int end,int number)
        {  
                if (number > start && number < end && number > num )
                {
                   num = number;
                   Console.WriteLine("You entered correctly number");
                }
                else
                {
                    Console.WriteLine("You entered Incorrectly number");
                }
                
              
        }
    }
}
