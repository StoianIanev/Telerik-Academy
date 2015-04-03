
//Task 25- Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
//         Example:
// <html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
// </html>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ExtractHTML
{
    class ExtractHTML
    {
        static void Main()
        {
            string text = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            char openTag = '<';
            char closeTag = '>';
            int count = 0;
            StringBuilder txt = new StringBuilder();
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == openTag)
                {
                    count += 1;
                }
                else if(text[i] == closeTag)
                {
                    count -= 1;
                    
                }
                if (count == 0)
                {
                    if (text[i+1] == openTag)
                    {
                        
                    }
                    else
                    {
                        txt.Append(text[i+1]);
                    }
                }
            }
            Console.WriteLine(txt.ToString());
        }

    }
}
