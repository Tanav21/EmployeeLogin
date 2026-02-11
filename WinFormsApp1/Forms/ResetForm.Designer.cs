namespace WinFormsApp1
{
    partial class ResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetForm));
            label1 = new Label();
            gradientPanel1 = new WinFormsApp1.Custom.GradientPanel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnReset = new Button();
            inputOldPassword = new loginTextBox();
            inputEmail = new loginTextBox();
            label8 = new Label();
            inputNewPass = new loginTextBox();
            lblClose = new Label();
            picOpen2 = new PictureBox();
            picHide2 = new PictureBox();
            picOpen1 = new PictureBox();
            picHide1 = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(477, 55);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 17;
            label1.Text = "Reset Password ";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.GradientTop = Color.FromArgb(9, 74, 148);
            gradientPanel1.Location = new Point(-12, -46);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(409, 548);
            gradientPanel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 297);
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
            label4.Location = new Point(109, 255);
            label4.Name = "label4";
            label4.Size = new Size(192, 30);
            label4.TabIndex = 2;
            label4.Text = "Sonar Technologies";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 152);
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
            label3.Location = new Point(111, 101);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 0;
            label3.Text = "WELCOME TO";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(33, 145, 245);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(433, 339);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(296, 47);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // inputOldPassword
            // 
            inputOldPassword.BackColor = Color.FromArgb(33, 145, 245);
            inputOldPassword.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputOldPassword.ForeColor = Color.FromArgb(64, 64, 64);
            inputOldPassword.isPassword = true;
            inputOldPassword.label = "Old Password";
            inputOldPassword.Location = new Point(433, 195);
            inputOldPassword.Name = "inputOldPassword";
            inputOldPassword.Padding = new Padding(0, 0, 0, 1);
            inputOldPassword.Size = new Size(296, 50);
            inputOldPassword.TabIndex = 24;
            inputOldPassword.TextValue = "";
            // 
            // inputEmail
            // 
            inputEmail.BackColor = Color.FromArgb(33, 145, 245);
            inputEmail.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputEmail.ForeColor = Color.FromArgb(64, 64, 64);
            inputEmail.isPassword = false;
            inputEmail.label = "Email";
            inputEmail.Location = new Point(433, 139);
            inputEmail.Name = "inputEmail";
            inputEmail.Padding = new Padding(0, 0, 0, 1);
            inputEmail.Size = new Size(296, 50);
            inputEmail.TabIndex = 23;
            inputEmail.TextValue = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(787, -41);
            label8.Name = "label8";
            label8.Size = new Size(25, 30);
            label8.TabIndex = 22;
            label8.Text = "X";
            // 
            // inputNewPass
            // 
            inputNewPass.BackColor = Color.FromArgb(33, 145, 245);
            inputNewPass.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputNewPass.ForeColor = Color.FromArgb(64, 64, 64);
            inputNewPass.isPassword = true;
            inputNewPass.label = "New Password";
            inputNewPass.Location = new Point(433, 251);
            inputNewPass.Name = "inputNewPass";
            inputNewPass.Padding = new Padding(0, 0, 0, 1);
            inputNewPass.Size = new Size(296, 50);
            inputNewPass.TabIndex = 25;
            inputNewPass.TextValue = "";
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.FromArgb(192, 0, 0);
            lblClose.Location = new Point(795, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(25, 30);
            lblClose.TabIndex = 26;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // picOpen2
            // 
            picOpen2.BackColor = Color.Transparent;
            picOpen2.Image = (Image)resources.GetObject("picOpen2.Image");
            picOpen2.Location = new Point(714, 277);
            picOpen2.Name = "picOpen2";
            picOpen2.Size = new Size(15, 15);
            picOpen2.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpen2.TabIndex = 27;
            picOpen2.TabStop = false;
            picOpen2.Click += picOpen2_Click;
            // 
            // picHide2
            // 
            picHide2.BackColor = Color.Transparent;
            picHide2.Image = (Image)resources.GetObject("picHide2.Image");
            picHide2.Location = new Point(714, 277);
            picHide2.Name = "picHide2";
            picHide2.Size = new Size(15, 15);
            picHide2.SizeMode = PictureBoxSizeMode.StretchImage;
            picHide2.TabIndex = 28;
            picHide2.TabStop = false;
            picHide2.Click += picHide2_Click;
            // 
            // picOpen1
            // 
            picOpen1.BackColor = Color.Transparent;
            picOpen1.Image = (Image)resources.GetObject("picOpen1.Image");
            picOpen1.Location = new Point(714, 224);
            picOpen1.Name = "picOpen1";
            picOpen1.Size = new Size(15, 15);
            picOpen1.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpen1.TabIndex = 29;
            picOpen1.TabStop = false;
            picOpen1.Click += picOpen1_Click;
            // 
            // picHide1
            // 
            picHide1.BackColor = Color.Transparent;
            picHide1.Image = (Image)resources.GetObject("picHide1.Image");
            picHide1.Location = new Point(714, 224);
            picHide1.Name = "picHide1";
            picHide1.Size = new Size(15, 15);
            picHide1.SizeMode = PictureBoxSizeMode.StretchImage;
            picHide1.TabIndex = 30;
            picHide1.TabStop = false;
            picHide1.Click += picHide1_Click;
            // 
            // ResetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(822, 498);
            ControlBox = false;
            Controls.Add(picHide1);
            Controls.Add(picOpen1);
            Controls.Add(picHide2);
            Controls.Add(picOpen2);
            Controls.Add(lblClose);
            Controls.Add(inputNewPass);
            Controls.Add(label1);
            Controls.Add(gradientPanel1);
            Controls.Add(btnReset);
            Controls.Add(inputOldPassword);
            Controls.Add(inputEmail);
            Controls.Add(label8);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ResetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetForm";
            Load += ResetForm_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResetPassword;
        private Label label1;
        private Custom.GradientPanel gradientPanel1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnReset;
        private loginTextBox inputOldPassword;
        private Button btnLogin;
        private loginTextBox loginTextBox2;
        private loginTextBox inputEmail;
        private Label label8;
        private loginTextBox inputNewPass;
        private Label label7;
        private Label lblClose;
        private PictureBox picOpen2;
        private PictureBox picOpen1;
        private PictureBox picHide2;
        private PictureBox picHide1;
    }
}