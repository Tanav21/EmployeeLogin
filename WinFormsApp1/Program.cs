using Microsoft.Extensions.DependencyInjection;
using TestAssignment.Services.Interfaces;
using WinFormsApp1.Controller;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();


            //Services
            services.AddScoped<AuthService>();
            services.AddScoped<TaskService>();
            services.AddScoped<AdminService>();

            //Controllers
            services.AddScoped<AuthController>();
            services.AddScoped<TaskController>();
            services.AddScoped<AdminController>();

            //Forms
            services.AddScoped<EmployeeLogin>();
            services.AddScoped<AdminDashboard>();
            services.AddScoped<EmployeeDashboardForm>();
            services.AddScoped<SignUp>();
            services.AddScoped<ResetForm>();

            //Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITaskService, TaskService>();

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            // Create scope for scoped services
            using (var scope = ServiceProvider.CreateScope())
            {
                var loginForm = scope.ServiceProvider.GetRequiredService<EmployeeLogin>();
                Application.Run(loginForm);
            }
        }
    }
}
