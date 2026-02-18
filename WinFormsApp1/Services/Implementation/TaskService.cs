using Dapper;
using System.ComponentModel;
using System.Data;
using TestAssignment.Services.Interfaces;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

public class TaskService : ITaskService
{
    private readonly IDbConnectionFactory _dbFactory;

    public TaskService(IDbConnectionFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    public BindingList<TaskItem> GetTasksByUserId(int userId)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT TaskId, Description, IsCompleted, CreatedOn, UpdatedOn
                         FROM Tasks
                         WHERE RefUser = @UserId";

        var tasks = conn.Query<TaskItem>(query, new { UserId = userId }).ToList();

        return new BindingList<TaskItem>(tasks);
    }

    public TaskItem AddTask(int userId, string description)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"
            INSERT INTO Tasks (RefUser, Description, IsCompleted, CreatedOn, UpdatedOn)
            VALUES (@UserId, @Description, 0, GETDATE(), GETDATE());

            SELECT CAST(SCOPE_IDENTITY() AS INT);
        ";

        int taskId = conn.ExecuteScalar<int>(query, new
        {
            UserId = userId,
            Description = description
        });

        return new TaskItem
        {
            TaskId = taskId,
            Description = description,
            IsCompleted = false,
            CreatedOn = DateTime.Now,
            UpdatedOn = DateTime.Now
        };
    }

    public bool DeleteTask(int taskId)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"DELETE FROM Tasks WHERE TaskId = @TaskId";

        int rows = conn.Execute(query, new { TaskId = taskId });

        return rows > 0;
    }
    public bool UpdateTask(TaskItem task)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"
        UPDATE Tasks
        SET Description = @Description,
            IsCompleted = @IsCompleted,
            UpdatedOn = GETDATE()
        WHERE TaskId = @TaskId";

        int rows = conn.Execute(query, new
        {
            task.Description,
            task.IsCompleted,
            task.TaskId
        });

        return rows > 0;
    }

}
