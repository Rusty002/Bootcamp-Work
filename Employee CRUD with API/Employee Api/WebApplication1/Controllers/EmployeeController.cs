using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : ApiController
    {
        [Route("GetEmployees")]
        public HttpResponseMessage Get()
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES", connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, dt);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "No Data Found");
            }

        }

        // Selecting a Single Employee
        [Route("GetEmployee/{id}")]
        public string Get(int id)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString);
                connection.Open();
                string query = "SELECT * FROM EMPLOYEES WHERE EmployeeID='" + id + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.ExecuteNonQuery();
                connection.Close();
                return "Employee Viewed Successfully";
            }
            catch
            {
                return "Error";
            }
        }

        // Adding a New Object in DataBase
        [Route("AddEmployee")]
        public string Post(Employee employee)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString);
                connection.Open();
                string query = "INSERT INTO EMPLOYEES VALUES('" + employee.EmpName + "','" + employee.City + "','" + employee.Gender + "');";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.ExecuteNonQuery();
                connection.Close();
                return "Added Successfully";
            }
            catch
            {
                return "Failed to Add";
            }
        }

        
        //Updating an Existing Object in DataBase
        [Route("UpdateEmployee")]
        public string Put(Employee employee)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString);
                connection.Open();
                string query = "UPDATE EMPLOYEES SET EmpName = '" + employee.EmpName + "', City ='" + employee.City + "', Gender = '" + employee.Gender + "' WHERE EmployeeID = '" + employee.EmployeeID + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.ExecuteNonQuery();
                connection.Close();
                return "Updated Successfully";
            }
            catch
            {
                return "Failed to update";
            }
        }

        //Deleting an Employee
        [Route("DeleteEmployee/{id}")]

        public string Delete(int id)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDB"].ConnectionString);
                connection.Open();
                string query = "DELETE FROM EMPLOYEES WHERE EmployeeID = '" + id + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.ExecuteNonQuery();
                connection.Close();
                return "Deleted Successfully";
            }
            catch
            {
                return "Failed to Delete";
            }
        }
    }
}
 