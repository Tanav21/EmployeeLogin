using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1.Custom
{
    public class GradientPanel : Panel
    {
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Top color of the gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientTop { get; set; } = Color.White;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Bottom color of the gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color GradientBottom { get; set; } = Color.Black;

        public GradientPanel()
        {
            this.Resize += GradientPanel_Resize;
        }

        private void GradientPanel_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush linear = new LinearGradientBrush(
                this.ClientRectangle,
                this.GradientTop,
                this.GradientBottom,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(linear, this.ClientRectangle);
            }

            base.OnPaint(e);
        }
    }
}
