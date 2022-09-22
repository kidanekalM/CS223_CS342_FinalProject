using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    internal class CircularPictureBox : PictureBox
    {
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        Region defaultRegion;
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath gp = new GraphicsPath();
            Width = ClientSize.Height;
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Width);
            defaultRegion = this.Region;
            this.Region = new System.Drawing.Region(gp);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            base.OnPaint(pe);
        }
        private void DoubleClick(object sender, EventArgs e)
        {
            this.Region = defaultRegion;
        }

        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}