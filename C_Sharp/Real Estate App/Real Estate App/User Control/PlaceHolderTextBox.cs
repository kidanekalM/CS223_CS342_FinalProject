using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    internal class PlaceHolderTextBox : TextBox
    {
        public PlaceHolderTextBox()
        {
            this.Enter += ControlEnter;
            this.MouseEnter += mEnter;
            this.MouseLeave += mLeave;
            this.Leave += ControlLeave;
            this.BackColor = Color.White;
        }
        private string _placeHolder;

        public string  PlaceHolder
        {
            get { return _placeHolder; }
            set { _placeHolder = value; ControlLeave(this, null); }
        }

        public void mEnter(object sender,EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }
        public void mLeave(object sender, EventArgs e)
        {
                this.BackColor = Color.White;
        }
        private void ControlEnter(object sender,EventArgs e)
        {
            if ( this.Text == PlaceHolder)
            {
                this.Text = "";
                this.ForeColor = Color.Black;
            }
        }
        private void ControlLeave(object sender,EventArgs e)
        {
            if (this.Text == "" || this.Text.All(c => c==' '))
            {
                this.Text = PlaceHolder;
                this.ForeColor = Color.Gray;
            }
        }
    }
}
