
// Task 1- Write a program that reads an integer number and calculates and prints its square root. 
//         If the number is invalid or negative, print "Invalid number". 
//         In all cases finally print "Good bye". Use try-catch-finally.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number: ");
                double number = int.Parse(Console.ReadLine());
                double num = Math.Sqrt(number);
                Console.WriteLine("The square root of the number {0} is: {1}",number,num);

            }
            catch (OverflowException)
            {
                Console.WriteLine("The input number is too big or too small!");
            }
            catch (ArithmeticException)
            {

                Console.WriteLine("Invalid number! The square root is defined only for non-negative numbers! ");
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("Invalid number!" + formatException.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
