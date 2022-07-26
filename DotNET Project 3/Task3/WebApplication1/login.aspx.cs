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
            if (Session["user"] != null)
            {
                Response.Redirect("Greetings.aspx");
            }
        }
        protected void LoginBtn(object sender, EventArgs e)
        {
            if (username.Text == "polar" && password.Text == "vezli")
            {
                Session["user"] = username.Text;
                Session["pass"] = password.Text;
                Response.Redirect("Greetings.aspx");

            }
        }
    }
}