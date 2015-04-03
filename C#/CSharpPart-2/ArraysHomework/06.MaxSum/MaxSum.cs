
//Task 6- Write a program that reads two integer numbers N and K and an array of N elements 
//       from the console. Find in the array those K elements that have maximal sum.

using System;

namespace _06.MaxSum
{
    class MaxSum
    {
        static void Main()
        {
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int max = int.MinValue;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n-k; i++)
            {
                for (int j = i; j < k+i; j++)
                {
                    sum +=  arr[j];
                }
                if (sum > max)
                {
                    max = sum;
                    index = i;
                }
                sum = 0;
            }
            for (int i = index; i < index + k; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
