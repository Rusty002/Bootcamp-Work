using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // List of Employees for making a database
            List<Employee> dataBaseOfEmployees = new List<Employee>();
            // dummy Employee for populating Database
            Employee dummyEmployee = new Employee("name", "role", 0, "$2000", "address");

            // Random Number Generator
            Random random = new Random();
            
            // Loop for populating list
            for(int i = 0; i<10; i++)
            {
                int num = random.Next(10, 99);
                string temp = i.ToString() + num.ToString();
                dummyEmployee = new Employee("name: " + i, "role: " + i, Convert.ToInt32(temp), "$200" + i, ("street No " + i + ", House No " + i + ", Area No " + i));
                dataBaseOfEmployees.Add(dummyEmployee);
            }

            //Mainataining data in session
            if (Session["tempTable"] is null)
            {
                Session["tempTable"] = dataBaseOfEmployees;
            }

            // binding of list
            myGrid.DataSource = dataBaseOfEmployees;
            myGrid.DataBind();


            
        }

        protected void myGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            myGrid.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void myGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            myGrid.SelectedIndex = e.NewSelectedIndex;
            BindData();
        }
        protected void myGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            myGrid.EditIndex = e.NewEditIndex;
            BindData();
        }

        private void BindData()
        {
            myGrid.DataSource = Session["tempTable"];
            myGrid.DataBind();
        }

        protected void myGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //List<Employee> sourceData = (List<Employee>)Session["tempTable"];
            //sourceData[e.RowIndex] = (List<Employee>)e.NewValues;
            // = e.NewValues;
            GridViewRow row = myGrid.Rows[e.RowIndex];
            int ID = Convert.ToInt32(myGrid.DataKeys[e.RowIndex].Values[0]);
            string columnName = (row.Cells[2].Controls[0] as TextBox).Text;
            string dataType = (row.Cells[3].Controls[0] as DropDownList).Text;


            myGrid.UpdateRow(myGrid.EditIndex, true);
            BindData();
        }

        protected void myGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            List<Employee> sourceData = (List<Employee>)Session["tempTable"];
            sourceData.RemoveAt(e.RowIndex);
            myGrid.DataSource = sourceData;
            BindData();
        }

        protected void myGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            myGrid.EditIndex = -1;
            BindData();
        }
    }

    public class Employee
    {
        public string employeeName { get; set; }
        public string employeeRole { get; set; }
        public int employeeID { get; set; }
        public string employeeSalary { get; set; }
        public string employeeAddress { get; set; }

        //Construtor
        public Employee(string name, string role, int id, string salary, string Address)
        {
            employeeName = name;
            employeeRole = role;
            employeeID = id;
            employeeSalary = salary;
            employeeAddress = Address;
        }
    }
}