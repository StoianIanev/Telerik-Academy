
//Task 3- Write a program to check if in a given expression the brackets are put correctly.
//       Example of correct expression: ((a+b)/5-d).
//       Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTheBrackets
{
    class CheckTheBrackets
    {
        static void Main()
        {
            Console.Write("Enter expression: ");
            string expression = Console.ReadLine();
            CorrectlyExpression(expression);

        }
        static void CorrectlyExpression(string expression)
        {
            int count = 0;
            for (int i = 0; i < expression.Length-1; i++)
            {
                if (expression[i] == '(')
                {
                    count++;
                }
                else if (expression[i] == ')')
                {
                    count--;
                }
            }
            if (count==0)
            {
                Console.WriteLine("The brackets are placed correctly!");
            }
            else
            {
                Console.WriteLine("The brackets are not placed correctly!");
            }
        }
    }
}