namespace AdvancedTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            TaskReport taskReport = new TaskReport();

            Project project1 = new("First projet");
            Project project2 = new("Second projet");
            Project project3 = new("Thrird projet");
            Project project4 = new("Fourth projet");

            Task task1 = new("Walking outside", "Walk during 15 min", "Myself", new DateTime(2025, 4, 4), PriorityLevel.Low);
            Task task2 = new("Do chores", "Do the dishes", "Myself", DateTime.Now.AddDays(1), PriorityLevel.Critical);
            Task task3 = new("Learn C#", "Follow the cursus of C# by Becode", "Jean", new DateTime(2025, 5, 13), PriorityLevel.Critical);
            Task task4 = new("Learn F#", "Follow the cursus on Exercism", "Pierre", DateTime.Now.AddDays(10), PriorityLevel.Medium);
            Task task5 = new("Learn Visul Basic", "Find ressources to learn that language", "Jean", DateTime.Now.AddDays(2), PriorityLevel.Low);
            Task task6 = new("Make the meal", "Make food for this evening", "Jean", new DateTime(2025, 3, 6), PriorityLevel.Medium);
            Task task7 = new("Buy a Moto", "Buy a new moto", "Pierre", new DateTime(2025, 1, 31), PriorityLevel.High);

            task2.IsOverdue();
            task7.IsOverdue();

            project1.AddTask(task1);
            project1.AddTask(task2);
            project1.AddTask(task3);
            project1.AddTask(task4);
            project2.AddTask(task5);
            project2.AddTask(task6);
            project2.AddTask(task7);

            project1.CompleteTask("Walking outside");
            project2.CompleteTask("Make the meal");

            taskManager.AddProject(project1);
            taskManager.AddProject(project2);
            taskManager.AddProject(project3);
            taskManager.AddProject(project4);

            Console.WriteLine("List all overdue Tasks : ");
            taskManager.ListAllOverdueTasks();
            Console.WriteLine("-----");


            Console.WriteLine("List all High Priority tasks : ");
            taskManager.ListAllTasksByPriority(PriorityLevel.High);
            Console.WriteLine("-----");
            
            Console.WriteLine("List all tasks for a given user : ");
            taskManager.GetTaskByAssignedUser("Jean");
            Console.WriteLine("-----");

            Console.WriteLine("Report of all the projects in the manager : ");
            taskManager.GenerateReport();
            Console.WriteLine("-----");
            
            Console.WriteLine("Report all the infos about a project : ");
            taskReport.GenerateProjectReport(project1, taskManager);
            Console.WriteLine("-----");
            
            Console.WriteLine("Report of all the infos about a user : ");
            taskReport.GenerateUserReport("Jean ", taskManager);
            Console.WriteLine("-----");



        }
    }
}
