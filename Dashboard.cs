using StudentGradeTracker.Components;
using StudentGradeTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeTracker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadData();
            studentsGridView.Columns["ID"].ReadOnly = true;
        }

        private void studentsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int studentId = (int)studentsGridView.Rows[e.RowIndex].Cells["ID"].Value;
            string studentName = (string)studentsGridView.Rows[e.RowIndex].Cells["Name"].Value;
            string studentEmail = (string)studentsGridView.Rows[e.RowIndex].Cells["Email"].Value;
            string studentPhone = (string)studentsGridView.Rows[e.RowIndex].Cells["Phone"].Value;
            try
            {
                new Student
                {
                    ID = studentId,
                    Name = studentName,
                    Email = studentEmail,
                    Phone = studentPhone
                }.update();
            } catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void loadData()
        {
            studentsGridView.DataSource = Student.All();

            // Check if the delete button column already exists
            if (!studentsGridView.Columns.Contains("deleteButton"))
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


                studentsGridView.Columns.Add(deleteButtonColumn);
            }
        }


        private void studentsGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                // Cancel the edit operation 
                e.Cancel = true;
            }
        }

        private void studentsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == studentsGridView.Columns["DeleteButton"].Index)
            {

                int studentId = (int)studentsGridView.Rows[e.RowIndex].Cells["ID"].Value;
                string studentName = (string)studentsGridView.Rows[e.RowIndex].Cells["Name"].Value;
                string studentEmail = (string)studentsGridView.Rows[e.RowIndex].Cells["Email"].Value;
                string studentPhone = (string)studentsGridView.Rows[e.RowIndex].Cells["Phone"].Value;

                try
                {
                    new Student
                    {
                        ID = studentId,
                        Name = studentName,
                        Email = studentEmail,
                        Phone = studentPhone
                    }.delete();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                loadData();
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudentCreateForm().ShowDialog();
        }
        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddGradeForm().ShowDialog();
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
