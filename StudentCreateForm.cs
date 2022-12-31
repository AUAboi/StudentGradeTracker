using StudentGradeTracker.Helpers;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentGradeTracker
{
    public partial class StudentCreateForm : Form
    {
        public StudentCreateForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            string name = nameField.Text;
            string email = emailField.Text;
            string phone = phoneField.Text;

            if (!ValidationHelper.IsNotEmpty(new List<string> { name, email, phone }))
            {
                MessageBox.Show("Fields can't be empty");
                return;
            }

            if (!ValidationHelper.IsValidEmail(email)) { MessageBox.Show("Type Valid Email"); return;  }

            try
            {
                new Student
                {
                    Name = nameField.Text,
                    Email = emailField.Text,
                    Phone = phoneField.Text,
                }.create();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }


            nameField.Text = "";
            emailField.Text = "";
            phoneField.Text = "";

            //Get the dashboard form instance
            Dashboard dashboard = (Dashboard)Application.OpenForms["Dashboard"];
            dashboard.loadData();

            MessageBox.Show("Student Created!!");

        }
    }
}
