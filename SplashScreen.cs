using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentGradeTracker.Helpers;

namespace StudentGradeTracker
{
    public partial class SplashScreen : Form
    {

        private const int SPLASH_LOAD_PLACEHOLDER = 1000;
        public SplashScreen()
        {
            InitializeComponent();
        }


        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();
            PageRouter.route(new LoginForm(), this);
            //router.route(new LoginForm(), this);
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            splashTimer.Interval = SPLASH_LOAD_PLACEHOLDER;
            splashTimer.Start();
        }
    }
}
