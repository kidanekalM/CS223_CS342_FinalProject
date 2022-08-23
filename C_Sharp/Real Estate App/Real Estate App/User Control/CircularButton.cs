using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    internal class CircularButton : Button
    {
        Region defaultRegion;
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath gp = new GraphicsPath();
            Width = ClientSize.Height;
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Width);
            defaultRegion = this.Region;
            this.Region = new System.Drawing.Region(gp);
            base.OnPaint(pe);

        }
    }
}