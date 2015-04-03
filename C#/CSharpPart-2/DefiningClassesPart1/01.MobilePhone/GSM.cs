namespace _01.MobilePhone
{
    using System.Text;
    using System.Collections.Generic;
    using System;
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        public Battery battery = new Battery();
        public Display display = new Display();
        private static GSM IPhone4S;

        //<properties>
        public static GSM IPhoneFourS
        {
            get
            {
                return new GSM("IPhone4S", "Apple", 800.00M, "Pesho", "", 32, 123, 5, "72p");
            }
        }
        // </properties>

        //<constructors>
        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }
        public GSM(string model, string manufacturer, decimal price, string owner,
            string batteryModel, byte HoursIdle, byte HoursTalk, byte displaySize, string numberOfColors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery(batteryModel, HoursIdle, HoursTalk);
            this.display = new Display(displaySize, numberOfColors);
        }
        //</constructors>

        // <properties>
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        //</properties>


        // Task 9, 10, 11
        public List<Call> callHistory = new List<Call>();

        //<property>
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory=value; }
        }
        //</property>


        // <methods>
        public void AddCall(string date, string time, int duration)
        {
            Call newCall = new Call(date, time, duration);
            callHistory.Add(newCall);
        }
        public void DeliteCall(Call callToRemove)
        {
            callHistory.Remove(callToRemove);
        }
        public void ClearCallHistory()
        {
            callHistory.Clear();
        }
        public string  PricePerMinute(double price)
        {
            double sum = 0;
            foreach (Call item in callHistory)
            {
                sum = sum + item.duration * price;
            }
            return sum.ToString();
        }
        // </methods>


        public override string ToString()
        {
            return string.Format("Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}, BatteryModel: {4} BatteryHoursIdle: {5} ,BatteryHoursTalk: {6}, DisplaySize: {7}, DisplayNumberOfColors: {8}", model, manufacturer, price, owner, battery.BaterryModel, battery.BatteryHoursIdle, battery.BatteryHoursTalk,
                display.DisplaySize, display.NumberOfColors);

        }


        internal void Remove(int maxCall)
        {
            throw new NotImplementedException();
        }
    }
}
