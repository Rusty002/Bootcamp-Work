using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Holiday
    {
        public int HolidayID { get; set; }
        public string Holiday_Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ForeignKey { get; set; }

        public Holiday()
        {

        }

        public Holiday(int holidayid, string holidayName, DateTime startDate, DateTime endDate, int foreignkey)
        {
            HolidayID = holidayid;
            Holiday_Name = holidayName;
            StartDate = startDate;
            EndDate = endDate;
            ForeignKey = foreignkey;
        }
    }
}
