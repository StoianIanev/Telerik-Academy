using System;
using System.Collections.Generic;
using System.Text;

namespace _01.MobilePhone
{
    public class Call : IComparable
    {
        // Task 8
        private string date;
        private string time;
        public int duration;

        // <constructors>
        public Call(string date,string time,int duration)
        {
            this.date = date;
            this.time = time;
            this.duration = duration;
        }
        // </constructors>

        // <properties>
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        // </properties>


        public int CompareTo(object obj)
        {
            Call toBeComapredTo = obj as Call;
            if (this.Duration > toBeComapredTo.Duration)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

         public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(date + " ");
            sb.Append(time);
            sb.Append(duration);
           
            return sb.ToString();
        }

    }
}
