
//Task 8- Write a method that adds two positive integer numbers 
//        represented as arrays of digits (each array element arr[i] contains a digit; 
//        the last digit is kept in arr[0]). Each of the numbers 
//        that will be added could have up to 10 000 digits.

using System;
using System.Numerics;
using System.Collections.Generic;

namespace _08.AddTwoPositiveNumber
{
    class AddTwoPositiveNumber
    {
        static void Main()
        {
            int[] firstArr = { 1, 1, 2, 3, 8, 9, 6 };
            int[] secondArr = { 9, 3, 3, 8, 9 };

            //Console.Write("Enter the length of first array: ");
            //int firstLen = int.Parse(Console.ReadLine());
            //int[] firstArr = new int[firstLen];
            //Console.Write("Enter the length of second array: ");
            // int secondLen = int.Parse(Console.ReadLine());
            //int[] secondArr = new int[secondLen];

            //Console.WriteLine("Enter the elements of first array:");
            //for (int i = 0; i < firstArr.Length; i++)
            //{
            //    firstArr[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < secondArr.Length; i++)
            //{
            //    secondArr[i] = int.Parse(Console.ReadLine());

            //}

            SumOfArray(firstArr, secondArr);
        }
        static void SumOfArray(int[] arr1, int[] arr2)
        {
            Array.Reverse(arr1);
            Array.Reverse(arr2);
           int maxLen = Math.Max(arr1.Length,arr2.Length);
            BigInteger sum = 0;
            int p = 0;
            int len = 0;
            int biggerArray = 0;
            int[]  result = new int[maxLen];

            if (arr1.Length > arr2.Length)
            {
                len = arr2.Length;
                biggerArray = 1;
            }
            else
            {
                len = arr1.Length;
                biggerArray = 2;
            }

            for (int i = 0; i < len; i++)
            {
                if (arr1[i] + arr2[i] + p > 9)
                {
                    result[i] = ((arr1[i] + arr2[i]) + p) % 10;
                    p = (arr1[i] + arr2[i]) / 10;
                   
                }
                else
                {
                    result[i] = arr1[i] + arr2[i] + p;
                    p = 0;
                }
                
            }
            for (int i = len; i < result.Length; i++)
            {
                if (biggerArray == 1)
                {
                     result[i] = arr1[i] + p;
                     p = 0;

                }
                else
                {
                    result[i] = arr2[i] + p;
                    p = 0;
                }

            }
            Array.Reverse(result);
            Console.WriteLine(string.Join(" ",result));

        }
       
    }
}
