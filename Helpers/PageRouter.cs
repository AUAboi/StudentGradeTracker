using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Helpers
{
    class PageRouter
    {
        public static void route(Form to, Form from)
        {
            to.Show();
            from.Hide();
        }

        public static void open(Form form)
        {
            form.Show();
        }

        public static void close(Form form)
        {
            form.Close();
        }
    }
}
