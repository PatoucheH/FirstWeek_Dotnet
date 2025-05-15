using Student;
    using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestsStudent;

public class TestSchool
{


        private School school;
        private Student.Student student1;
        private Student.Student student2;

        [SetUp]
        public void Setup()
        {
            school = new School();
            student1 = new Student.Student("Alice", 20);
            student1.AddGrade("French", 15);
            student1.AddGrade("History", 18);

            student2 = new Student.Student("Bob", 22);
            student2.AddGrade("French", 12);
            student2.AddGrade("History", 14);
        }

        [Test]
        public void AddStudentIncreaseCount()
        {
            school.AddStudent(student1);
            Assert.That(school.students.Count, Is.EqualTo(1));
        }

        [Test]
        public void ListstudentsThrowException_IfListEmpty()
        {
            Assert.Throws<Exception>(() => school.Liststudents(), "Students List is empty !");
        }

        [Test]
        public void FindStudentReturnCorrectStudent()
        {
            school.AddStudent(student1);
            var found = school.FindStudent("Alice");
            Assert.That(found.Name, Is.EqualTo("Alice"));
        }

        [Test]
        public void FindStudentThrowExceptionIfNotFound()
        {
            school.AddStudent(student1);
            Assert.Throws<Exception>(() => school.FindStudent("Charlie"), "Student don't exists !");
        }

        [Test]
        public void ListTopstudentsReturnTopStudentByGrade()
        {
            school.AddStudent(student1);
            school.AddStudent(student2); 

            var top = school.ListTopstudents(1);
            Assert.That(top.Count, Is.EqualTo(1));
            Assert.That(top[0].Name, Is.EqualTo("Alice"));
        }
    
}

