using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DataLayer;
using BackEnd.Models;

namespace BackEnd.BusinessLayer
{
    public class PenaltyCalculator : IPenaltyCalculator
    {
        // private member of data helper class to facilitate usage in business layer
        private readonly ISQL_Data_Helper _sqlHelper;

        // Constructor of Penalty Calculator with dependency Injected
        public PenaltyCalculator(ISQL_Data_Helper sqlHelper)
        {
            sqlHelper = _sqlHelper;
        }

        // Function to calculate business days
        public int Calculate_BusinessDays(DateTime startDate, DateTime lastDate, int countryID)
        {
            int businessDays = 0;
            for (DateTime date = startDate; date <= lastDate; date = date.AddDays(1))
            {
                // if country is Pakistan
                if (countryID == 1)
                {
                    if (startDate.DayOfWeek == DayOfWeek.Saturday && startDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        businessDays++;
                    }
                }
                // If Country is UAE
                if (countryID == 2)
                {
                    if (startDate.DayOfWeek == DayOfWeek.Friday && startDate.DayOfWeek == DayOfWeek.Saturday)
                    {
                        businessDays++;
                    }
                }
            }

            businessDays -= Calculate_Holidays(startDate,lastDate,countryID);
            return businessDays;
        }

        // function to calculate Holidays
        public int Calculate_Holidays(DateTime startDate, DateTime lastDate, int countryID)
        {
            List<Holiday> allHolidays = _sqlHelper.GetHolidays();
            int holiday = 0;

            // loop for traversing list of holidays
            for(int i =0; i<allHolidays.Count; i++ )
            {
                if(allHolidays[i].ForeignKey == countryID)
                {
                    for(DateTime date = allHolidays[i].StartDate; date <= allHolidays[i].EndDate; date= date.AddDays(1))
                    {
                        // if country is Pakistan
                        if(countryID==1)
                        {
                            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                            {
                                holiday++;
                            }
                        }
                        // If Country is UAE
                        if (countryID == 2)
                        {
                            if (startDate.DayOfWeek != DayOfWeek.Friday && startDate.DayOfWeek != DayOfWeek.Saturday)
                            {
                                holiday++;
                            }
                        }
                    }
                }
            }

            return holiday;
        }

        // Function to Calculate the penalty
        public PenaltyOutput Calculate_Penalty(DateTime startDate, DateTime lastDate, int countryID)
        {
            try
            {
                int days = Calculate_BusinessDays(startDate, lastDate, countryID);
                double fine = 0;
                string currency= "";
                int[] penalty = Penalty(countryID);
                if (days > 10)
                {
                    if (penalty[1] == 0)
                    {
                        fine = days * penalty[0];
                        currency = "Rs.";
                    }
                    else
                    {
                        fine = days * penalty[0];
                        fine *= (penalty[1] / 100);
                        currency = "DH";
                    }
                }
                PenaltyOutput penaltyFinal = new PenaltyOutput(days, fine,currency);
                return penaltyFinal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Function to get the info for calculation of penalty
        public int[] Penalty(int countryID)
        {
            List<Country> tempCountry = _sqlHelper.GetCountries();
            int[] penalty= { };
            for(int i =0; i<tempCountry.Count; i++)
            {
                if (countryID == 1)
                {
                    penalty[0] = tempCountry[i].Penalty;
                    penalty[1] = tempCountry[i].SpecialTax;
                }
                else if(countryID == 2)
                {
                    penalty[0] = tempCountry[i].Penalty;
                    penalty[1] = tempCountry[i].SpecialTax;
                }
                else
                {
                    continue;
                }
            }
            return penalty;
        }
    }
}
