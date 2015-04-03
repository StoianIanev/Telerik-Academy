
// Task 8 - Declare two string variables and assign them with following value:
//               The "use" of quotations causes difficulties.
//     Do the above in two different ways: with and without using quoted strings.

using System;

namespace _08.Quotations
{
    class Quotations
    {
        static void Main()
        {
            string quotation = "The 'use 'of quotations causes difficulties.";
            string quotation1 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(quotation);
            Console.WriteLine(quotation1);
        }
    }
}
