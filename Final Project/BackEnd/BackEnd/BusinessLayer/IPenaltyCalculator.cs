using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.BusinessLayer
{
    // Interface of Penalty Calculator
    public interface IPenaltyCalculator
    {
        int Calculate_Holidays(DateTime startDate, DateTime lastDate, int countryID);
        int Calculate_BusinessDays(DateTime startDate, DateTime lastDate, int countryID);
        int[] Penalty(int countryID);
        PenaltyOutput Calculate_Penalty(DateTime startDate, DateTime lastDate, int countryID);
    }
}
