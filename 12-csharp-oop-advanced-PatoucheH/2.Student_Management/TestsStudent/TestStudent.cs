using Student;

namespace TestsStudent
{
    public class TestStudent
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddGrade()
        {

            Student.Student student1 = new("A", 19);
            student1.AddGrade("French", 18);
            student1.AddGrade("History", 9);
            student1.AddGrade("Sciences", 15);

            Assert.That(student1.Grades, Has.Count.EqualTo(3));


        }

        [Test]
        public void TestAddGradeSameSubject()
        {
            Student.Student student2 = new("B", 20);
            student2.AddGrade("History", 15);
            student2.AddGrade("History", 12);

            Assert.That(student2.Grades, Has.Count.EqualTo(1));
            Assert.That(student2.Grades[0].Score, Is.EqualTo(27));

        }


        [Test]

        public void TestGetAverageGrade()
        {
            Student.Student student3 = new("C", 20);
            student3.AddGrade("Sciences", 20);
            student3.AddGrade("Sciences", 12);

            Assert.That(student3.GetAverageGrade(), Is.EqualTo(16.0d));
        }
    }
}
