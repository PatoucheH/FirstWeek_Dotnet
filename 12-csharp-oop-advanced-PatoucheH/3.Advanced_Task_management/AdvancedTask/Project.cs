using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask
{
    public class Project
    {
        public string Name;
        public List<Task> Tasks;

        public Project(string name)
        {
            Name = name;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public List<Task> GetOverdueTasks()
        {
            List<Task> overdueTasks = new();

            foreach(Task task in Tasks)
            {
                if(task.IsOverdue()) overdueTasks.Add(task); 
            }

            return overdueTasks;
        }

        public void ListTasksByPriority(PriorityLevel priority)
        {
            foreach(Task task in Tasks)
            {
                if(task.Priority == priority)
                {
                    Console.WriteLine(task.Title);
                }
            }
        }

        public void CompleteTask(string title)
        {
            Task? taskToComplete = Tasks.FirstOrDefault(task => task.Title == title);
            if (taskToComplete == null) throw new Exception($"No task with the title {title}");
            else taskToComplete.CompleteTask();
        }

        public void ListTasksByUser(string user)
        {
            List<Task> taskToDisplay = (List<Task>) Tasks.Where(task => task.AssignTo == user);

            foreach(Task task in taskToDisplay)
            {
                Console.WriteLine(task.Title);
            }
        }

        public void ListCompletedTasks ()
        {
            List<Task> completedTasks = Tasks.Where(task => task.IsCompleted).ToList();
            foreach (Task task in completedTasks) Console.WriteLine(task.Title);
        }
    }
}
