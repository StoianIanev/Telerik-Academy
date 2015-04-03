
//Task- Write a boolean expression that checks for given integer 
// if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

namespace _02.DividedByFiveAndSeven
{
    class DividedByFiveAndSeven
    {
        static void Main()
        {
            Console.Write("Please enter some number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 35 == 0) // to divide a number of five and seven in the same time, we have to find Greatest Common Divisor on two numbers and it is 35 (7 * 5 = 35)
            {
                Console.WriteLine("Your number {0} divided by five and seven!", num);  
            }
            else
            {
                Console.WriteLine("Your number {0} not divided by five and seven!", num);
            }

                              //Second Form
            //bool div = num % 35 == 0;
            //Console.WriteLine("Are your number {0} divided by five and seven: {1} ",num,div);
        }
    }
}
