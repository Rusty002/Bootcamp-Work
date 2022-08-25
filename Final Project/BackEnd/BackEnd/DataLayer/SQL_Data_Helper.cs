using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BackEnd.DataLayer
{
    // Implementation of Data Helper Class using interface of Data Helper
    public class SQL_Data_Helper : ISQL_Data_Helper
    {
        // Connection String Empty initialized
        string connectionstring = string.Empty;
        // Dynamic list containing objects of Country Class
        List<Country> countries = new List<Country>();
        // Dynamic List containing objetcs of Holiday Class
        List<Holiday> holidays = new List<Holiday>();

        // Constructor of Data_Helper_Class with dependency of configuration injected
        public SQL_Data_Helper(IConfiguration config)
        {
            // try-catch for exception Handling
            try
            {
                connectionstring = config.GetConnectionString("DefaultConnection");

            }
            catch (Exception)
            {
                throw;
            }
        }

        // Method to Get the all countries
        public List<Country> GetCountries()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    // Query Selecting all Countries
                    using (SqlCommand command = new SqlCommand("SELECT * FROM COUNTRIES", con))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                // Converting the value fetched into an object of Country Class
                                Country country = new Country(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString(), Convert.ToInt32(dataReader.GetValue(2)), dataReader.GetValue(3).ToString(), Convert.ToInt32(dataReader.GetValue(4)), Convert.ToInt32(dataReader.GetValue(5)), Convert.ToInt32(dataReader.GetValue(6)));
                                countries.Add(country);
                            }
                        }
                    }

                    con.Close();
                    return countries;
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<Holiday> GetHolidays()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Query Selecting all Holidays
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM HOLIDAYS", con))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                // Converting the value fetched into an object of Holiday Class
                                Holiday holiday = new Holiday(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString(), Convert.ToDateTime(dataReader.GetValue(2)), Convert.ToDateTime(dataReader.GetValue(3)), Convert.ToInt32(dataReader.GetValue(4)));
                                holidays.Add(holiday);
                            }
                        }
                    }

                    con.Close();
                    return holidays;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
