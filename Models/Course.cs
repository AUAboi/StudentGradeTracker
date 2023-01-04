using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGradeTracker.Helpers;
using StudentGradeTracker.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace StudentGradeTracker.Models
{
    public class Course
    {
        public const int CREDIT_HOUR_MARKS = 20;
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public int CourseCode { get; set; } 
        public int PracticalCreditHours { get; set; }
        public int TheoryCreditHours { get; set; }
        public string DepartmentCode { get; set; } = string.Empty;

        public void create()
        {
            try
            {
                string query = "INSERT INTO Courses (CourseName, PracticalCreditHours, TheoryCreditHours, CourseCode, DepartmentCode) VALUES (@name, @practical, @theory, @ccode, @dcode)";


                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(query, connection);
                    adapter.InsertCommand.Parameters.AddWithValue("@name", this.CourseName);
                    adapter.InsertCommand.Parameters.AddWithValue("@practical", this.PracticalCreditHours);
                    adapter.InsertCommand.Parameters.AddWithValue("@theory", this.TheoryCreditHours);
                    adapter.InsertCommand.Parameters.AddWithValue("@ccode", this.CourseCode);
                    adapter.InsertCommand.Parameters.AddWithValue("@dcode", this.DepartmentCode);

                    adapter.InsertCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
                //throw new Exception("An error occurred while processing the request", ex);
            }
        }
        public int TotalCreditHours
        {
            get
            {
                return TheoryCreditHours + PracticalCreditHours;
            }
        }

        public int TotalMarks
        {
            get
            {
                return this.TotalCreditHours * CREDIT_HOUR_MARKS;
            }
        }



        public static List<Course> All()
        {
            string query = "SELECT * FROM Courses";

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                DataTable table = dataSet.Tables[0];
                List<Course> courses = new List<Course>();
                foreach (DataRow row in table.Rows)
                {
                    Course course = new Course
                    {
                        Id = (int)row["Id"],
                        CourseName = (string)row["CourseName"],
                        CourseCode = (int)row["CourseCode"],
                        PracticalCreditHours = (int)row["PracticalCreditHours"],
                        TheoryCreditHours = (int)row["TheoryCreditHours"],
                        DepartmentCode = (string)row["DepartmentCode"]
                    };
                    courses.Add(course);
                }
                return courses;
            }
        }
    }

}
