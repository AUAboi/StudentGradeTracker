using StudentGradeTracker.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public float Midterm { get; set; }
        public float Final { get; set; }
        public string Semester { get; set; } = string.Empty;
        public DateTime Date { get; set; }



        public bool DoesGradeExist()
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Grades WHERE StudentId = @studentId AND CourseId = @courseId AND Semester = @semester";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentId", this.StudentId);
                command.Parameters.AddWithValue("@courseId", this.CourseId);
                command.Parameters.AddWithValue("@semester", this.Semester);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }


    }

}
