using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data;
using StudentGradeTracker.Helpers;
using StudentGradeTracker.Exceptions;

namespace StudentGradeTracker.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public List<Grade>? Grades { get; set; }


        /// <summary>
        /// Create student model from current instance
        /// </summary>
        public void create()
        {

            //add phone number validation later
            try
            {
                string query = "INSERT INTO Students (Name, Email, Phone) VALUES (@name, @email, @phone)";


                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(query, connection);
                    adapter.InsertCommand.Parameters.AddWithValue("@name", Name);
                    adapter.InsertCommand.Parameters.AddWithValue("@email", Email);
                    adapter.InsertCommand.Parameters.AddWithValue("@phone", Phone);

                    adapter.InsertCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while processing the request", ex);
            }
        }


        /// <summary>
        /// Updates student model from current instance
        /// </summary>
        public void update()
        {
            try
            {
                string query = "UPDATE Students SET Name = @name, Email = @email, Phone = @phone WHERE StudentID = @id";

                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@phone", Phone);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Failed to update student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update student", ex);
            }
        }
        /// <summary>
        /// Deletes student model using current instance
        /// </summary>
        public void delete()
        {
            try
            {
                string query = "DELETE FROM Students WHERE StudentID = @id";

                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.DeleteCommand = command;

                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete student", ex);
            }

        }


        /// <summary>
        /// Grabs all models from database
        /// </summary>
        public static List<Student> All()
        {

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                string query = "SELECT * FROM Students";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                DataTable table = dataSet.Tables[0];

                List<Student> students = new List<Student>();

                foreach (DataRow row in table.Rows)
                {
                    int id = (int)row["StudentID"];
                    string name = (string)row["Name"];
                    string email = (string)row["Email"];
                    string phone = (string)row["Phone"];

                    students.Add(new Student { ID = id, Name = name, Email = email, Phone = phone });
                }

                return students;

            }
        }



        /// <summary>
        /// Generate some sample stud
        /// </summary>

        public static void GenerateStudents(int count)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Student student = new Student
                {
                    Name = "Student " + (i + 1),
                    Email = "student" + (i + 1) + "@example.com",
                    Phone = "123-456-" + random.Next(1000, 10000)
                };
                student.create();
            }

        }

        /// <summary>
        /// Get Grades for the current instance of student
        /// </summary>
        /// 


        public List<Grade> GetGrades()
        {
            // Replace this with your database access layer
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                string query = "SELECT * FROM Students " +
                       "JOIN Grades ON Students.StudentId = Grades.StudentId " +
                       "WHERE Students.StudentId = @studentId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@studentId", ID);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                DataTable table = dataSet.Tables[0];
                List<Grade> grades = new List<Grade>();
                foreach (DataRow row in table.Rows)
                {
                    Grade grade = new Grade();
                    grade.Id = (int)row["Id"];
                    grade.StudentId = (int)row["StudentId"];
                    grade.Midterm = (float)row["Midterm"];
                    grade.Final = (float)row["Final"];
                    grade.CourseId = (int)row["CourseId"];
                    grade.Semester = (string)row["Semester"];
                    grade.Date = (DateTime)row["Date"];
                    grades.Add(grade);
                }
                return grades;

            }
        }

       

    }
}