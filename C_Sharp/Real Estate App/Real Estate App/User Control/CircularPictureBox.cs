using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_GUI
{
    internal class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {

            GraphicsPath gp = new GraphicsPath();
            Width = ClientSize.Height;
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Width);
            this.Region = new System.Drawing.Region(gp);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            base.OnPaint(pe); 
        }
        
    }
}