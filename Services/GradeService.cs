using StudentGradeTracker.Exceptions;
using StudentGradeTracker.Helpers;
using StudentGradeTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Services
{
    public class GradeService
    {
        public void addStudentGrade(Student student, Grade grade)
        {
            if (grade.DoesGradeExist()) throw new GradeAlreadyExistsException();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                string query = "INSERT INTO Grades (StudentId,  Midterm, Final, CourseId, Semester, Date) VALUES (@studentId, @midterm, @final, @courseId, @semester, @date)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentId", student.ID);
                command.Parameters.AddWithValue("@midterm", grade.Midterm);
                command.Parameters.AddWithValue("@final", grade.Final);
                command.Parameters.AddWithValue("@courseId", grade.CourseId);
                command.Parameters.AddWithValue("@semester", grade.Semester);
                command.Parameters.AddWithValue("@date", grade.Date);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public double CalculateGPA(List<Grade> grades, string semester)
        {
            double totalQualityPoints = grades.Where(g => g.Semester == semester)
                                             .Sum(g => g.QualityPoints);

            double totalCreditHours = grades.Where(g => g.Semester == semester)
                                           .Select(g => g.Course.TotalCreditHours)
                                           .Sum();

            return totalQualityPoints / totalCreditHours;
        }

        public List<Grade> GetGradesBySemester(int studentId, string semester)
        {
            List<Grade> grades = new List<Grade>();

            string query = "SELECT * FROM Grades WHERE StudentId = @studentId AND Semester = @semester";

            using (SqlConnection conn = new SqlConnection(Connection.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@semester", semester);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Grade grade = new Grade();
                    grade.Id = (int)row["Id"];
                    grade.StudentId = (int)row["StudentId"];
                    grade.Midterm = (int)row["Midterm"];
                    grade.Final = (int)row["Final"];
                    grade.CourseId = (int)row["CourseId"];
                    grade.Semester = (string)row["Semester"];
                    grade.Date = (DateTime)row["Date"];
                    grades.Add(grade);
                }
            }

            return grades;
        }


    }
}
