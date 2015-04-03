
//Task 20- Write a program that reads two numbers N and K and generates 
//         all the variations of K elements from the set [1..N]. Example:
//         N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

namespace _20.Variations
{
    class Variations
    {
        static void Main()
        {
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            GeneratesAllTheVariations(arr,0,n);

        }

        static void GeneratesAllTheVariations(int[] arr, int index,int n)
        {

              if (index == arr.Length)
                {
                    PrintArray(arr);

                }
                else
                {
                    for (int i = 1; i <= n ; i++)
                    {
                        arr[index] = i;
                        GeneratesAllTheVariations(arr, index + 1, n);
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
