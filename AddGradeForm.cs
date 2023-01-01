using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentGradeTracker.Helpers;
using StudentGradeTracker.Models;
using StudentGradeTracker.Services;

namespace StudentGradeTracker
{
    public partial class AddGradeForm : Form
    {
        public AddGradeForm()
        {
            InitializeComponent();
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            List<Student> students = Student.All();

            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "Name"; 
            comboBox1.ValueMember = "Id";
            comboBox1.Refresh();

            //Sets a default
            comboBox1.SelectedIndex = 0;

            
            List<Course> courses = Course.All();
            comboBox2.DataSource = courses;
            comboBox2.DisplayMember = "CourseName";
            comboBox2.ValueMember = "Id";
            comboBox2.Refresh();

            //Sets a default
            comboBox2.SelectedIndex = 0;
        }

        private void mainButton1_Click(object sender, EventArgs e)
        {
      
            if (ValidationHelper.IsNotEmpty(new List<string> { midTerm.Text, finalTerm.Text }))
            { 
                MessageBox.Show("Fill all fields"); 
                return; 
            }

            GradeService gradeService = new GradeService();

            Course? selectedCourse = comboBox2.SelectedItem as Course;
            Student? selectedStudent = comboBox1.SelectedItem as Student;

            if (selectedCourse == null || selectedStudent == null)
            {
                MessageBox.Show("Please select a course and a student.");
                return;
            }

            try
            {
                gradeService.addStudentGrade(selectedStudent, new Grade
                {
                    StudentId = selectedStudent.ID,
                    CourseId = selectedCourse.Id,
                    Midterm = Convert.ToDouble(midTerm.Text),
                    Final = Convert.ToDouble(finalTerm.Text),
                    Semester = semester.Text,
                    Date = date.Value,
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Added successfully!");

            midTerm.Text = "";
            finalTerm.Text = "";
        }
    }
}
