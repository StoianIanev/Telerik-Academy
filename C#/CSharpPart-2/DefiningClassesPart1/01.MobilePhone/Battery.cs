namespace _01.MobilePhone
{
    public class Battery
    {
        // Task 1, 2, 3, 5
        private string batteryModel;
        private byte? HoursIdle;
        private byte? HoursTalk;
        public enum BatteryType { LiIon, LiPol, Mio, NiMH, NiCd };

        //<constructors>
        public Battery()
        {
            this.batteryModel = null;
            this.HoursIdle = null;
            this.HoursTalk = null;

        }
        public Battery(string batteryModel, byte HoursIdle, byte HoursTalk)
        {
            this.batteryModel = batteryModel;
            this.HoursIdle = HoursIdle;
            this.HoursTalk = HoursTalk;
        }
        //</constructors>

        //<properties>
        public string BaterryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        public byte? BatteryHoursIdle
        {
            get { return this.HoursIdle; }
            set { this.HoursIdle = value; }
        }
        public byte? BatteryHoursTalk
        {
            get { return this.HoursTalk; }
            set { this.HoursTalk = value; }
        }
        //</properties>
       
    }
}
