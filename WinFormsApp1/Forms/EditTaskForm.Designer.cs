namespace WinFormsApp1
{
    partial class EditTaskForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskForm));
            checkIsCompleted = new CheckBox();
            inputTask = new loginTextBox();
            label3 = new Label();
            gradientPanel1 = new WinFormsApp1.Custom.GradientPanel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            taskItemBindingSource = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnSave = new Button();
            panel2 = new Panel();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // checkIsCompleted
            // 
            checkIsCompleted.AutoSize = true;
            checkIsCompleted.Font = new Font("Nirmala UI", 7.8F);
            checkIsCompleted.ForeColor = Color.FromArgb(64, 64, 64);
            checkIsCompleted.Location = new Point(224, 113);
            checkIsCompleted.Name = "checkIsCompleted";
            checkIsCompleted.Size = new Size(82, 17);
            checkIsCompleted.TabIndex = 1;
            checkIsCompleted.Text = "Completed";
            checkIsCompleted.UseVisualStyleBackColor = true;
            // 
            // inputTask
            // 
            inputTask.BackColor = Color.FromArgb(33, 145, 245);
            inputTask.Cursor = Cursors.IBeam;
            inputTask.ForeColor = Color.FromArgb(64, 64, 64);
            inputTask.isPassword = false;
            inputTask.label = "Enter task";
            inputTask.Location = new Point(224, 63);
            inputTask.Name = "inputTask";
            inputTask.Padding = new Padding(0, 0, 0, 1);
            inputTask.Size = new Size(245, 41);
            inputTask.TabIndex = 17;
            inputTask.TextValue = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(218, 21);
            label3.Name = "label3";
            label3.Size = new Size(212, 30);
            label3.TabIndex = 11;
            label3.Text = "Edit Employee Task";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label7);
            gradientPanel1.Controls.Add(panel1);
            gradientPanel1.Dock = DockStyle.Left;
            gradientPanel1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.GradientTop = Color.FromArgb(9, 74, 148);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(203, 505);
            gradientPanel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 105);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 13;
            label4.Text = "Edit Employee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 47);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 12;
            label6.Text = "System (EMS)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(7, 22);
            label7.Name = "label7";
            label7.Size = new Size(192, 21);
            label7.TabIndex = 11;
            label7.Text = "Employee Management";
            // 
            // panel1
            // 
            panel1.Location = new Point(205, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 44);
            panel1.TabIndex = 10;
            // 
            // taskItemBindingSource
            // 
            taskItemBindingSource.DataSource = typeof(Models.TaskItem);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(33, 145, 245);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(224, 139);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(gradientPanel1);
            panel2.Controls.Add(checkIsCompleted);
            panel2.Controls.Add(inputTask);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 505);
            panel2.TabIndex = 18;
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 505);
            Controls.Add(panel2);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditTaskForm";
            Text = "EditTaskForm";
            Load += Form5_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkIsCompleted;
        private Button btnSave;
        private loginTextBox inputTask;
        private Label label3;
        private Custom.GradientPanel gradientPanel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label6;
        private Label label7;
        private BindingSource taskItemBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Panel panel2;
    }
}