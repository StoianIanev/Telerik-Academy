
//Task 5- Write a program that finds the maximal increasing sequence in an array. 
//        Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;
using System.Collections.Generic;

namespace _05.MaximumIncreasingSequence
{
    class MaximumIncreasingSequence
    {
        static void Main()
        {
            //int[] arr = { 3, 2, 3, 4, 2, 2, 4 };
            Console.Write("Please enter the length of the array: ");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];
           
            int len = 1;
            int count = 0;
            int start = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i+1])
                {
                    
                    len++;
                    
                }
                else
                {
                    len = 1;
                    
                }
                if (count < len)
                {
                    count = len;
                    start = arr[i] + 1;
                }
          
            }
            for (int i = count-1; i >= 0; i--)
            {
                Console.Write(start - i + " ");

            }
            Console.WriteLine();
 
        }
        

    }
}
