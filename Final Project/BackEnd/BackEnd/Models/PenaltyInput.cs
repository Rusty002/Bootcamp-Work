using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class PenaltyInput
    {
        public DateTime StartDate { get; set; }
        public DateTime LastDate { get; set; }
        public int Id { get; set; }

        public PenaltyInput(DateTime sdate, DateTime lDate, int countryId)
        {
            StartDate = sdate;
            LastDate = lDate;
            Id = countryId;
        }
    }
}
