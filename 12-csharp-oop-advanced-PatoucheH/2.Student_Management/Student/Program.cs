using System.Xml.Linq;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new();
            SchoolReport report = new();

            Student student1 = new("Student A", 19);
            student1.AddGrade("French", 14);
            student1.AddGrade("History", 10);
            student1.AddGrade("French", 18);
            student1.AddGrade("Sciences", 16);
            
            Student student2 = new("Student B", 19);
            student2.AddGrade("French", 18);
            student2.AddGrade("History", 12);
            student2.AddGrade("Sciences", 17);
            
            Student student3 = new("Student C", 18);
            student3.AddGrade("French", 14);
            student3.AddGrade("History", 11);
            student3.AddGrade("Sciences", 8);


            school.AddStudent(student1);
            school.AddStudent(student2);
            school.AddStudent(student3);




            Console.WriteLine("List of all students : ");
            school.Liststudents();
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Find a student : ");
            school.FindStudent("Student A");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("List the top X students : ");
            foreach(Student student in school.ListTopStudents(1))
            {
                school.FindStudent(student.Name);
                Console.WriteLine("-----");
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Detailled report about one student : ");
            report.GenerateReport(student1);


            Console.WriteLine("Detailled report about all the student : ");
            report.GenerateOverallReport(school);



        }
    }
}
