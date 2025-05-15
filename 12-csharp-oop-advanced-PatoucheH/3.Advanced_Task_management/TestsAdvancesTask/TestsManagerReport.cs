using NUnit.Framework;
using System;
using System.IO;
using System.Collections.Generic;
using AdvancedTask;

namespace TestsAdvancesTask;

    public class TaskReportTests
    {
        private TaskManager taskManager;
        private TaskReport report;
        private Project project;

        [SetUp]
        public void Setup()
        {
            taskManager = new TaskManager();
            report = new TaskReport();

            project = new Project("Project A");

            var completedTask = new AdvancedTask.Task("Completed Task", "Done", "Alice", DateTime.Now.AddDays(2), PriorityLevel.Low);
            completedTask.IsCompleted = true;

            var overdueTask = new AdvancedTask.Task("Overdue Task", "Late", "Bob", DateTime.Now.AddDays(-2), PriorityLevel.High);

            var pendingTask = new AdvancedTask.Task("Pending Task", "Ongoing", "Charlie", DateTime.Now.AddDays(3), PriorityLevel.Medium);

            project.AddTask(completedTask);
            project.AddTask(overdueTask);
            project.AddTask(pendingTask);

            taskManager.AddProject(project);
        }

        [Test]
        public void GenerateProjectReportPrintCorrectlyClassifiedTasks()
        {
            var sw = new StringWriter();
            Console.SetOut(sw);

            report.GenerateProjectReport(project, taskManager);
            string output = sw.ToString();

            Assert.That(output, Does.Contain("Projet name : Project A"));
            Assert.That(output, Does.Contain("Completed tasks :"));
            Assert.That(output, Does.Contain("Completed Task"));
            Assert.That(output, Does.Contain("Overdue tasks :"));
            Assert.That(output, Does.Contain("Overdue Task"));
            Assert.That(output, Does.Contain("pending tasks :"));
            Assert.That(output, Does.Contain("Pending Task"));
        }

        [Test]
        public void GenerateUserReportPrintOnlyTasksOfUser()
        {
            var sw = new StringWriter();
            Console.SetOut(sw);

            report.GenerateUserReport("Bob", taskManager);
            string output = sw.ToString();

            Assert.That(output, Does.Contain("All the tasks of Bob"));
            Assert.That(output, Does.Contain("Task title : Overdue Task"));
            Assert.That(output, Does.Contain("Task status : Overdue"));
            Assert.That(output, Does.Not.Contain("Pending Task")); 
        }

        [Test]
        public void GenerateSystemReportPrintProjectSummary()
        {
            var sw = new StringWriter();
            Console.SetOut(sw);

            report.GenerateSystemReport(taskManager);
            string output = sw.ToString();

            Assert.That(output, Does.Contain("Project A"));
            Assert.That(output, Does.Contain("Total tasks"));
            Assert.That(output, Does.Contain("Total completed tasks : 1"));
            Assert.That(output, Does.Contain("Total overdue tasks : 1"));
        }
    }

