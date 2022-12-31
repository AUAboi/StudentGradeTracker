using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Exceptions
{
    public class GradeAlreadyExistsException : Exception
    {

        public GradeAlreadyExistsException() : base("Grade for this student in this semester subject already exists")
        {
        }

    }
}
