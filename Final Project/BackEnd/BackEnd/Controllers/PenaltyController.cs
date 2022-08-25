using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.BusinessLayer;
using BackEnd.DataLayer;
using BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PenaltyController : ControllerBase
    {
        private readonly ISQL_Data_Helper _sqlHelper;
        private readonly IPenaltyCalculator _penaltyCalculator;
        public PenaltyController(ISQL_Data_Helper sqlHelper, IPenaltyCalculator penaltyCalculator)
        {
            _sqlHelper = sqlHelper;
            _penaltyCalculator = penaltyCalculator;
        }

        [HttpGet]
        [Route("Country")]
        public List<Country> GetCountry()
        {
            try
            {
                return _sqlHelper.GetCountries();
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("Holiday")]
        public List<Holiday> GetHoliday()
        {
            try
            {
                return _sqlHelper.GetHolidays();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpPost]
        [Route("Penalty")]
        public PenaltyOutput Penalty(PenaltyInput penaltyInput)
        {
            try
            {
                return _penaltyCalculator.Calculate_Penalty(penaltyInput.StartDate, penaltyInput.LastDate, penaltyInput.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}