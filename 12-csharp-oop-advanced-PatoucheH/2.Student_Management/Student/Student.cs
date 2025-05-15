using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public string Name;
        public int Age;
        public List<Grade>? Grades;

        public Student(string name, int age)  
        {
            Name = name;
            Age = age;
            Grades = new();
        }

        public void AddGrade(string subject, int score)
        {
                Grade newGrade = new() { Subject = subject, Score = score };
            if (Grades.Count > 0)
            {
                foreach (Grade grade in Grades)
                {
                    if (grade.Subject == subject)
                    {
                        grade.Score += score;
                        return;
                    }
                }
            }
                Grades.Add(newGrade);
        }

        public double GetAverageGrade()
        {
            double result = 0.00d;
            int counter = 1;
            foreach(Grade grade in Grades)
            {
                result += (double) grade.Score;
                counter++;
            }
            return result / (double) counter;
        }

        public void ListGrades()
        {
            foreach(Grade grade in Grades)
            {
                Console.WriteLine($"{grade.Subject.PadRight(15)} : {grade.Score}");
            }
        }
    }
}
