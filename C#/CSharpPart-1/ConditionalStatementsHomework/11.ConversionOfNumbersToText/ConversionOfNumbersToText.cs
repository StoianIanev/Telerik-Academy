
//Task 11- * Write a program that converts a number in the range [0...999] to a text 
//           corresponding to its English pronunciation. Examples:
//           0  "Zero"
// 	         273  "Two hundred seventy three"
//	         400  "Four hundred"
//	         501  "Five hundred and one"
//	         711  "Seven hundred and eleven"

using System;

namespace _11.ConversionOfNumbersToText
{
    class ConversionOfNumbersToText
    {
        static ushort units;
        static string letterUnits;
        static ushort tens;
        static string letterTens;
        static ushort hundreds;
        static string letterHundreds;

        static void Units()
        {
            switch (units)
            {
                case 0:
                    letterUnits = "zero";
                    break;
                case 1:
                    letterUnits = "one";
                    break;
                case 2:
                    letterUnits = "two";
                    break;
                case 3:
                    letterUnits = "three";
                    break;
                case 4:
                    letterUnits = "four";
                    break;
                case 5:
                    letterUnits = "five";
                    break;
                case 6:
                    letterUnits = "six";
                    break;
                case 7:
                    letterUnits = "seven";
                    break;
                case 8:
                    letterUnits = "eight";
                    break;
                case 9:
                    letterUnits = "nine";
                    break;
                case 10:
                    letterUnits = "ten";
                    break;
                case 11:
                    letterUnits = "eleven";
                    break;
                case 12:
                    letterUnits = "twoelve";
                    break;
                case 13:
                    letterUnits = "thirteen";
                    break;
                case 14:
                    letterUnits = "fourteen";
                    break;
                case 15:
                    letterUnits = "fifteen";
                    break;
                case 16:
                    letterUnits = "sixteen";
                    break;
                case 17:
                    letterUnits = "seventeen";
                    break;
                case 18:
                    letterUnits = "eighteen";
                    break;
                case 19:
                    letterUnits = "ninteen";
                    break;
            }
        }
        static void Tens()
        {
            switch (tens)
            {
                case 2:
                    letterTens = "twenty";
                    break;
                case 3:
                    letterTens = "thirty";
                    break;
                case 4:
                    letterTens = "fourty";
                    break;
                case 5:
                    letterTens = "fifty";
                    break;
                case 6:
                    letterTens = "sixty";
                    break;
                case 7:
                    letterTens = "seventy";
                    break;
                case 8:
                    letterTens = "eighty";
                    break;
                case 9:
                    letterTens = "ninety";
                    break;
            }

        }

        static void Hundreds()
        {
            switch (hundreds)
            {
                case 1:
                    letterHundreds = "one hundred";
                    break;
                case 2:
                    letterHundreds = "two hundred";
                    break;
                case 3:
                    letterHundreds = "three hundred";
                    break;
                case 4:
                    letterHundreds = "four hundred";
                    break;
                case 5:
                    letterHundreds = "five hundred";
                    break;
                case 6:
                    letterHundreds = "six hundred";
                    break;
                case 7:
                    letterHundreds = "senen hundred";
                    break;
                case 8:
                    letterHundreds = "eight hundred";
                    break;
                case 9:
                    letterHundreds = "nine hundred";
                    break;
            }
        }


        static void Main()
        {
            Console.Write("Enter some numbers in range from 0 to 999: ");
            ushort number;
            bool isNum = ushort.TryParse(Console.ReadLine(), out number);

            if (isNum == true)
            {
                if (number <= 19)
                {
                    units = number;
                    Units();
                    Console.WriteLine(letterUnits);
                }
                else if (number > 19 && number <= 99)
                {
                    tens = number;
                    if (tens % 10 == 0)
                    {
                        Tens();
                        Console.WriteLine(letterTens);
                    }
                    else
                    {
                        units = (ushort)(tens % 10);
                        tens = (ushort)(tens / 10);
                        Units();
                        Tens();
                        Console.WriteLine("{0} {1}", letterTens, letterUnits);
                    }
                }
                else if (number > 99 && number <= 999)
                {
                    if (number % 100 == 0)
                    {
                        hundreds = (ushort)(number / 100);
                        Hundreds();
                        Console.WriteLine(letterHundreds);
                    }
                    else
                    {
                        tens = (ushort)((number % 100) / 10);
                        if (tens == 0)
                        {
                            units = (ushort)(number % 10);
                            hundreds = (ushort)(number / 100);
                            Units(); ;
                            Hundreds();
                            Console.WriteLine("{0} and {1}", letterHundreds, letterUnits);

                        }
                        else
                        {
                            units = (ushort)(number % 10);
                            hundreds = (ushort)(number / 100);
                            Units();
                            Tens();
                            Hundreds();
                            Console.WriteLine("{0} {1} {2}", letterHundreds, letterTens, letterUnits);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Error! Incorrect input!");
            }
        }
    }
}
