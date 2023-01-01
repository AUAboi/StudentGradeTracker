using StudentGradeTracker.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGradeTracker.Helpers;

namespace StudentGradeTracker.Services
{
    public class CourseService
    {
        public Course? FindById(int id)
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();

                string queryString = "SELECT * FROM Courses WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        return null;
                    }

                    DataRow row = table.Rows[0];
                    Course course = new Course
                    {
                        Id = (int)row["Id"],
                        CourseName = (string)row["CourseName"],
                        CourseCode = (int)row["CourseCode"],
                        PracticalCreditHours = (int)row["PracticalCreditHours"],
                        TheoryCreditHours = (int)row["TheoryCreditHours"],
                        DepartmentCode = (string)row["DepartmentCode"]
                    };
                    return course;
                }
            }
        }


    }
}
