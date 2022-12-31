using StudentGradeTracker.Exceptions;
using StudentGradeTracker.Helpers;
using StudentGradeTracker.Models;
using System;
using System.Collections.Generic;
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
    }
}
