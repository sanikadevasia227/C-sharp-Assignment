using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Unicast
{
    public class Date
    {

        private int day;
        private int month;
        private int year;

        public Date()
        {
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        //Properties for the Date class Members

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public override string ToString()
        {
            return "" + Day + "/" + Month + "/" + Year;
        }
    }
}
