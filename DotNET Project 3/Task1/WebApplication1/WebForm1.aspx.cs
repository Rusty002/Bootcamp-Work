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
        public int counter = 0;
        public int result = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        
        protected void btnClickIncrement(object sender, EventArgs e)
        {
            //BtnClick Function for Counter
            if(textbox.Text == "0")
            {
                ViewState["result"] = 1;
                textbox.Text = ViewState["result"].ToString();
            }
            else
            {
                //Maintaining the counter and updating the result
                counter = Convert.ToInt32(ViewState["result"]);
                counter += 1;
                ViewState["result"] = counter;
                textbox.Text = ViewState["result"].ToString();
            }
        }
    }
}