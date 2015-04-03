
// Task 1- Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
//         new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubstringExtension;

namespace SubstringExtension
{
    class ExtentionMethod
    {
        static void Main()
        {
           StringBuilder sb = new StringBuilder();
           sb.Append("Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.");
           Console.WriteLine();
           Console.WriteLine(sb.Substring(0,sb.Length));
           Console.WriteLine(sb.Substring(5, 3));
           Console.WriteLine(sb.Substring(5,sb.Length-5));
           
        }
    }
}
