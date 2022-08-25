using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Country_Name { get; set; }
        public int SpecialTax { get; set; }
        public string Currency { get; set; }
        public int Penalty { get; set; }
        public int WeekEnd1 { get; set; }
        public int WeekEnd2 { get; set; }

        public Country()
        {

        }

        public Country(int countryId, string countryName,int tax,string currency, int fine, int weekend1, int weekend2)
        {
            ID = countryId;
            Country_Name = countryName;
            SpecialTax = tax;
            Currency = currency;
            Penalty = fine;
            WeekEnd1 = weekend1;
            WeekEnd2 = weekend2;
        }
    }
}
