
//Task 5- Write a method that checks if the element at given position in given array of 
//        integers is bigger than its two neighbors (when such exist).

using System;

namespace _05.BiggerThanTwoNeighbors
{
    class ElementInArray
    {

        static void FirstBiggerThanNeighbors(int[] arr,int position)
        {
            bool b = true;

            if (position < 0 || position > arr.Length-1)
            {
                Console.WriteLine("Wrong position!");
            }
            else
            {
                if (position == 0)
                {
                    Console.WriteLine("Are the {0} element is bigger than its neighbors: {1}",position,b = arr[0] > arr[1]);
                }
                else if (position == arr.Length-1)
                {
                    Console.WriteLine("Are the {0} element is bigger than its neighbors: {1}",position,b = arr[arr.Length - 1] > arr[arr.Length - 2]);
                }
                else
                {
                    Console.WriteLine("Are the {0} element is bigger than its neighbors: {1}",position,b = arr[position] > arr[position - 1] && arr[position] > arr[position + 1]);
                }
            }


            
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
