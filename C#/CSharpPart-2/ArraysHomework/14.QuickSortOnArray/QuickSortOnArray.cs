
//Task 14- Write a program that sorts an array of strings using 
//         the quick sort algorithm (find it in Wikipedia).

using System;

namespace _14.QuickSortOnArray
{
    class QuickSortOnArray
    {
        static void Main()
        {
            string[] arr = {"x","y","w","a","c"};

            //Console.Write("Please enter the length of the array: ");
            //int l = int.Parse(Console.ReadLine());
            //string[] arr = new string[l];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter {0} element of array: ", i);
            //    arr[i] = Console.ReadLine();
            //}

           QuickSort(arr, 0, arr.Length - 1);
           PrintArray(arr);

        }

        static void QuickSort(string[] arr, int left, int right)
        {

            int p = right;
            int i = left;
            string pivot = arr[(left+right) / 2];

            while (p >= i)
            {
                while (arr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (arr[p].CompareTo(pivot) > 0)
                {
                    p--;
                    
                }
                if (i <= p)
                {
                    string temp = arr[i];
                    arr[i] = arr[p];
                    arr[p] = temp;

                    i++;
                    p--;
                }

            }
            if (left < p)
            {
                QuickSort(arr, left, p);
            }

            if (i < right)
            {
                QuickSort(arr, i, right);
            }

         
        }

        static void PrintArray(string[] arr)
        {
            Console.Write("The sorted array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
