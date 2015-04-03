
//Task 6- Write a method that returns the index of the first element in array 
//        that is bigger than its neighbors, or -1, if there’s no such element.
//        Use the method from the previous exercise.

using System;

namespace _06.FirstElBigerThenNeigbors
{
    class FirstElBigerThenNeigbors
    {
        static int FirstBiggerThanNeighbors(int[] arr,int position)
        {

            int indexOfFirst = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    indexOfFirst = i;
                    break;
                }
                else
                {
                    indexOfFirst = -1;
                }
            }
            return indexOfFirst;
            
        }
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //int[] arr = { 1, 2, 8, 9, 15, 3, 2, 6, 8, 8, 1 };

            Console.Write("Enter position of element: ");
            int position = int.Parse(Console.ReadLine());

            FirstBiggerThanNeighbors(arr,position);
        }
    }
}
