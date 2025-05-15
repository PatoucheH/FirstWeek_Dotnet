using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class School
    {
        public List<Student>? students = new();


        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        
        public void Liststudents()
        {
            if (students.Count > 0)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine($"Name : {student.Name} - Age : {student.Age} - Average Grade :" +
                        $" {student.GetAverageGrade()}");
                }
            }else
            {
                throw new Exception("Students List is empty ! ");
            }
        }

        public Student FindStudent(string name)
        {
            Student? studentToFind = students.FirstOrDefault(student => student.Name == name);
            if (studentToFind != null)
            {
                Console.WriteLine($"Student name : {studentToFind.Name}");
                studentToFind.ListGrades();
                Console.WriteLine($"Average grade : {studentToFind.GetAverageGrade()}");
                return studentToFind;
            }else
            {
                throw new Exception("Student don't exists ! ");
            }
        }

        public List<Student> ListTopStudents (int topN)
        {
            List<Student> topStudent = new List<Student>();
            for(int i = 0; i <= students.Count; i++)
            {
                
                if( topStudent.Count < topN)
                {
                    topStudent.Add(students[i]);
                }
            }
            return topStudent;
        }
    }
}
