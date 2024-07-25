using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi_2
{
    internal class hiredate
    {

        private int Month;
        private int Year;
        private int Day;

        public hiredate()
        {
        }

        public hiredate(int month, int year, int day)
        {
            this.Month = month;
            this.Year = year;
            this.Day = day;
        }
        public int year   { set; get; }
        public int month {  set; get; }
        public int day { set; get; }
    }
}

