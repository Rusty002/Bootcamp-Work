using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string number1 = Request["firstNumber"];
            string number2 = Request["secondNumber"];
            string operation = Request["operations.SelectedValue"];
            string Result = Request["Result"];
            firstNumber.Text = number1;
            secondNumber.Text = number2;
            if(operation == "1")
            {
                selectedValue.Text = "Addition";
            }
            else if(operation == "2")
            {
                selectedValue.Text = "Subtraction";
            }
            else if(operation == "3")
            {
                selectedValue.Text = "Division";
            }
            else
            {
                selectedValue.Text = "Multiplication";
            }
            result.Text = Result;
        }
    }
}