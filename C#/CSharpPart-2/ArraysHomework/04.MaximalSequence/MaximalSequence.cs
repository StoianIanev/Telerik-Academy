
//Task 4- Write a program that finds the maximal sequence of equal elements in an array.
//        Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

namespace _04.MaximalSequence
{
    class MaximalSequence 
    {
        static void Main()
        {
            //int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            Console.Write("Please enter the length of the array: ");
            int l = int.Parse(Console.ReadLine());
            int[] arr = new int[l];
            int len = 1;
            int start = 0;
            int bestLen = 1;
            int bestStart = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array: ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    start = arr[i+1];
                    len++;

                }
                else
                {
                    len = 1;
                    start = i + 1;
                    
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            Console.Write("{");
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestStart + " ");
                
            }
            Console.Write("}");
           


        }
    }
}
