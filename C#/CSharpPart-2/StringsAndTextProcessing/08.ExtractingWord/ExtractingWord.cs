
//Task 8- Write a program that extracts from a given text all sentences containing given word.
// 		  Example: The word is "in". The text is:
//        We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
//        So we are drinking all the day. We will move out of it in 5 days.

//        The expected result is:
//        We are living in a yellow submarine.
//        We will move out of it in 5 days.
//        Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractingWord
{
    class ExtractingWord
    {
        static void Main()
        {
            string text = " We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] sentences = text.Split('.');

            string word = "in";

            foreach (var sentence in sentences)
            {
                string trimmedSentence = sentence.Trim();
                string[] splitedSentence = new string[word.Length];
                splitedSentence = trimmedSentence.Split(' ', ',', '.', ';', ':', '!', '?', '(', ')');

                foreach (string w in splitedSentence)
                {
                    if (string.Compare(w, word, true) == 0)
                    {
                        Console.WriteLine("{0}.", trimmedSentence);
                    }
                }
            }

        Console.WriteLine();
        }

    }
}
