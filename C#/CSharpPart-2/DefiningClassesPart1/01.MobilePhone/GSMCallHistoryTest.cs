using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01.MobilePhone
{
    public class GSMCallHistoryTest
    {
        // Task 12
       private static GSM ourPhone = GSM.IPhoneFourS;
      
        public static void PrintInformationForCalls()
        {
            // Add few calls.
            ourPhone.AddCall("25.12.2014", "4:00 ", 8);
            ourPhone.AddCall("13.02.2014", "8:00 ", 5);
            Console.WriteLine();

            // Print the information about the calls.
            PrintCalls();
           

            //Print price of the calls in the call history
            Console.WriteLine("Price of the calls is: {0}",ourPhone.PricePerMinute(0.37) + " lv");
            Console.WriteLine();

            // Remove the longest call from the history

            List<Call> calls = ourPhone.CallHistory;
            Call maxCall = calls.Max();
            calls.Remove(maxCall);
            Console.WriteLine("The longest call is deleted");
            Console.WriteLine();

            // Calculate the total price again without longest call
            Console.WriteLine("Price of the calls without longest call is: {0}", ourPhone.PricePerMinute(0.37) + " lv");
            Console.WriteLine();

            // Clear the call history and print it.
           ourPhone.ClearCallHistory();
           PrintCalls();

            
        }  
        static void PrintCalls()
        {
            if (ourPhone.callHistory.Count > 0)
            {
                foreach (var item in ourPhone.CallHistory)
                {
                    Console.WriteLine("You added in CallHistory: Date: {0}  Time: {1} Duration: {2}", item.Date, item.Time, item.Duration);
                }
            }
            else
            {
                Console.WriteLine("No Calls!");
            }
            Console.WriteLine();
        }
    }
}
