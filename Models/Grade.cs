using StudentGradeTracker.Helpers;
using StudentGradeTracker.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentGradeTracker.Models
{
    public class Grade
    {

        private GradeService gradeService = new GradeService();
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double Midterm { get; set; }
        public double Final { get; set; }
        public string Semester { get; set; } = string.Empty;

        public string LetterGrade
        {
            get
            {
                return gradeService.GetLetterGrade(this.Percentage);
            }
        }
        public DateTime Date { get; set; }

        public double Percentage {
            get
            {
                return ((Midterm + Final) / (Course.TotalMarks)) * 100;
            }
           }
        //Fetch associated course
        public Course Course
        {
            get
            {
                CourseService courseService = new CourseService();
                Course course = courseService.FindById(CourseId);
                return course;
            }
        }

        public double QualityPoints
        {
            get
            {
               double  qualityPoints = gradeService.GetGradePoint(Percentage) * Course.TotalCreditHours;
               return qualityPoints;
            }
        }

        public static List<Grade> All()
        {
            List<Grade> grades = new List<Grade>();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Grades";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Grade grade = new Grade();
                    grade.Id = (int)row["Id"];
                    grade.StudentId = (int)row["StudentId"];
                    grade.Midterm = (double)row["Midterm"];
                    grade.Final = (double)row["Final"];
                    grade.CourseId = (int)row["CourseId"];
                    grade.Semester = (string)row["Semester"];
                    grade.Date = (DateTime)row["Date"];
                    grades.Add(grade);
                }
            }

            return grades;
        }


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

        public void delete()
        {
            try
            {
                string query = "DELETE FROM Grades WHERE Id = @id";

                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.DeleteCommand = command;

                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete grade", ex);
            }

        }

    }

}
