
//Task 9- Write a program that finds the most frequent number in an array. 
//        Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

namespace _09.MostFrequentNumberInArray
{
    class MostFrequentNumberInArray
    {
        static void Main()
        {
            //int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Console.Write("Please enter the length of the array: ");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int n = int.MinValue;
            int len;
            int bestLen = 1;

            for (int i = 0; i < arr.Length-1; i++)
            {
                len = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        n = arr[i];
                        len++;
                    }
                    if (len > bestLen)
                    {
                        bestLen = len;
                    }
                }
            }
            Console.WriteLine("Most frequent element in aray is: {0} ({1} times)",n,bestLen);

        }
    }
}
