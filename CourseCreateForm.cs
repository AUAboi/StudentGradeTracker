using StudentGradeTracker.Helpers;
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
    public partial class CourseCreateForm : Form
    {
        public CourseCreateForm()
        {
            InitializeComponent();
        }

        private void mainButton1_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsNotEmpty(
                new List<string> { 
                    courseNameField.Text, 
                    practicalField.Text, 
                    theoryField.Text, 
                    courseCodeField.Text, 
                    depCodeField.Text 
                })
                )
            {
                MessageBox.Show("Fields cannot be empty");
            }

            try
            {
                new Course
                {
                    CourseName = courseNameField.Text,
                    PracticalCreditHours = Convert.ToInt32(practicalField.Text),
                    TheoryCreditHours = Convert.ToInt32(theoryField.Text),
                    CourseCode = Convert.ToInt32(courseCodeField.Text),
                    DepartmentCode = depCodeField.Text
                }.create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Course created");
            courseNameField.Text = "";
            practicalField.Text = "";
            theoryField.Text = "";
            courseCodeField.Text = "";
            depCodeField.Text = "";
        }

        private void field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
