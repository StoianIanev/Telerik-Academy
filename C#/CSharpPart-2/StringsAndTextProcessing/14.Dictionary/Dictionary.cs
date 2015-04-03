
// Task 14- A dictionary is stored as a sequence of text lines containing words and their explanations.
//          Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//         .NET – platform for applications from Microsoft
//          CLR – managed execution environment for .NET
//          namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main()
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            Dictionary<string, string> words = new Dictionary<string, string>();
                words[".NET"] = "platform for applications from Microsoft";
                words["CLR"] = "managed execution environment for .NET";
                words["namespace"] = "hierarchical organization of classes";
                try
                {
                    string result = words[word];
                    Console.WriteLine("The word {0} means- {1}",word,result);
                }
                catch (KeyNotFoundException)
                {

                    Console.WriteLine("The word {0} is not found in the dictionary!",word);
                }
        }
    }
}
