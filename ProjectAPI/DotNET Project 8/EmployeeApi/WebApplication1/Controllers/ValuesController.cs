using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "http://localhost:4200/",headers:"*",methods:"*")]
    public class ValuesController : ApiController
    {
        SqlConnection connection = new SqlConnection(@"Data Source=CMDLHRDB01;Initial Catalog=AbdurRehman;Persist Security Info=True;User ID=sa;Password=CureMD2022");

        //string value = "'Junaid', 'Arif', 'Gujrat'";
        // GET api/values
        [Route("GetEmployees")]
        [HttpGet]
        public string Get()
        {
            //return new string[] { "value1", "value2" };
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES", connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No Data Found";
            }

        }

        // GET api/values/5
        [Route("GetEmployee/{id}")]
        [HttpGet]
        public string Get(int id)
        {
            //return "value";
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES WHERE EmployeeID='" + id + "'", connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No Data Found";
            }
        }

        // POST api/values
        //public string Post([FromBody]string value)
        //{
        //    SqlCommand cmd = new SqlCommand("insert into STUDENTS values('" + value + "')", connection);
        //    connection.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    if(i==1)
        //    {
        //        return "Record Inserted as " + value;
        //    }
        //    else
        //    {
        //        return "Try Again. No Data Inserted";
        //    }
        //}

        // PUT api/values/5
        //public string Put(int id, [FromBody]string value)
        //{
        //    SqlCommand cmd = new SqlCommand("UPDATE STUDENTS  SET Fname = '" + value + "' WHERE StudentID = '" + id + "'", connection);
        //    connection.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    connection.Close();
        //    if (i == 1)
        //    {
        //        return "Record Updated Successfully with Value as " + value + " And ID: " + id;
        //    }
        //    else
        //    {
        //        return "Try Again No Data Updated";
        //    }
        //}

        //// DELETE api/values/5
        //public string Delete(int id)
        //{
        //    SqlCommand cmd = new SqlCommand("DELETE FROM STUDENTS WHERE StudentID = '" + id + "'", connection);
        //    connection.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    connection.Close();
        //    if (i == 1)
        //    {
        //        return "Record Deleted Successfully with ID: " + id;
        //    }
        //    else
        //    {
        //        return "Try Again No Data DELETED";
        //    }
        //}
    }
}
