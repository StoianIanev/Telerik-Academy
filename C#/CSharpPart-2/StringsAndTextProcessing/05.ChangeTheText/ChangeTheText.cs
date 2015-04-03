
//Task 5- You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
//        The tags cannot be nested. Example:
//        We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//        The expected result:
//        We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChangeTheText
{
    class ChangeTheText
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string firstKeyword = ">";
            string secondKeyword = "<";

            string openTag = "<upcase>";
            string closeTag = "</upcase>";

            int firstIndex = text.IndexOf(firstKeyword);
            int secondIndex = text.IndexOf(secondKeyword, firstIndex + 1); 
            
            while (firstIndex != - 1)
            {
                string t = text.Substring(firstIndex + 1, secondIndex - firstIndex - 1);
                text = text.Replace(t,t.ToUpper());
                firstIndex=text.IndexOf(firstKeyword,secondIndex+9);
                secondIndex = text.IndexOf(secondKeyword, firstIndex + 1);
                
            }

            text = text.Replace(openTag, "");
            text = text.Replace(closeTag, "");
            Console.WriteLine(text);
           
        }

    }
}
