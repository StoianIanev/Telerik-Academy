
// Task 19- Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//          Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _19.ExtractDates
{
    class ExtractDates
    {
        static void Main()
        {
            string text = "I was  born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
            string[] words = text.Split(' ',',','!','?');

            foreach (var word in words)
            {
                try
                {
                    if (word[word.Length-1] == '.')
                    {
                        string wordNotDot = word.Substring(0, word.Length - 1);
                        DateTime parsedDate = DateTime.ParseExact(wordNotDot,"d.M.yyyy",CultureInfo.InvariantCulture);
                        string date = parsedDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Console.WriteLine(date);
                    }
                    else
                    {
                        DateTime parsedDate = DateTime.ParseExact(word, "d.M.yyyy", CultureInfo.InvariantCulture);
                        string date = parsedDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Console.WriteLine(date);
                    }
                  
                }
                catch (Exception)
                { 
                }
            }
           
        }
    }
}
