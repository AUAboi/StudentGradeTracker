using StudentGradeTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeTracker
{
    public partial class ViewAllGradesForm : Form
    {
        public ViewAllGradesForm()
        {
            InitializeComponent();
        }

        private void ViewAllGradesForm_Load(object sender, EventArgs e)
        {
            List<Student> students = Student.All();

            foreach (Student student in students)
            {
                foreach (Grade grade in student.Grades)
                {
                    // Add a row to the data grid view for each grade
                    gradeTable.Rows.Add(student.Name, grade.Course.CourseName, grade.Midterm, grade.Final, grade.Semester, grade.Date);
                }
            }
        }
    }
}
