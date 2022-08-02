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
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] itemsAvailable = {"FootBall", "Lays", "Coca Cola", "Biryani", "Bread", "Sweets", "Chocolate", "Biscuits", "Jellies", "Gum"};
            string[] brandsAvailable = { "Nike", "Pepsi", "Coca Cola", "National", "Dawn", "Mayfair", "DairyMilk", "Peak Freans", "Giggly", "Hilal" };

            Item item = new Item(1, "test", "test", "test");
            List<Item> list1 = new List<Item>();
            for (int i = 0; i < 20; i++)
            {
                if(i<10)
                {
                    item = new Item(i, "Daily Usage", itemsAvailable[i], brandsAvailable[i]);
                    list1.Add(item);
                }
                else
                {
                    item = new Item(i, "Daily Usage", itemsAvailable[(i%10)], brandsAvailable[(i%10)]);
                    list1.Add(item);
                }

            }
            if(Session["Ilist"] is null)
            {
                Session["Ilist"] = list1;
            }

        }

        [WebMethod]
        public static string AddItem(string id,string name,string type,string brand)
        {

            List<Item> tempList = (List<Item>)HttpContext.Current.Session["Ilist"];
            if (name != "" && type != "" && brand != "")
            {
                int tempId = Convert.ToInt32(id);
                Item tempItem = new Item(tempId, type, name, brand);
                tempList.Add(tempItem);
                HttpContext.Current.Session["Ilist"] = tempList;
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(tempList);
        }


        [WebMethod]
        public static string DeleteItem(string id)
        {
            Item tempItem = new Item(Convert.ToInt32(id), "a", "a", "a");
            List<Item> tempList = HttpContext.Current.Session["Ilist"] as List<Item>;
            int index = Convert.ToInt32(id);
            foreach (Item i in tempList)
            {
                if (i.Id == index)
                {
                    tempItem = i;
                }
            }
            tempList.Remove(tempItem);
            HttpContext.Current.Session["Ilist"] = tempList;
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(tempList);
        }


        [WebMethod]
        public static string GetItems()
        {
            List<Item> list = HttpContext.Current.Session["Ilist"] as List<Item>;
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(list);

        }

    }

    public class Item
    {
        public int Id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string brand { get; set; }

        public Item(int number, string producttype, string productName, string brandName)
        {
            Id = number;
            type = producttype;
            name = productName;
            brand = brandName;
        }
    }
}