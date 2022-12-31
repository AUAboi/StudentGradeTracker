using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using StudentGradeTracker.Helpers;
using StudentGradeTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeTracker
{
    public partial class LoginForm : Form
    {
        private LoginService loginService = new LoginService();

        public LoginForm()
        {
            InitializeComponent();

            //Remove later
            //Test code
            usernameField.Text = "ahsan@gmail.com";
            passwordField.Text = "Password";
        }
      
        private void label2_Click(object sender, EventArgs e)
        {
            passwordField.Focus();

        }

        private void tryLogin()
        {
            if (!ValidationHelper.IsNotEmpty(new List<string> { usernameField.Text, passwordField.Text })
)
            {
                MessageBox.Show("One or more fields are not filled. Please fill them to proceed");
                return;
            }


            if (loginService.login(usernameField.Text, passwordField.Text))
            {
                MessageBox.Show("Successfully logged in!!");

                PageRouter.route(new Dashboard(), this);
                
                return;
            }
            passwordField.Text = "";
            MessageBox.Show(loginService.getErrorMessage());

            if (loginService.hasReachedMaxAttempts())
            {
                Close();
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            tryLogin();
        }
    }
}
