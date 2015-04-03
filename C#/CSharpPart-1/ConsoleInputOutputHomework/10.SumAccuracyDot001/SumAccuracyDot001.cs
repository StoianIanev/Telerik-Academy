
//Task 10- Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

namespace _10.SumAccuracyDot001
{
    class SumAccuracyDot001
    {
        static void Main()
        {
            decimal n = 1m;
            int count = 2;

            decimal sum = 0;
            decimal s = 0;

            while (sum - s < 0.001m )
            {
                s = sum;
                sum = sum + (n / count); 
                count++;
                Console.WriteLine(sum);
                
            }
            Console.WriteLine("Sum is: {0:0.000}",sum);

        }
    }
}
