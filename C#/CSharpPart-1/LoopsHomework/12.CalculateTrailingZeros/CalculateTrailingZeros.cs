
//Task 12- * Write a program that calculates for given N how many trailing zeros present 
//           at the end of the number N!. Examples:
//	N = 10  N! = 3628800  2
//	N = 20  N! = 2432902008176640000  4
//	Does your program work for N = 50 000?
//	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!


using System;
using System.Numerics;

namespace _12.CalculateTrailingZeros
{
    class CalculateTrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger fact = 1;
            int sum = 0;
            int pow = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                if (fact % 5 == 0)
                {
                    sum = sum + (n / (int)(Math.Pow(5,pow)));
                    pow++;
                }

            }
            
            Console.WriteLine("Trailing zeros on the number (!N) - {0} are: {1}",fact,sum);

        }
    }
}
