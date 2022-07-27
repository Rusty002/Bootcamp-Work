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
            // A dummy object of student for populating List
            Student dummyStudent = new Student("Ali", "Unknown", 0);
            //list of students for dataBase
            List<Student> dataOfStudents = new List<Student>() { }; 
            for(int i = 0; i < 10;i++)
            {
                //Generating of Objects and Addition of list by a Loop
                dummyStudent = new Student("Ali" + i, "Unknown" + i, i);
                dataOfStudents.Add(dummyStudent);
            }

            //Data Binding of list to gridView
            studentTable.DataSource = dataOfStudents;
            studentTable.DataBind();

        }
    }

    public class Student
    {
        // Attributes Of Students
        public string studentName { get; set; }
        public string studentAddress { get; set; }
        public int studentRollNumber { get; set; }

        // Private Constructor
        public Student(string name, string address, int rollNumber)
        {
            studentName = name;
            studentAddress = address;
            studentRollNumber = rollNumber;
        }
    }
}