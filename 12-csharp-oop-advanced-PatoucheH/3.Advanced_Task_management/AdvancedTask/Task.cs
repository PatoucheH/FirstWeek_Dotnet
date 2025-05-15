using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask
{
    public class Task
    {
        public string Title;
        public string Description;
        public string AssignTo;
        public DateTime DueDate;
        public PriorityLevel Priority;
        public bool IsCompleted = false;

        public Task(string title, string desc, string assignTo, DateTime dueDate, PriorityLevel priority)
        {
            Title = title;
            Description = desc;
            AssignTo = assignTo;
            DueDate = dueDate;
            Priority = priority;
        }

        public void CompleteTask()
        {
            IsCompleted = true;
        }

        public bool IsOverdue()
        {
            return !IsCompleted && DueDate < DateTime.Now;
        }
    }
}
