using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class PenaltyOutput
    {
        public int Days { get; set; }
        public double Fine { get; set; }
        public string Currency { get; set; }

        public PenaltyOutput(int day, double penalty, string currency)
        {
            Days = day;
            Fine = penalty;
            Currency = currency;
        }
    }
}
