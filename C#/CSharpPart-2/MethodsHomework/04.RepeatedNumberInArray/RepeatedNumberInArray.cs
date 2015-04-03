
//Task 4- Write a method that counts how many times given number appears in given array.
//        Write a test program to check if the method is working correctly.

using System;

namespace _04.RepeatedNumberInArray
{
    class RepeatedNumberInArray
    {
        static int RepeatedNumber(int[] arr,int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
   
            return count;
        }
        static void Main()
        {
            Console.Write("Enter searched number: ");
            int number = int.Parse(Console.ReadLine());
            //Console.Write("Enter the length of the array: ");
            //int len = int.Parse(Console.ReadLine());
            //int[] arr = new int[len];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter {0} element: ",i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            int[] arr = { 1, 2, 8, 9, 15, 3, 2, 6, 8, 8, 1 };

            Console.WriteLine("The searched number is repeated: {0}",RepeatedNumber(arr,number));

            
        }
    }
}
