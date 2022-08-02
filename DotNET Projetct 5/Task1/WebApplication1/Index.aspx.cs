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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {
            if (dropdown.SelectedValue == "1")
            {
                if (name.Text == "Admin" && word.Text == "pass")
                {
                    Response.Redirect("Admin.aspx");
                }

            }
            else if (dropdown.SelectedValue == "2")
            {
                if (name.Text == "Accountant" && word.Text == "pass")
                {
                    Response.Redirect("Accountant.aspx");
                }
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}