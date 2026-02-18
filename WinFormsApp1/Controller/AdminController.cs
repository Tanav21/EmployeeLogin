using Microsoft.Data.SqlClient;
using System.ComponentModel;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controller
{
    public class AdminController
    {
        private readonly UserService _userService;

        public AdminController(UserService userService)
        {
            _userService = userService;
        }

        public List<UserInfo> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
        public BindingList<TaskItem> GetAllTasksbyId(int id)
        {
            return _userService.GetAllTasksbyId(id);
        }

        public int CountAllusers()
        {
            return  _userService.CountAllUsers();
        }

        public BindingList<TaskItem> GetIncompleteTasks(int id)
        {
            return _userService.GetIncompleteTasks(id);
        }

        public BindingList<TaskItem> GetCompletedTasks(int id)
        {
            return _userService.GetCompletedTasks(id);
        }

        public int FindAllTasks(int id)
        {
            return _userService.FindAllTasks(id);
        }

        public int FindCompletedTasks(int id)
        {
            return _userService.FindCompletedTasks(id);
        }
    }
}
