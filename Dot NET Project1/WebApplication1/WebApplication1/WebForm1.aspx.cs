using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void Calculate(Object sender, EventArgs e)
        {
            // Converting Text variables to integers to perform calculations
            var num1 = Convert.ToInt32(firstNumber.Text);
            var num2 = Convert.ToInt32(secondNumber.Text);
            var selectedValue = Convert.ToInt32(operations.SelectedValue);
            double Result = 0;
            if (selectedValue == 1)
            {
                //Addition
                Result = num1 + num2;
                //result.Text = Convert.ToString(Result);
                //return
            }
            else if (selectedValue == 2)
            {
                //subraction
                Result = num1 - num2; 
                //result.Text = Convert.ToString(Result);
                //return
            }
            else if (selectedValue == 3)
            {
                Result = num1 / num2;
                //result.Text = Convert.ToString(Result);
                //return
            }
            else if (selectedValue == 4)
            {
                //multiplication
                Result = num1 * num2;
                //result.Text = Convert.ToString(Result);
                //return
            }

            //Directing to Second Page with Values
            Response.Redirect("WebForm2.aspx?result=" + Result + "&firstNumber=" + num1 + "&secondNumber=" + num2 + "&operations.SelectedValue=" + selectedValue);
        }
    }
}