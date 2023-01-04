using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentGradeTracker.Helpers
{
    public static class ValidationHelper
    {

        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for a valid email address
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" +
                             @"@" +
                             @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

            return Regex.IsMatch(email, pattern);
        }
        public static bool IsNotEmpty(List<string> values)
        {
            foreach (string value in values)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return false;
                }
            }
            return true;
        }



    }
}
