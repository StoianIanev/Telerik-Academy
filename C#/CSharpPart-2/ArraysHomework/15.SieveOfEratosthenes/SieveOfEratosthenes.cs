
//Task 15- Write a program that finds all prime numbers in the range [1...10 000 000]. 
//         Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

namespace _15.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            bool[] arr = new bool[10000000];
            int j ;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = true;

            }
            for (int i = 2; i < Math.Sqrt(arr.Length); i++)
            {
                if (arr[i] == true)
                {
                    j = i * i;
                    while (j < arr.Length)
                    {
                        arr[j] = false;
                        j += i;
                       
                    }
                }

            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write("{0} ",i);
                }
            }


        }
    }
}
