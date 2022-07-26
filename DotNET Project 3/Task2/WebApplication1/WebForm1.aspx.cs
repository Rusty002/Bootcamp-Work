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

        protected void SubmitClear(object sender, EventArgs e)
        {
            //Storing Values in ViewState
            ViewState["name"] =username.Text;
            ViewState["temppass"] = password.Text;
            username.Text = password.Text = string.Empty;
        }

        protected void RestoreViewState(object sender, EventArgs e)
        {
            //Putting them back in input fields
            if (ViewState["name"] != null)
            {
                username.Text = ViewState["name"].ToString();
            }
            if (ViewState["temppass"] != null)
            {
                password.Text = ViewState["temppass"].ToString();
            }
        }
        
        protected void RestoreWithHidden(object sender, EventArgs e)
        {
            //Restoring values from hidden fields
            username.Text = userField.Value.ToString();
            password.Text = passwordField.Value.ToString();
        }
    }
}