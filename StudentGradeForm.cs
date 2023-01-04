using StudentGradeTracker.Components;
using StudentGradeTracker.Models;
using StudentGradeTracker.Services;
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
    public partial class StudentGradeForm : Form
    {
        public StudentGradeForm()
        {
            InitializeComponent();
        }

        private void StudentGradeForm_Load(object sender, EventArgs e)
        {
            List<Student> students = Student.All();

            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.Refresh();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void mainButton1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            studentGradeTable.Rows.Clear();
            studentGradeTable.Refresh();

            Student? selectedStudent = comboBox1.SelectedItem as Student;

            GradeService gradeService = new GradeService();
            StudentService studentService = new StudentService();

            if (selectedStudent == null)
            {
                MessageBox.Show("Select a student");
                return;
            }

            List<Grade> grades = selectedStudent.Grades.Where(g => g.Semester == comboBox2.Text).ToList();

            foreach (Grade grade in grades)
            {
                int rowIndex = studentGradeTable.Rows.Add(grade.Id, grade.Course.CourseName, grade.Course.TotalMarks, grade.Midterm, grade.Final, grade.Percentage.ToString("#.##"), grade.LetterGrade, grade.QualityPoints.ToString("#.##"));
            }
            

            gpaText.Text = gradeService.CalculateGPA(grades, comboBox2.Text).ToString("#.##");
            cgpaText.Text = studentService.GetStudentCGPA(selectedStudent).ToString("#.##");

            if (!studentGradeTable.Columns.Contains("deleteButton"))
            {
                // Add the delete button column if it does not exist
                DeleteButton db = new DeleteButton();
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "deleteButton";
                deleteButtonColumn.HeaderText = "DeleteButton";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                deleteButtonColumn.FlatStyle = db.FlatStyle;
                deleteButtonColumn.DefaultCellStyle.BackColor = db.BackColor;
                deleteButtonColumn.DefaultCellStyle.ForeColor = db.ForeColor;

                studentGradeTable.Columns.Add(deleteButtonColumn);
            }
        }

        private void studentGradeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == studentGradeTable.Columns["DeleteButton"].Index)
            {

                int gradeId = (int)studentGradeTable.Rows[e.RowIndex].Cells["ID"].Value;

                try
                {
                    new Grade
                    {
                        Id = gradeId
                    }.delete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                loadData();
            }
        }
    }
}
