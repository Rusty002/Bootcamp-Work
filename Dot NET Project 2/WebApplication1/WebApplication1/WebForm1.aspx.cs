using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static List<Student> dataBase = new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] nameArray = {"Ali 1", "Ali 2", "Ali 3", "Ali 4", "Ali 5", "Ali 6", "Ali 7", "Ali 8", "Ali 9", "Ali1 10",
            "Ali 11", "Ali 12", "Ali 13", "Ali 14", "Ali 15", "Ali 16", "Ali 17", "Ali 18", "Ali 19", "Ali 20" };

            dropDownMenu.DataSource = nameArray;
            dropDownMenu.DataBind();

            
            Student Student = new Student("Ali1", 1, "1");
            dataBase.Add(Student);
            Student = new Student("Ali2", 2, "2");
            dataBase.Add(Student);
            Student = new Student("Ali3", 3, "3");
            dataBase.Add(Student);
            Student = new Student("Ali4", 4, "4");
            dataBase.Add(Student);
            Student = new Student("Ali5", 5, "5");
            dataBase.Add(Student);
            Student = new Student("Ali6", 6, "6");
            dataBase.Add(Student);
            Student = new Student("Ali7", 7, "7");
            dataBase.Add(Student);
            Student = new Student("Ali8", 8, "8");
            dataBase.Add(Student);
            Student = new Student("Ali9", 9, "9");
            dataBase.Add(Student);
            Student = new Student("Ali10", 10, "10");
            dataBase.Add(Student);
            Student = new Student("Ali11", 11, "11");
            dataBase.Add(Student);
            Student = new Student("Ali12", 12, "12");
            dataBase.Add(Student);
            Student = new Student("Ali13", 13, "13");
            dataBase.Add(Student);
            Student = new Student("Ali14", 14, "14");
            dataBase.Add(Student);
            Student = new Student("Ali15", 15, "15");
            dataBase.Add(Student);
            Student = new Student("Ali16", 16, "16");
            dataBase.Add(Student);
            Student = new Student("Ali17", 17, "17");
            dataBase.Add(Student);
            Student = new Student("Ali18", 18, "18");
            dataBase.Add(Student);
            Student = new Student("Ali19", 19, "19");
            dataBase.Add(Student);
            Student = new Student("Ali20", 20, "20");
            dataBase.Add(Student);

            Console.WriteLine(dataBase);
        }

        

        [WebMethod]
        public static Student searchStudent(string query)
        {
            int temp = Convert.ToInt32(query);
            return dataBase[temp];
        }

    }





    public class Student
    {
        public string name { get; set; }
        public int rollNumber { get; set; }
        public string grade { get; set; }

        public Student()
        {
            name = "Not Specified";
            rollNumber = 0;
            grade = "Not Specified";
        }

        public Student(string nameOfStudent, int rollNumberOfStudent, string gradeOfStudent)
        {
            name = nameOfStudent;
            rollNumber = rollNumberOfStudent;
            grade = gradeOfStudent;
        }
    }
}