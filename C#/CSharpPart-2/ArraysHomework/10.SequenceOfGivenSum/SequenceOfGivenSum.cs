
//Task 10- Write a program that finds in given array of integers a sequence 
//         of given sum S (if present). 
//         Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 
using System;

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main()
        {
            Console.Write("Enter sum: ");
            int S = int.Parse(Console.ReadLine());
            int sum = 0;
            int startPosition;
            int endPosition;

            //int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
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
                sum = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == S)
                    {
                        startPosition = i;
                        endPosition = j;
                        for (int m = startPosition; m <= endPosition; m++)
                        {
                            Console.Write("{0} ",arr[m]);
                        }
                        Console.WriteLine();
                        break;
                        
                    }
                    else if(sum > S)
                    {
                        sum = 0;
                        break;
                    }

                }

            }
            if (sum == 0 )
            {
                Console.WriteLine("The sum is not present in this array!");
            }
           
        }
    }
}
