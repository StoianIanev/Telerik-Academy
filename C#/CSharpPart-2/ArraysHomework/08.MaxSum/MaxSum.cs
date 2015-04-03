
//Task 8- Write a program that finds the sequence of maximal sum in given array. 
//        Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}

using System;

namespace _08.MaxSum
{
    class MaxSum
    {

        static void Main()
        {
            //int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            Console.Write("Please enter the length of the array: ");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
     
            int maxTemp = int.MinValue;
            int maxEnd = 0;
            int start = 0;
            int startTemp = 0;
            int end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxEnd += arr[i];
                if (arr[i] > maxEnd)
                {
                    maxEnd = arr[i];
                    startTemp = i;
                }
                if (maxEnd > maxTemp)
                {
                    maxTemp = maxEnd;
                    start = startTemp;
                    end = i;
                }
            }
            Console.WriteLine("Max sum is: {0}",maxTemp);
        }
    }
}
