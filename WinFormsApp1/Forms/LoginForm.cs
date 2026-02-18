using System.Configuration;
using WinFormsApp1.Controller;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class EmployeeLogin : Form
    {
        private readonly AuthController _authController;
        private readonly TaskController _taskController;
        private readonly AdminController _adminController;
        IDbConnectionFactory _dbFactory;
        TaskService _taskService;

        public EmployeeLogin(IDbConnectionFactory dbFactory)
        {
            InitializeComponent();


            // ✅ Factory
            _dbFactory = dbFactory;

            // ✅ Services
            AuthService authService = new AuthService(_dbFactory);
            TaskService taskService = new TaskService(_dbFactory);
            UserService userService = new UserService(_dbFactory);
            _taskService = taskService;
            // ✅ Controllers
            _authController = new AuthController(authService);
            _taskController = new TaskController(taskService);
            _adminController = new AdminController(userService);
            _taskService = taskService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = loginTextBox1.TextValue;
            string password = loginTextBox2.TextValue;

            UserInfo user = _authController.Login(email, password);

            if (user == null)
            {
                MessageBox.Show("Email or Password is incorrect");
                return;
            }

            if (user.Role == utils.UserRole.Admin)
            {
                AdminDashboard adminForm = new AdminDashboard(_adminController);
                this.Hide();
                adminForm.ShowDialog();
                this.Show();
            }
            else if (user.Role == utils.UserRole.Employee)
            {
                EmployeeDashboardForm empForm = new EmployeeDashboardForm(user, _taskController,_taskService);
                this.Hide();
                empForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Unknown user role");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp(_authController);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            ResetForm form = new ResetForm(_authController);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {
            loginTextBox2.isPassword = true;
            picHide.Visible = false;
        }

        private void picOpen_Click(object sender, EventArgs e)
        {
            loginTextBox2.showPass();
            picOpen.Visible = false;
            picHide.Visible = true;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            loginTextBox2.hidePass();
            picHide.Visible = false;
            picOpen.Visible = true;
        }
    }
}
