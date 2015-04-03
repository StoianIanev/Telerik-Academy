namespace _01.MobilePhone
{
    public class Display
    {
        // Task 1, 2, 5 
        private byte? displaySize;
        private string numberOfColors;
        
        //<constructors>
        public Display()
        {
            this.displaySize = null;
            this.numberOfColors = null;
        }
        public Display(byte displaySize, string numberOfColors)
        {
            this.displaySize = displaySize;
            this.numberOfColors = numberOfColors;
        }
        //</constructors>


        //<properties>
        public byte? DisplaySize
        {
            get { return this.displaySize; }
            set { this.displaySize = value; }
        }
        public string NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
        //</properties>

    }
}
