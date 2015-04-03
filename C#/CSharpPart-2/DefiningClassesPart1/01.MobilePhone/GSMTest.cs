using System;
using System.Collections.Generic;
namespace _01.MobilePhone
{
    
    public class GSMTest
    {
        // Task 7
       public static void PrintInformationForGMS()
        {
            // Add the information about the GSMs 
            List<GSM> phones = new List<GSM>();

            GSM firstGms = new GSM("Galaxy", "Samsung", 850.00M, "Pesho");
            firstGms.battery.BaterryModel = "K";
            firstGms.battery.BatteryHoursIdle = 30;
            firstGms.battery.BatteryHoursTalk = 10;
            firstGms.display.NumberOfColors = "85d";
            firstGms.display.DisplaySize = 5;

            GSM secondGms = new GSM("LG", "LG", 900.00M, "Gosho");
            secondGms.battery.BaterryModel = "N";
            secondGms.battery.BatteryHoursIdle = 11;
            secondGms.battery.BatteryHoursTalk = 22;
            secondGms.display.NumberOfColors = "65s";
            secondGms.display.DisplaySize = 15;

            phones.Add(firstGms);
            phones.Add(secondGms);
            phones.Add(GSM.IPhoneFourS);

           // Print information  about GSMs
            foreach (var phone in phones)
            {
               Console.WriteLine(phone);
            }
        }

    }
}
