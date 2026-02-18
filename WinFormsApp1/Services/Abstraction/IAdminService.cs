using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WinFormsApp1.Models;

namespace TestAssignment.Services.Interfaces
{
    public interface IAdminService
    {
         Task<List<UserInfo>> GetAllUsers();
         BindingList<TaskItem> GetAllTasksbyId(int id);
         int CountAllUsers();
         BindingList<TaskItem> GetIncompleteTasks(int userId);
         BindingList<TaskItem> GetCompletedTasks(int userId);
         int FindAllTasks(int userId);
         int FindCompletedTasks(int userId);
    }
}