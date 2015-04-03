
//Task 7- Sorting an array means to arrange its elements in increasing order. 
//        Write a program to sort an array. Use the "selection sort" algorithm: 
///       Find the smallest element, move it at the first position, find the smallest from 
///       the rest, move it at the second position, etc.

using System;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            //int[] arr = { 3, 2, 3, 4, 2, 2, 4 };
            Console.Write("Please enter the length of the array: ");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                   
                }
                
            }

            Console.WriteLine(string.Join(",", arr));
          
        }
    }
}
