using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class SchoolReport
    {
        public void GenerateReport(Student student)
        {
            Console.WriteLine($"Student name \t: {student.Name}");
            Console.WriteLine("Subect\t\t  Score");
            Console.WriteLine("-----");

            student.ListGrades();

            Console.WriteLine("-----");
            Console.WriteLine($"Average grade \t: {student.GetAverageGrade()}");
            
            Console.WriteLine("--------------------");
        }

        public void GenerateOverallReport(School school)
        {
            if (school.students.Count > 0) { 
                foreach (Student student in school.students)
                {
                    GenerateReport(student);
                }
            }
            else
            {
                throw new Exception("School list of students is empty ! ");
            }
        }

    }
}
