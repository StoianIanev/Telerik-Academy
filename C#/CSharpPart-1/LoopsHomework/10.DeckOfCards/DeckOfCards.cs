
//Task 10- Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//         The cards should be printed with their English names. 
//         Use nested for loops and switch-case.

using System;

namespace _10.DeckOfCards
{
    class DeckOfCards
    {
        static void Cards(int m)
        {
            switch (m)
            {
                case 2 :
                    Console.Write("Two ");
                    break;
                case 3:
                    Console.Write("Three ");
                    break;
                case 4:
                    Console.Write("Four ");
                    break;
                case 5:
                    Console.Write("Five ");
                    break;
                case 6:
                    Console.Write("Six ");
                    break;
                case 7: 
                    Console.Write("Seven ");
                    break;
                case 8:
                    Console.Write("Eigth ");
                    break;
                case 9:
                    Console.Write("Nine ");
                    break;
                case 10:
                    Console.Write("Ten ");
                    break;
                case 11:
                    Console.Write("Jack ");
                    break;
                case 12:
                    Console.Write("Queen ");
                    break;
                case 13:
                    Console.Write("King ");
                    break;
                case 14:
                    Console.Write("Ace ");
                    Console.WriteLine();
                    break;
                    
            }
        }
        static void Colors(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("Clubs");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Diamonds");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Hearts");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Spades");
                    break;

            }
        }
        static void Main()
        {
            for (int i = 1; i <=4 ; i++)
            {
                Colors(i);

                for (int m = 2; m <= 14 ; m++)
                {
                   Cards(m);
                   
                }
            }

        }
    }
}
