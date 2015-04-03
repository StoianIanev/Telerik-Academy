
//Task 13- Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReversesTheWords
{
    class Program
    {
        static void Main()
        {
            string tex = "C# is not C++, not PHP and not Delphi!";
            string[] words = tex.Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string[] sign = tex.Split(words, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i] + sign[i]);
            }
            
            Console.WriteLine(sb.ToString());
        }
     
        }
    }

