using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class EmployeeLogin : Form
    {
        private readonly AuthController _authController;
        private TaskController taskController;
        private AdminController adminController;

        public EmployeeLogin()
        {
            InitializeComponent();
            _authController = new AuthController();
            taskController = new TaskController();
            adminController = new AdminController();
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

            if (user?.Role == utils.UserRole.Admin)
            {
                AdminDashboard form3 = new AdminDashboard(adminController);
                this.Hide();
                form3.ShowDialog();
                this.Show();
            }
            else if (user?.Role == utils.UserRole.Employee)
            {
                EmployeeDashboardForm form2 = new EmployeeDashboardForm(user, taskController);
                this.Hide();
                form2.ShowDialog();
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
            ResetForm form = new ResetForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void picOpen_Click(object sender, EventArgs e)
        {
            loginTextBox2.showPass();
            picOpen.Visible = false;
            picHide.Visible = true;
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {
            loginTextBox2.isPassword = true;
            picHide.Visible = false;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            loginTextBox2.hidePass();
            picHide.Visible = false;
            picOpen.Visible = true;
        }
    }
}
