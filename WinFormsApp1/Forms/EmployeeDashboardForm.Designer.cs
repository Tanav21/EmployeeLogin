namespace WinFormsApp1
{
    partial class EmployeeDashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboardForm));
            btnAdd = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGrid = new DataGridView();
            taskItemBindingSource = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnEdit = new Button();
            btnDelete = new Button();
            gradientPanel1 = new WinFormsApp1.Custom.GradientPanel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            loginTextBox1 = new loginTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(33, 145, 245);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(535, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.GridColor = Color.DimGray;
            dataGrid.Location = new Point(239, 99);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 145, 245);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(829, 409);
            dataGrid.TabIndex = 3;
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
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(91, 150, 24);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(901, 514);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 31);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(210, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(992, 514);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(pictureBox2);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.GradientTop = Color.FromArgb(9, 74, 148);
            gradientPanel1.Location = new Point(0, -6);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(222, 572);
            gradientPanel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 532);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 532);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 16;
            label5.Text = "Logout";
            label5.Click += label5_Click;
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
            label4.Size = new Size(152, 19);
            label4.TabIndex = 13;
            label4.Text = "Employee Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 47);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 12;
            label3.Text = "System (EMS)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 22);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 11;
            label1.Text = "Employee Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(233, 8);
            label2.Name = "label2";
            label2.Size = new Size(233, 30);
            label2.TabIndex = 0;
            label2.Text = "Employee Dashboard";
            // 
            // loginTextBox1
            // 
            loginTextBox1.BackColor = Color.FromArgb(33, 145, 245);
            loginTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            loginTextBox1.isPassword = false;
            loginTextBox1.label = "Enter task";
            loginTextBox1.Location = new Point(239, 50);
            loginTextBox1.Name = "loginTextBox1";
            loginTextBox1.Padding = new Padding(0, 0, 0, 1);
            loginTextBox1.Size = new Size(272, 41);
            loginTextBox1.TabIndex = 10;
            loginTextBox1.TextValue = "";
            loginTextBox1.Click += loginTextBox1_Click;
            // 
            // EmployeeDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 557);
            ControlBox = false;
            Controls.Add(loginTextBox1);
            Controls.Add(label2);
            Controls.Add(gradientPanel1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dataGrid);
            Controls.Add(btnAdd);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeeDashboardForm";
            Text = "EmployeeInfo";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGrid;
        private BindingSource taskItemBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnEdit;
        private Button btnDelete;
        private Custom.GradientPanel gradientPanel1;
        private Label label2;
        private loginTextBox loginTextBox1;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
    }
}