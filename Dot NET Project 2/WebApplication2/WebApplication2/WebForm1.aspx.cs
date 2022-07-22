using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static List<string> dataArray = new List<string> { "Mazda", "Audi", "BMW", "Cadillac", "Chevrolt", "Dastun", "Ferrari", "Ford", "Acura", "Changan",
                "Kia", "Hyundai", "Honda", "Suzuki", "Isuzu", "Puegeot", "Porsche", "GMC", "Tesla", "Lamborghini" };

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        [WebMethod]
        public static string[] SearchCar(string carData)
        {

            List<string> requiredCars = new List<string>();
            int queryLength = carData.Length;


            for (int i = 0; i < dataArray.Count; i++)
            {
                string car = dataArray[i];
                if (car.Length >= queryLength)
                {
                    if (car.Substring(0, queryLength).ToLower() == carData.ToLower() && queryLength != 0)
                    {
                        requiredCars.Add(car);
                    }
                }
            }

            string[] reqCars = requiredCars.ToArray();
            return reqCars;
        }
    }

    
    
}