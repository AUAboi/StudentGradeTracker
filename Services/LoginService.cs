using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentGradeTracker.Helpers;

namespace StudentGradeTracker.Services
{
    class LoginService
    {

        private int attemptCount = 0;
        private int allowedCount = 3;

        private string errorMessage = "";



        public bool login(string username, string password)
        {
            if (hasReachedMaxAttempts())
            {
                setErrorMessage("Max attempt count reached");
                return false;
            }


            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                string query = "SELECT * FROM Users WHERE Email = @email";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@email", username);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                DataTable table = dataSet.Tables[0];

                if (table.Rows.Count == 0)
                {
                    attemptCount++;
                    setErrorMessage("Not Valid. Attempts remaining " + (allowedCount - attemptCount));
                    return false;
                }

                DataRow row = table.Rows[0];
                string hashedPassword = (string)row["Password"];

                if (VerifyPassword(password, hashedPassword))
                {
                    return true;
                }

                attemptCount++;
                setErrorMessage("Not Valid. Attempts remaining " + (allowedCount - attemptCount));
                return false;
            }

        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }


        public bool hasReachedMaxAttempts()
        {
            return attemptCount == allowedCount;
        }

        private void setErrorMessage(string error)
        {
            errorMessage = error;

        }

        public string getErrorMessage()
        {
            return errorMessage;
        }

    }
}
