using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WinFormsApp1.Models;

namespace TestAssignment.Services.Interfaces
{
    public interface ITaskService
    {
        public BindingList<TaskItem> GetTasksByUserId(int userId);
        public TaskItem AddTask(int userId, string description);
        public bool DeleteTask(int taskId);
        public bool UpdateTask(TaskItem task);
    }
}
