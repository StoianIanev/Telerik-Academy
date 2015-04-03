
// Task 9 - Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//   Use Windows Character Map to find the Unicode code of the © symbol. 
//   Note: the © symbol may be displayed incorrectly.


using System;

namespace _09.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char ch = '\u00A9';
            Console.WriteLine("      {0}  ",ch);
            Console.WriteLine("     {0} {1} ", ch,ch);
            Console.WriteLine("    {0} {1} {2} ", ch,ch,ch);
        

            
        }
    }
}
