using NUnit.Framework;
using System;
using AdvancedTask;
using System.Collections.Generic;

namespace TestsAdvancesTask;

    public class ProjectTests
    {
        private Project project;

        [SetUp]
        public void Setup()
        {
            project = new Project("Test Project");
        }

        [Test]
        public void AddTaskToList()
        {
            var task = new AdvancedTask.Task("Task1","Do the task1", "Jean", DateTime.Now.AddDays(1), PriorityLevel.Medium);
            project.AddTask(task);
            Assert.That(project.Tasks, Does.Contain(task));
        }

        [Test]
        public void GetOverdueTasksReturnOnlyOverdueTasks()
        {
        var task1 = new AdvancedTask.Task("Task1", "Do the task1", "Jean", new DateTime(2025,5,5), PriorityLevel.Low);
        var task2= new AdvancedTask.Task("Task2", "Do the task2", "Me", DateTime.Now.AddDays(1), PriorityLevel.High);

            project.AddTask(task1);
            project.AddTask(task2);

            var overdueTasks = project.GetOverdueTasks();

            Assert.That(overdueTasks.Count, Is.EqualTo(1));
            Assert.That(overdueTasks[0].Title, Is.EqualTo("Task1"));
        }

        [Test]
        public void CompleteTaskSetTaskAsCompleted()
        {
            var task = new AdvancedTask.Task("To Complete","TAks to Complete", "Jean", DateTime.Now.AddDays(1), PriorityLevel.Medium);
            project.AddTask(task);

            project.CompleteTask("To Complete");

            Assert.That(task.IsCompleted, Is.True);
        }

        [Test]
        public void CompleteTaskNonExistingTaskThrowException()
        {
            var ex = Assert.Throws<Exception>(() => project.CompleteTask("Unknown Task"));
            Assert.That(ex.Message, Is.EqualTo("No task with the title Unknown Task"));
        }

        [Test]
        public void ListCompletedTasksListOnlyCompletedTasks()
        {
            var task1 = new AdvancedTask.Task("Done", "Task done", "Me", DateTime.Now, PriorityLevel.Low);
            var task2 = new AdvancedTask.Task("Pending","Task Pending", "Jean", DateTime.Now, PriorityLevel.High);

            task1.CompleteTask();

            project.AddTask(task1);
            project.AddTask(task2);

            using var sw = new System.IO.StringWriter();
            Console.SetOut(sw);

            project.ListCompletedTasks();

            string output = sw.ToString().Trim();
            Assert.That(output, Is.EqualTo("Done"));
        }
    }

