
//Task 12- We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p 
// from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)


using System;

namespace _12.BinaryNumber
{
    class ChangeTheBit
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter value 0 or 1: ");
            int v = int.Parse(Console.ReadLine());

            if (0 == v)
            {
                v = ~(1 << p);
                v = v & n;

            }
            else
            {
                v = 1 << p;
                v = v | n;
            }
            
            Console.WriteLine(v);
        }
    }
}
