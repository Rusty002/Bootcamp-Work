using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.DataLayer
{
    public interface ISQL_Data_Helper
    {
       List<Country> GetCountries();

       List<Holiday> GetHolidays();
    }
}
