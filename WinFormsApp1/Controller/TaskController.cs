using Microsoft.Data.SqlClient;
using System.ComponentModel;
using TestAssignment.Services.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controller
{
    public class TaskController
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public BindingList<TaskItem> ShowTasks(int userId)
        {
            try
            {
                return _taskService.GetTasksByUserId(userId);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new BindingList<TaskItem>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new BindingList<TaskItem>();
            }
        }

        public TaskItem AddTask(int userId, string description)
        {
            try
            {
                return _taskService.AddTask(userId, description);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool DeleteTask(int taskId)
        {
            try
            {
                return _taskService.DeleteTask(taskId);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
