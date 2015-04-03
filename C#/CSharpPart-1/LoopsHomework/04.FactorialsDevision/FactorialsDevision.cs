
//Task 4- Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

namespace _04.FactorialsDevision
{
    class FactorialsDevision
    {
        static void Main()
        {
            Console.Write("Enter N (where  K < N): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K (where 1 < K < N): ");
            int k = int.Parse(Console.ReadLine());

            BigInteger product = 1;
            
            if (k <= n)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    product = product * i;
                }
               

                Console.WriteLine("N!/K! = {0}", product);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }

        }
    }
}
