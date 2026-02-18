using Dapper;
using System.ComponentModel;
using System.Data;
using TestAssignment.Services.Interfaces;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

public class AdminService:IAdminService
{
    private readonly IDbConnectionFactory _dbFactory;

    public AdminService(IDbConnectionFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    // ✅ Get All Users
    public async Task<List<UserInfo>> GetAllUsers()
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT Id, Email, CreatedOn
                         FROM Users 
                         WHERE RefRole = @RoleId";

        var users = await conn.QueryAsync<UserInfo>(query, new { RoleId = 1 });

        return users.ToList();
    }
    public BindingList<TaskItem> GetAllTasksbyId(int id)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT Description, isCompleted, CreatedOn
                         FROM tasks
                         WHERE refUser = @user";

        var tasks = conn.Query<TaskItem>(query, new { user = id });

        return new BindingList<TaskItem>(tasks.ToList());
    }

    // ✅ Count All Users
    public int CountAllUsers()
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT COUNT(*)
                         FROM Users
                         WHERE RefRole = @RoleId";

        return  conn.ExecuteScalar<int>(query, new { RoleId = 1 });
    }

    // ✅ Get Incomplete Tasks
    public BindingList<TaskItem> GetIncompleteTasks(int userId)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT TaskId, Description, IsCompleted, CreatedOn, UpdatedOn
                         FROM Tasks
                         WHERE IsCompleted = 0 AND RefUser = @UserId";

        var tasks = conn.Query<TaskItem>(query, new { UserId = userId }).ToList();

        return new BindingList<TaskItem>(tasks);
    }

    // ✅ Get Completed Tasks
    public BindingList<TaskItem> GetCompletedTasks(int userId)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT TaskId, Description, IsCompleted, CreatedOn, UpdatedOn
                         FROM Tasks
                         WHERE IsCompleted = 1 AND RefUser = @UserId";

        var tasks = conn.Query<TaskItem>(query, new { UserId = userId }).ToList();

        return new BindingList<TaskItem>(tasks);
    }

    // ✅ Count All Tasks of User
    public int FindAllTasks(int userId)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT COUNT(*)
                         FROM Tasks
                         WHERE RefUser = @UserId";

        return conn.ExecuteScalar<int>(query, new { UserId = userId });
    }

    // ✅ Count Completed Tasks of User
    public int FindCompletedTasks(int userId)
    {
        using IDbConnection conn = _dbFactory.CreateConnection();

        string query = @"SELECT COUNT(*)
                         FROM Tasks
                         WHERE RefUser = @UserId AND IsCompleted = 1";

        return conn.ExecuteScalar<int>(query, new { UserId = userId });
    }
}
