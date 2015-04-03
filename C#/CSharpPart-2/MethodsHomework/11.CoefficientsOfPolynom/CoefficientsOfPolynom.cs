
//Task 11- Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5  -> |5|0|1|
//Task 12- Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;

namespace _11.CoefficientsOfPolynom
{
    class CoefficientsOfPolynom
    {
        static void InsertOfCoefficients(decimal[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = decimal.Parse(Console.ReadLine()); 

            }
        }
        static void SumOfPolynoms(decimal[] firstPoly, decimal[] secondPoly)
        {
            Array.Reverse(firstPoly);
            Array.Reverse(secondPoly);

            int maxLen = Math.Max(firstPoly.Length,secondPoly.Length);
            decimal[] result = new decimal[maxLen];
            int len = 0;
            int biggerArray = 0;

            if (firstPoly.Length > secondPoly.Length)
            {
                len = secondPoly.Length;
                biggerArray = 1;
            }
            else
            {
                 len = firstPoly.Length;
                 biggerArray = 2;
            }

            for (int i = 0; i < len; i++)
            {
                result[i] = firstPoly[i] + secondPoly[i];
            }

            for (int i = len; i < result.Length; i++)
            {
                if (biggerArray == 1)
                {
                    result[i] = firstPoly[i];
                }
                else
                {
                    result[i] = secondPoly[i];
                }

            }

            PrintPolynom(result);

        }
        static void SubtractionOfPolynoms(decimal[] firstPoly, decimal[] secondPoly)
        {

            Array.Reverse(firstPoly);
            Array.Reverse(secondPoly);

            int maxLen = Math.Max(firstPoly.Length, secondPoly.Length);
            decimal[] result = new decimal[maxLen];
            int len = 0;
            int biggerArray = 0;

            if (firstPoly.Length > secondPoly.Length)
            {
                len = secondPoly.Length;
                biggerArray = 1;
            }
            else
            {
                len = firstPoly.Length;
                biggerArray = 2;
            }

            for (int i = 0; i < len; i++)
            {
                result[i] = firstPoly[i] - secondPoly[i];
            }

            for (int i = len; i < result.Length; i++)
            {
                if (biggerArray == 1)
                {
                    result[i] = firstPoly[i];
                }
                else
                {
                    result[i] = secondPoly[i];
                }

            }

            PrintPolynom(result);

        }
        static void MultiplyPolinomials(decimal[] firstPoly, decimal[] secondPoly)
        {
            Array.Reverse(firstPoly);
            Array.Reverse(secondPoly);
            int maxLen = firstPoly.Length + secondPoly.Length;
            decimal[] result = new decimal[maxLen];
    
            for (int i = 0; i < firstPoly.Length; i++)
            {
                for (int j = 0; j < secondPoly.Length; j++)
                {
                    int position = i + j;
                    result[position] += firstPoly[i] * secondPoly[j];
                }
                
            }
            
            PrintPolynom(result);

        }

        static void PrintPolynom(decimal[] result)
        {
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (result[i] != 0 && i != 0)
                {
                    if (result[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, result[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, result[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", result[i]);
                }
            }

            Console.WriteLine();
            //int degree = result.Length - 1;
           
            //for (int i = 0;  i < result.Length; i++)
            //{
            //    if (i + 1  == result.Length)
            //    {
            //        Console.Write(" " + "{0}",result[i]);
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        if (result[i] == 0)
            //        {
            //            degree--;
            //        }
            //        else
            //        {
            //            Console.Write("{0}*x^{1} + ", result[i], degree-i);
            //        }
                    
            //    }

            //}  
        }
        static void MultiplyPrint(decimal[] multiply)
        {

        }

        static void Main()
        {
            Console.Write("Enter degree of your 1 polynomial: ");
            int FirstDegreePoly = int.Parse(Console.ReadLine());
            Console.Write("Enter coefficient from higest to smallest [x^2 => x^0]:");
            decimal[] FirstPolynom = new decimal[FirstDegreePoly + 1];
            InsertOfCoefficients(FirstPolynom);

            Console.Write("Enter degree of your 2 polynomial: ");
            int SecondDegreePoly = int.Parse(Console.ReadLine());
            Console.Write("Enter coefficient from higest to smallest [x^2 => x^0]:");
            decimal[] SecondPolynom = new decimal[SecondDegreePoly + 1];

            InsertOfCoefficients(SecondPolynom);

            Console.Write("The sum of two polynomials is: ");
            SumOfPolynoms(FirstPolynom, SecondPolynom);
            Console.WriteLine();
            Console.Write("The substraction of two polynomials is:");
            SubtractionOfPolynoms(FirstPolynom, SecondPolynom);
            Console.WriteLine();
            Console.Write("Multiply of two polinomials is: ");
            MultiplyPolinomials(FirstPolynom, SecondPolynom);
            Console.WriteLine();
        }

    }
}
