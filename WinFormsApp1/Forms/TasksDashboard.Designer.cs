namespace WinFormsApp1
{
    partial class TasksDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksDashboard));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            lblComplete = new Label();
            lbl1 = new Label();
            label1 = new Label();
            lblTotal = new Label();
            lblIncomplete = new Label();
            label4 = new Label();
            label2 = new Label();
            gradientPanel1 = new WinFormsApp1.Custom.GradientPanel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            taskItemBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            taskItemBindingSource1 = new BindingSource(components);
            comboBoxFilter = new ComboBox();
            panel2 = new Panel();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblComplete
            // 
            lblComplete.AutoSize = true;
            lblComplete.BackColor = Color.Transparent;
            lblComplete.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplete.ForeColor = Color.FromArgb(64, 64, 64);
            lblComplete.Location = new Point(864, 79);
            lblComplete.Name = "lblComplete";
            lblComplete.Size = new Size(19, 21);
            lblComplete.TabIndex = 16;
            lblComplete.Text = "0";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(64, 64, 64);
            lbl1.Location = new Point(281, 79);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(89, 21);
            lbl1.TabIndex = 17;
            lbl1.Text = "Total Tasks :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(735, 79);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 18;
            label1.Text = "Completed Tasks :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Nirmala UI", 12F);
            lblTotal.ForeColor = Color.FromArgb(64, 64, 64);
            lblTotal.Location = new Point(366, 80);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 21);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "0";
            // 
            // lblIncomplete
            // 
            lblIncomplete.AutoSize = true;
            lblIncomplete.BackColor = Color.Transparent;
            lblIncomplete.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncomplete.ForeColor = Color.FromArgb(64, 64, 64);
            lblIncomplete.Location = new Point(617, 80);
            lblIncomplete.Name = "lblIncomplete";
            lblIncomplete.Size = new Size(19, 21);
            lblIncomplete.TabIndex = 24;
            lblIncomplete.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(487, 79);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 23;
            label4.Text = "Incomplete Tasks :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(281, 33);
            label2.Name = "label2";
            label2.Size = new Size(175, 30);
            label2.TabIndex = 29;
            label2.Text = "Employee Tasks";
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.Transparent;
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(label7);
            gradientPanel1.Controls.Add(label8);
            gradientPanel1.Dock = DockStyle.Left;
            gradientPanel1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.GradientTop = Color.FromArgb(9, 74, 148);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(248, 571);
            gradientPanel1.TabIndex = 31;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(26, 105);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 13;
            label6.Text = "Employee Tasks";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 47);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 12;
            label7.Text = "System (EMS)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(7, 22);
            label8.Name = "label8";
            label8.Size = new Size(192, 21);
            label8.TabIndex = 11;
            label8.Text = "Employee Management";
            // 
            // panel1
            // 
            panel1.Location = new Point(278, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 44);
            panel1.TabIndex = 10;
            // 
            // taskItemBindingSource
            // 
            taskItemBindingSource.DataSource = typeof(Models.TaskItem);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.GridColor = Color.DimGray;
            dataGridView1.Location = new Point(281, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(25, 145, 245);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(801, 464);
            dataGridView1.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // taskItemBindingSource1
            // 
            taskItemBindingSource1.DataSource = typeof(Models.TaskItem);
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DataSource = taskItemBindingSource;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Location = new Point(965, 79);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(117, 23);
            comboBoxFilter.TabIndex = 32;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(gradientPanel1);
            panel2.Controls.Add(lblComplete);
            panel2.Controls.Add(comboBoxFilter);
            panel2.Controls.Add(lbl1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(lblIncomplete);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 571);
            panel2.TabIndex = 33;
            // 
            // TasksDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 571);
            Controls.Add(panel2);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TasksDashboard";
            Text = "TaskDashboard";
            Load += Form4_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskItemBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblComplete;
        private Label lblTotal;
        private Label lbl1;
        private Label label1;
        private Label lblIncomplete;
        private Label label4;
        private Label label2;
        private Custom.GradientPanel gradientPanel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private BindingSource taskItemBindingSource;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private BindingSource taskItemBindingSource1;
        private ComboBox comboBoxFilter;
        private Panel panel2;
    }
}