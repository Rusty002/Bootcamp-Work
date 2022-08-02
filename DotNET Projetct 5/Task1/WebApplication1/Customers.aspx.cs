using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] customerName = { "Ali", "Ahmad", "Butt", "Mark", "Momi", "Rick", "Clair", "Wayne", "Emet", "Pablo" };
            string[] customerMobile = { "12345678910", "090078601", "121-000-234", "6004124190", "121111000", "Not Available", "1122151940", "12378945612", "16248912", "Blocked" };
            int[] customerAge = { 21, 34, 12, 51, 65, 19, 78, 30, 23, 37 };

            Customer dummyCustomer = new Customer("a", "0", 0,0);
            List<Customer> customerList = new List<Customer>();
            for(int i = 0; i < 20; i++)
            {
                if (i < 10)
                {
                    dummyCustomer = new Customer(customerName[i], customerMobile[i], customerAge[i],i);
                    customerList.Add(dummyCustomer);
                }
                else
                {
                    dummyCustomer = new Customer(customerName[(i % 10)], customerMobile[(i % 10)], customerAge[(i % 10)], i);
                    customerList.Add(dummyCustomer);
                }
            }
            if(Session["ICustomers"] is null)
            {
                Session["ICustomers"] = customerList;
            }


        }

        [WebMethod]
        public static string GetCustomers()
        {
            List<Customer> list = HttpContext.Current.Session["ICustomers"] as List<Customer>;
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(list);

        }

        [WebMethod]
        public static string NewCustomer(string name, string mobile, string age, string id)
        {
            List<Customer> tempList = (List<Customer>)HttpContext.Current.Session["ICustomers"];
            if (name != "" && mobile != "")
            {
                int tempAge = Convert.ToInt32(age);
                int Id = Convert.ToInt32(id);
                Customer tempCustomer = new Customer(name, mobile, tempAge,Id);
                tempList.Add(tempCustomer);
                HttpContext.Current.Session["ICustomers"] = tempList;
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(tempList);
        }

        [WebMethod]
        public static string DeleteCustomer(string id)
        {
            Customer tempCustomer = new Customer("", "", 0, Convert.ToInt32(id));
            List<Customer> tempList = (List<Customer>)HttpContext.Current.Session["ICustomers"];
            int index = Convert.ToInt32(id);
            foreach (Customer c in tempList)
            {
                if (c.Id == index)
                {
                    tempCustomer=c;
                }
            }
            tempList.Remove(tempCustomer);
            HttpContext.Current.Session["ICustomers"] = tempList;
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(tempList);
        }
    }

    public class Customer
    {
        public string name { get; set; }
        public string mobileNumber { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Customer(string name, string mobileNumber, int age, int Id)
        {
            this.name = name;
            this.mobileNumber = mobileNumber;
            this.Id = Id;
            Age = age;
        }
    }
}