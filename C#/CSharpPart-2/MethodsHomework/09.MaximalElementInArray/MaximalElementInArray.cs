
//Task 9- Write a method that return the maximal element in a portion of array of integers 
//        starting at given index. Using it write another method that sorts an array in 
//        ascending / descending order.

using System;

namespace _09.MaximalElementInArray
{
    class MaximalElementInArray
    {

        static int FindBiggestNumFromGivenIndex(int[] arr,int position)
        {
            int bigNum = 0;
            for (int i = position; i < arr.Length; i++)
            {
                if (arr[i] > bigNum)
                {
                    bigNum = arr[i];
                }
            }
            return bigNum;
        }
       

        static void SortOnArray(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                   
                }
            }
            PrintArray(arr);
            
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        static void Main()
        {
            int[] arr = { 3, 2, 3, 4, 2, 2, 4 };

            //Console.Write("Enter the length of the array: ");
            //int len = int.Parse(Console.ReadLine());
            //int[] arr = new int[len];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter {0} element: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            Console.Write("Enter a position: ");
            int position = int.Parse(Console.ReadLine());
            if (position < arr.Length)
            {
                Console.WriteLine("The bigerst number is : {0}", FindBiggestNumFromGivenIndex(arr, position));
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }

            Console.Write("The sorted array is: ");
            SortOnArray(arr);
        }
    }
}
