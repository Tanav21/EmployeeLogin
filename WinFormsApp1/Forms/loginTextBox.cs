using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class loginTextBox : UserControl
    {
        public loginTextBox()
        {
            InitializeComponent();
        }
        public string _label = "Default value";
        public bool _isPassword = false;
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Text for the label")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string label
        {
            get { return _label; }
            set { _label = value; }
        }
        [Browsable(true)]
        [Category("Behavior")]
        [Description("Set true to hide text in password mode")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool isPassword
        {
            get { return _isPassword; }
            set { _isPassword = value; }
        }
        [Browsable(true)]
        [Category("Data")]
        [Description("Text entered in the textbox")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextValue
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            textBox1.Text = "";
        }
        public void hidePass()
        {
            textBox1.UseSystemPasswordChar = true;
        }
        public void showPass()
        {
            textBox1.UseSystemPasswordChar = false;
        }
        private void loginTextBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = label;
            if (isPassword)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }
    }
}
