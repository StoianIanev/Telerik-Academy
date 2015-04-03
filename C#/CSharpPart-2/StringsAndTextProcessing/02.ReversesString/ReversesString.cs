
//Task 2- Write a program that reads a string, reverses it and prints the result at the console.
//       Example: "sample"  "elpmas".

using System;
using System.Text;

namespace _02.ReversesString
{
    class ReversesString
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string reverse = ReverseString(str);
            Console.WriteLine("Original string is: {0}",str);
            Console.WriteLine("Reversed string is: {0}",reverse);
            
        }

        private static string ReverseString(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = word.Length-1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
        }
    }
}
