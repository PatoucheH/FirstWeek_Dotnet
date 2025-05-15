using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestsAdvancesTask;
    public class TaskManagerTests
    {
        private AdvancedTask.TaskManager taskManager;

        [SetUp]
        public void Setup()
        {
            taskManager = new AdvancedTask.TaskManager();
        }

        [Test]
        public void AddProjectAddProjectToList()
        {
            var project = new AdvancedTask.Project("Test Project");
            taskManager.AddProject(project);

            Assert.That(taskManager.projects, Has.Exactly(1).SameAs(project));
        }

        [Test]
        public void GetTaskByAssignedUserReturnOnlyTasksAssignedToUser()
        {
            var project = new AdvancedTask.Project("Project 1");
            AdvancedTask.Task task1 = new("Task1", "Do task 1", "Jean", DateTime.Now.AddDays(2), PriorityLevel.Low);
            AdvancedTask.Task task2 = new("Do chores", "Do the dishes", "Myself", DateTime.Now.AddDays(1), PriorityLevel.Critical);
            project.AddTask(task1);
            project.AddTask(task2);
            taskManager.AddProject(project);
            
            var sw = new StringWriter();
            Console.SetOut(sw);

            var result = taskManager.GetTaskByAssignedUser("Jean");

        Assert.That(result, Has.Count.EqualTo(1));
            Assert.That(result[0].Title, Is.EqualTo("Task1"));
        }

        [Test]
        public void GetTaskByAssignedUserReturnEmptyList_IfNoTasksAssignedToUser()
        {
            var project = new AdvancedTask.Project("Project 1");
            project.Tasks.Add(new AdvancedTask.Task("Walking outside", "Walk during 15 min", "Myself", new DateTime(2025, 4, 4), PriorityLevel.Low));

            taskManager.AddProject(project);

            var result = taskManager.GetTaskByAssignedUser("Alice");

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void IsOverdueReturnTrueIfTaskIsNotCompletedAndPastDueDate()
        {
            var task = new AdvancedTask.Task("Walking outside", "Walk during 15 min", "Myself", new DateTime(2025, 4, 4), PriorityLevel.Low);

        Assert.That(task.IsOverdue(), Is.True);
        }

        [Test]
        public void IsOverdueReturnFalseIfTaskIsCompleted()
        {
            var task = new AdvancedTask.Task("Walking outside", "Walk during 15 min", "Myself",DateTime.Now.AddDays(2), PriorityLevel.Low);
        task.IsCompleted = true;

            Assert.That(task.IsOverdue(), Is.False);
        }

        [Test]
        public void IsOverdueReturnFalseIfTaskIsNotDueYet()
        {
            var task = new AdvancedTask.Task("Walking outside", "Walk during 15 min", "Myself",DateTime.Now.AddDays(4), PriorityLevel.Low);

            Assert.That(task.IsOverdue(), Is.False);
        }
    }

