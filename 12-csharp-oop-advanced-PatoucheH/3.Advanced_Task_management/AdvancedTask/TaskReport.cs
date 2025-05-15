using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask
{
    public class TaskReport
    {
        public void GenerateProjectReport (Project project, TaskManager taskManager)
        { 
            List<Task> completedTasks = new();
            List<Task> OverdueTasks = new();
            List<Task> pendingTasks = new();

            Project projectChoose = taskManager.projects.FirstOrDefault(p => p.Name == project.Name);
            foreach(Task task in projectChoose.Tasks)
            {
                if(task.IsCompleted) completedTasks.Add(task);
                else if (task.IsOverdue()) OverdueTasks.Add(task);
                else pendingTasks.Add(task);
            }
            Console.WriteLine($"Projet name : {projectChoose.Name}");
                Console.WriteLine("Completed tasks : ");
            foreach(Task task in completedTasks)
            {
                Console.WriteLine(task.Title);
            }
            Console.WriteLine("-----");

                Console.WriteLine("Overdue tasks : ");
            foreach(Task task in OverdueTasks)
            {
                Console.WriteLine(task.Title);
            }
            Console.WriteLine("-----");

                Console.WriteLine("pending tasks : ");
            foreach(Task task in pendingTasks)
            {
                Console.WriteLine(task.Title);
            }
            Console.WriteLine("-----");
        }


        public void GenerateUserReport(string user, TaskManager taskManager)
        {
            List<Task> tasksToUser = new();
            Console.WriteLine($"All the tasks of {user}");
            foreach(Project project in taskManager.projects)
            {
                foreach(Task task in project.Tasks)
                {
                    if (task.AssignTo == user)
                    {
                        tasksToUser.Add(task);
                        string status = "";
                        if (task.IsCompleted) status = "Completed";
                        else if (task.IsOverdue()) status = "Overdue";
                        else status = "Pending";
                        Console.WriteLine($"Task title : {task.Title}\nTask status : {status}");
                        Console.WriteLine("---");
                    }
                }
            }
            
        }

        public void GenerateSystemReport(TaskManager taskManager)
        {
            taskManager.GenerateReport();
        }
    }
}
  