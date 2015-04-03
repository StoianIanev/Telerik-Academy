
//Task 11- Write a program that finds the index of given element in a sorted 
//         array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

namespace _11.BinarySearchInArray
{
    class BinarySearchInArray
    {
        static void Main()
        {
            //int[] arr = { 4, 3, 1, 4, 2, 5, 8}; 

            Console.Write("Enter the sought element: ");
            int element = int.Parse(Console.ReadLine());

            Console.Write("Please enter the length of the array: ");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The searched element is located at position: {0}", FindElement(arr, element));

        }

        static int FindElement(int[] array,int num)
        {
            Array.Sort(array);
            int max = array.Length - 1;
            int min = 0;
           
            while (max>= min)
            {
                int iMidpoint = (min + max) / 2;
                if (num > array[iMidpoint])
                {
                    min = iMidpoint + 1;
                }
                else if (array[iMidpoint] > num)
                {
                    max = iMidpoint - 1;
                }
                else
                {
                    return iMidpoint;
                }
                
            }
            return -1;
        }
       
    }
}
