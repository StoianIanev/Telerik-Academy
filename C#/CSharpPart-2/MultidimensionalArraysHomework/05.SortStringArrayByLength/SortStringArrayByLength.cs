
//Task 5 - You are given an array of strings. 
//         Write a method that sorts the array by the length of its elements 
//         (the number of characters composing them).

using System;

namespace _05.SortStringArrayByLength
{
    class SortStringArrayByLength
    {
        static void Main()
        {
            string[] stringArray = { "ha", "fifi", "ho", "hi" };
            SortArray(stringArray);
        }
        static void SortArray(string[] stringArray)
        {
            int n = stringArray.Length;
            int[] size = new int[n];

            for (int i = 0; i < stringArray.Length; i++)
            {
                size[i] = stringArray[i].Length;
            }

            Array.Sort(size, stringArray);

            foreach (string str in stringArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

        }
    }
}
