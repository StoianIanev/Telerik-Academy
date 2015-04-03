
//Task 4- Write an expression that checks for given integer 
//  if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

namespace _04.CheckOnThirdDigit
{
    class CheckOnThirdDigit
    {
        static void Main()
        {
            Console.Write("Please enter some number: ");
            int num = int.Parse(Console.ReadLine());

            int secondNum = num / 100;
            Console.WriteLine(secondNum);

            bool digit = secondNum % 10 == 7;

            Console.WriteLine("Are the third digit is 7: {0}",digit);
        }
    }
}
