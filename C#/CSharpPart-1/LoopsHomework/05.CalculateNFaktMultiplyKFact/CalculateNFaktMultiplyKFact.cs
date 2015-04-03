
//Task 5- Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics; 

namespace _05.CalculateNFaktMultiplyKFact
{
    class CalculateNFaktMultiplyKFact
    {
        static void Main()
        {
            Console.Write("Enter K (where  N < K): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter N (where 1 < N < K): ");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorielSub = 1;
            BigInteger factorielN = 1;

            if (k > n && n > 1 && k > 1)
            {
                for (int i = n; i > 0; i--)
                {
                    factorielN *= i;
                }
                for (int j = 0; j <= (n-1); j++)
                {
                    factorielSub *= (k-j);
                }

                Console.WriteLine("N!*K! / (K-N) is {0}",factorielN*factorielSub);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
