namespace WinFormsApp1
{
    partial class EmployeeLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogin));
            btnLogin = new Button();
            label1 = new Label();
            gradientPanel1 = new WinFormsApp1.Custom.GradientPanel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            lblResetPassword = new Label();
            label7 = new Label();
            label8 = new Label();
            loginTextBox1 = new loginTextBox();
            loginTextBox2 = new loginTextBox();
            picOpen = new PictureBox();
            picHide = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(33, 145, 245);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(444, 323);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(296, 47);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(426, 61);
            label1.Name = "label1";
            label1.Size = new Size(364, 37);
            label1.TabIndex = 7;
            label1.Text = "LOG IN TO YOUR ACCOUNT";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.GradientTop = Color.FromArgb(9, 74, 148);
            gradientPanel1.Location = new Point(-1, -4);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(409, 543);
            gradientPanel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 276);
            label5.Name = "label5";
            label5.Size = new Size(334, 98);
            label5.TabIndex = 3;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 234);
            label4.Name = "label4";
            label4.Size = new Size(192, 30);
            label4.TabIndex = 2;
            label4.Text = "Sonar Technologies";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(112, 65);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 0;
            label3.Text = "WELCOME TO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(506, 496);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 10;
            label2.Text = "Dont't have an account?";
            // 
            // lblResetPassword
            // 
            lblResetPassword.AutoSize = true;
            lblResetPassword.Cursor = Cursors.Hand;
            lblResetPassword.Font = new Font("Nirmala UI", 8F);
            lblResetPassword.ForeColor = Color.FromArgb(33, 145, 245);
            lblResetPassword.Location = new Point(656, 277);
            lblResetPassword.Name = "lblResetPassword";
            lblResetPassword.Size = new Size(87, 13);
            lblResetPassword.TabIndex = 11;
            lblResetPassword.Text = "Reset Password";
            lblResetPassword.Click += lblResetPassword_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.ForeColor = Color.FromArgb(33, 145, 245);
            label7.Location = new Point(638, 496);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Sign Up";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Nirmala UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(796, 2);
            label8.Name = "label8";
            label8.Size = new Size(25, 30);
            label8.TabIndex = 13;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // loginTextBox1
            // 
            loginTextBox1.BackColor = Color.FromArgb(33, 145, 245);
            loginTextBox1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            loginTextBox1.isPassword = false;
            loginTextBox1.label = "Email";
            loginTextBox1.Location = new Point(444, 160);
            loginTextBox1.Name = "loginTextBox1";
            loginTextBox1.Padding = new Padding(0, 0, 0, 1);
            loginTextBox1.Size = new Size(296, 50);
            loginTextBox1.TabIndex = 14;
            loginTextBox1.TextValue = "";
            // 
            // loginTextBox2
            // 
            loginTextBox2.BackColor = Color.FromArgb(33, 145, 245);
            loginTextBox2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            loginTextBox2.isPassword = false;
            loginTextBox2.label = "Password";
            loginTextBox2.Location = new Point(444, 223);
            loginTextBox2.Name = "loginTextBox2";
            loginTextBox2.Padding = new Padding(0, 0, 0, 1);
            loginTextBox2.Size = new Size(296, 50);
            loginTextBox2.TabIndex = 15;
            loginTextBox2.TextValue = "";
            // 
            // picOpen
            // 
            picOpen.BackColor = Color.Transparent;
            picOpen.Image = (Image)resources.GetObject("picOpen.Image");
            picOpen.Location = new Point(719, 248);
            picOpen.Name = "picOpen";
            picOpen.Size = new Size(15, 15);
            picOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpen.TabIndex = 16;
            picOpen.TabStop = false;
            picOpen.Click += picOpen_Click;
            // 
            // picHide
            // 
            picHide.BackColor = Color.Transparent;
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(719, 248);
            picHide.Name = "picHide";
            picHide.Size = new Size(15, 15);
            picHide.SizeMode = PictureBoxSizeMode.StretchImage;
            picHide.TabIndex = 17;
            picHide.TabStop = false;
            picHide.Click += picHide_Click;
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(825, 537);
            ControlBox = false;
            Controls.Add(picHide);
            Controls.Add(picOpen);
            Controls.Add(loginTextBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblResetPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gradientPanel1);
            Controls.Add(btnLogin);
            Controls.Add(loginTextBox2);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeLogin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeLogin";
            Load += EmployeeLogin_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Custom.GradientPanel gradientPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private loginTextBox loginTextBox1;
        private loginTextBox loginTextBox2;
        private Label label2;
        private Label lblResetPassword;
        private Label label7;
        private Label label8;
        private PictureBox picOpen;
        private PictureBox picHide;
    }
}
