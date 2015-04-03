
//Task 4- Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		 Example: The target substring is "in". The text is as follows:
//       We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//       The result is: 9.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SearchStingInText
{
    class SearchStingInText
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string newTex = text.ToLower();
            string keyword = "in";
            int index = newTex.IndexOf(keyword);
            int count = 0;

            while (index != -1)
            {
                count++;
                index=newTex.IndexOf(keyword, index + 1);
            }
            Console.WriteLine("The substring '{0}' is meeting {1} times",keyword,count);
        
        }
    }
}
