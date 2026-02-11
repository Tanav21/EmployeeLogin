namespace WinFormsApp1
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            gradientPanel1 = new WinFormsApp1.Custom.GradientPanel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnSignUp = new Button();
            inputPassword = new loginTextBox();
            inputEmail = new loginTextBox();
            label8 = new Label();
            radioAdmin = new RadioButton();
            radioEmployee = new RadioButton();
            label2 = new Label();
            lblClose = new Label();
            picOpen = new PictureBox();
            picHide = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(427, 54);
            label1.Name = "label1";
            label1.Size = new Size(341, 37);
            label1.TabIndex = 17;
            label1.Text = "SIGN UP YOUR ACCOUNT";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.GradientTop = Color.FromArgb(9, 74, 148);
            gradientPanel1.Location = new Point(-9, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(411, 497);
            gradientPanel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 265);
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
            label4.Location = new Point(113, 223);
            label4.Name = "label4";
            label4.Size = new Size(192, 30);
            label4.TabIndex = 2;
            label4.Text = "Sonar Technologies";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(137, 120);
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
            label3.Location = new Point(113, 54);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 0;
            label3.Text = "WELCOME TO";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(33, 145, 245);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(439, 303);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(296, 47);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSign_Click;
            // 
            // inputPassword
            // 
            inputPassword.BackColor = Color.FromArgb(33, 145, 245);
            inputPassword.Cursor = Cursors.IBeam;
            inputPassword.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputPassword.ForeColor = Color.FromArgb(64, 64, 64);
            inputPassword.isPassword = true;
            inputPassword.label = "Password";
            inputPassword.Location = new Point(439, 192);
            inputPassword.Name = "inputPassword";
            inputPassword.Padding = new Padding(0, 0, 0, 1);
            inputPassword.Size = new Size(296, 50);
            inputPassword.TabIndex = 24;
            inputPassword.TextValue = "";
            // 
            // inputEmail
            // 
            inputEmail.BackColor = Color.FromArgb(33, 145, 245);
            inputEmail.Cursor = Cursors.IBeam;
            inputEmail.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputEmail.ForeColor = Color.FromArgb(64, 64, 64);
            inputEmail.isPassword = false;
            inputEmail.label = "Email";
            inputEmail.Location = new Point(439, 129);
            inputEmail.Name = "inputEmail";
            inputEmail.Padding = new Padding(0, 0, 0, 1);
            inputEmail.Size = new Size(296, 50);
            inputEmail.TabIndex = 23;
            inputEmail.TextValue = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(782, -33);
            label8.Name = "label8";
            label8.Size = new Size(25, 30);
            label8.TabIndex = 22;
            label8.Text = "X";
            // 
            // radioAdmin
            // 
            radioAdmin.AutoSize = true;
            radioAdmin.Font = new Font("Nirmala UI", 8F);
            radioAdmin.ForeColor = Color.FromArgb(64, 64, 64);
            radioAdmin.Location = new Point(489, 258);
            radioAdmin.Name = "radioAdmin";
            radioAdmin.Size = new Size(58, 17);
            radioAdmin.TabIndex = 25;
            radioAdmin.TabStop = true;
            radioAdmin.Text = "Admin";
            radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioEmployee
            // 
            radioEmployee.AutoSize = true;
            radioEmployee.Font = new Font("Nirmala UI", 8F);
            radioEmployee.ForeColor = Color.FromArgb(64, 64, 64);
            radioEmployee.Location = new Point(557, 258);
            radioEmployee.Name = "radioEmployee";
            radioEmployee.Size = new Size(74, 17);
            radioEmployee.TabIndex = 26;
            radioEmployee.TabStop = true;
            radioEmployee.Text = "Employee";
            radioEmployee.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(439, 258);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 27;
            label2.Text = "Role :";
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.FromArgb(192, 0, 0);
            lblClose.Location = new Point(797, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(25, 30);
            lblClose.TabIndex = 28;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // picOpen
            // 
            picOpen.BackColor = Color.Transparent;
            picOpen.Image = (Image)resources.GetObject("picOpen.Image");
            picOpen.Location = new Point(720, 223);
            picOpen.Name = "picOpen";
            picOpen.Size = new Size(15, 15);
            picOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpen.TabIndex = 29;
            picOpen.TabStop = false;
            picOpen.Click += picOpen_Click;
            // 
            // picHide
            // 
            picHide.BackColor = Color.Transparent;
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(720, 223);
            picHide.Name = "picHide";
            picHide.Size = new Size(15, 15);
            picHide.SizeMode = PictureBoxSizeMode.StretchImage;
            picHide.TabIndex = 30;
            picHide.TabStop = false;
            picHide.Click += picHide_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(825, 495);
            ControlBox = false;
            Controls.Add(picHide);
            Controls.Add(picOpen);
            Controls.Add(lblClose);
            Controls.Add(label2);
            Controls.Add(radioEmployee);
            Controls.Add(radioAdmin);
            Controls.Add(label1);
            Controls.Add(gradientPanel1);
            Controls.Add(btnSignUp);
            Controls.Add(inputPassword);
            Controls.Add(inputEmail);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Custom.GradientPanel gradientPanel1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnSignUp;
        private loginTextBox inputPassword;
        private loginTextBox inputEmail;
        private Label label8;
        private RadioButton radioAdmin;
        private RadioButton radioEmployee;
        private Label label2;
        private Label lblClose;
        private PictureBox picOpen;
        private PictureBox picHide;
    }
}