using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee employeeDetails = (Employee)Session["tempEmployee"];
            ID.InnerText = employeeDetails.employeeID.ToString();
            name.InnerText = employeeDetails.employeeName;
            roll.InnerText = employeeDetails.employeeRole;
            salary.InnerText = employeeDetails.employeeSalary;
            location.InnerText = employeeDetails.employeeAddress;
            
        }
    }
} 