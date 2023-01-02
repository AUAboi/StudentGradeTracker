using StudentGradeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Services
{
    public class StudentService
    {
        public double GetStudentCGPA(Student student)
        {
            GradeService gradeService = new GradeService();
            int totalCreditHours = student.Grades.Sum(grade => grade.Course.TotalCreditHours);

            double totalGradePoints = student.Grades.Sum(grade => grade.QualityPoints);

            double CGPA = totalGradePoints / totalCreditHours;

            return CGPA;
        }
    }
}
