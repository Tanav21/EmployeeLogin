namespace WinFormsApp1
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            lblUsers = new Label();
            label2 = new Label();
            gradientPanel1 = new WinFormsApp1.Custom.GradientPanel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            taskItemBindingSource = new BindingSource(components);
            dataGrid = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(228, 51);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 13;
            label3.Text = "Total Users : ";
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Nirmala UI", 14F);
            lblUsers.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsers.Location = new Point(335, 52);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(22, 25);
            lblUsers.TabIndex = 14;
            lblUsers.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(228, 12);
            label2.Name = "label2";
            label2.Size = new Size(200, 30);
            label2.TabIndex = 17;
            label2.Text = "Admin Dashboard";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(pictureBox2);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label7);
            gradientPanel1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.GradientTop = Color.FromArgb(9, 74, 148);
            gradientPanel1.Location = new Point(0, -1);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(222, 572);
            gradientPanel1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 527);
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
            label5.Location = new Point(34, 527);
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
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(26, 105);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 13;
            label4.Text = "Admin Dashboard";
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
            // taskItemBindingSource
            // 
            taskItemBindingSource.DataSource = typeof(Models.TaskItem);
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.GridColor = Color.DimGray;
            dataGrid.Location = new Point(228, 83);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(25, 145, 245);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(822, 469);
            dataGrid.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 557);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(gradientPanel1);
            Controls.Add(dataGrid);
            Controls.Add(lblUsers);
            Controls.Add(label3);
            ForeColor = Color.White;
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblUsers;
        private DataGridView dataGrid;
        private Custom.GradientPanel gradientPanel1;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label6;
        private Label label7;
        private BindingSource taskItemBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
    }
}