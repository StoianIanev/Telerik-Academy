
//Task 23- Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
//         Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ReplaceConsecutiveLetters
{
    class ReplaceConsecutiveLetters
    {
        static void Main()
        {
            //Console.Write("Enter string: ");
            //string str = Console.ReadLine();

            string str = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] != str[i+1])
                {
                    sb.Append(str[i]);
                }
            }
            sb.Append(str[str.Length - 1]);
            Console.WriteLine(sb.ToString());

        }
    }
}
