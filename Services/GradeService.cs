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

        public string GetLetterGrade(double percentage)
        {
            if (percentage >= 90)
            {
                return "A+";
            }
            else if (percentage >= 85)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "A-";
            }
            else if (percentage >= 70)
            {
                return "B+";
            }
            else if (percentage >= 65)
            {
                return "B";
            }
            else if (percentage >= 60)
            {
                return "B-";
            }
            else if (percentage >= 50)
            {
                return "C+";
            }
            else if (percentage >= 45)
            {
                return "C";
            }
            else if (percentage >= 40)
            {
                return "C-";
            }
            else if (percentage >= 30)
            {
                return "D+";
            }
            else if (percentage >= 25)
            {
                return "D";
            }
            else if (percentage >= 20)
            {
                return "D-";
            }
            else
            {
                return "F";
            }
        }
      
        public double GetGradePoint(double percentage)
        {

            double l = percentage % 10;
            double gradePoint = 0;
            if (percentage < 50)
            {
                gradePoint = 1 + l / 10;
            }
            else if (percentage < 60)
            {
                gradePoint = 2 + (l / 100) * 7;
            }
            else if (percentage < 65)
            {
                gradePoint = 2.7 + (l / 100) * 6;
            }
            else if (percentage <= 84)
            {
                int temp = (int)(85 - percentage);
                double tempNum = -0.05;
                for (int i = 20; i >= temp; i--)
                {
                    tempNum += 0.05;
                }
                gradePoint = 3 + tempNum;
            }
            else if (percentage >= 85)
            {
                gradePoint = 4;
            }
            return gradePoint;
        }

    }
}
