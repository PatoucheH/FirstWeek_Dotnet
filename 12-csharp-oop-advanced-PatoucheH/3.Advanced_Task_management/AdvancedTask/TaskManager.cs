using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask
{
    public class TaskManager
    {
        public List<Project> projects = new();


        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        public List<Task> GetTaskByAssignedUser(string user)
        {
            List<Task> tasks = new();

            foreach (Project project in projects)
            {
                foreach (Task task in project.Tasks)
                {
                    if (task.AssignTo == user)
                    { 
                    tasks.Add(task);
                    Console.WriteLine(task.Title);
                    }
                }
            }
            return tasks;
        }


        public void ListAllOverdueTasks()
        {
            foreach (Project project in projects)
            {
                foreach (Task task in project.Tasks)
                {
                    if (task.IsOverdue()) Console.WriteLine(task.Title);
                }
            }
        }

        public void ListAllTasksByPriority(PriorityLevel priority)
        {
            foreach (Project project in projects)
            {
                foreach (Task task in project.Tasks)
                {
                    if (task.Priority == priority) Console.WriteLine(task.Title);
                }
            }
        }

        public void ListTasksByProject(string projectName)
        {
            foreach (Project project in projects)
            {
                if (project.Name == projectName)
                {
                    foreach (Task task in project.Tasks)
                    {
                        Console.WriteLine(task.Title);
                    }
                }
            }
        }


        public void GenerateReport ()
        {
            foreach(Project project in projects)
            {
                int totalTasks = 0;
                int completedTasks = 0;
                int overdueTasks = 0;

                foreach (Task task in project.Tasks) 
                {
                    if (task.IsOverdue()) overdueTasks++;
                    if (task.IsCompleted) completedTasks++;
                    totalTasks++;
                }

                Console.WriteLine(project.Name);
                Console.WriteLine("---");
                Console.WriteLine($"Total tasks : {totalTasks}");
                Console.WriteLine($"Total completed tasks : {completedTasks}");
                Console.WriteLine($"Total overdue tasks : {overdueTasks}");
                Console.WriteLine("----------");
            }
        }
    }
}
