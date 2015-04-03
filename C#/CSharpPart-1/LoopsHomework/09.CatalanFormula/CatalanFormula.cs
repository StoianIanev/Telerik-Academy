
//Task 9- In the combinatorial mathematics, the Catalan numbers are calculated 
//        by the following formula: (2n)! / (n + 1)! * n!
//        Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

namespace _09.CatalanFormula
{
    class CatalanFormula
    {
        static void Main()
        {
            Console.Write("Enter number N: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
	        {
                BigInteger firstFact = 1;
                BigInteger secondFact = 1;
                BigInteger thirdFact = 1;
             

                for (int j = 2 * n; j > 1; j--)
                {
                    firstFact *= j;
                }
                for (int m = n + 1; m > 1; m--)
                {
                    secondFact *= m;
                }
                for (int i = 1; i <= n; i++)
                {
                    thirdFact *= i;
                }

                BigInteger result = firstFact / (secondFact * thirdFact);
                
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
