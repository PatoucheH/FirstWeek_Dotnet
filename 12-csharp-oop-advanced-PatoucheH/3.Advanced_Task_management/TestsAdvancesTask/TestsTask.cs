namespace TestsAdvancesTask;

public class TestsTask
{
    AdvancedTask.Task task1 = new("Walking outside", "Walk during 15 min", "Myself", new DateTime(2025, 4, 4), PriorityLevel.Low);
    AdvancedTask.Task task2 = new("Learn C#", "Follow the becode cursus", "Myself", new DateTime(2025, 9, 11), PriorityLevel.High);
    AdvancedTask.Task task3 = new("Learn C#", "Follow the cursus of C# by Becode", "Jean", new DateTime(2025, 5, 12), PriorityLevel.Critical);

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestTaskCompleted()
    {
        task1.CompleteTask();

        Assert.That(task1.IsCompleted, Is.True);
    }
    
    [Test]
    public void TestTaskNotCompleted()
    {

        Assert.That(task2.IsCompleted, Is.False);
    }

    [Test]  
    public void TestTaskIsOverdue()
    {
        bool result = task3.IsOverdue();

        Assert.That(result, Is.True);
    }
    
    [Test]  
    public void TestTaskIsNotOverdue()
    {
        bool result = task2.IsOverdue();

        Assert.That(result, Is.False);
    }
}
