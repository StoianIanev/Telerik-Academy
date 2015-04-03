
//Task 21- Write a program that reads two numbers N and K and generates 
//         all the combinations of K distinct elements from the set [1..N]. Example:
//         N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

namespace _21.Combination
{
    class Combination
    {
        static void Main()
        {
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            GeneratesAllTheCombination(arr, 0,1, n);

        }
        static void GeneratesAllTheCombination(int[] arr, int index,int currentNum, int n)
        {
              if (index == arr.Length)
                {
                    PrintArray(arr);

                }
                else
                {
                    for (int i = currentNum; i <= n ; i++)
                    {
                        arr[index] = i;
                        GeneratesAllTheCombination(arr, index + 1,i + 1, n);
                    }
                   
                }
            
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    

    }
}
