using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    public partial class DisplayProperty : UserControl
    {
        public DisplayProperty()
        {
            InitializeComponent();
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; lbl_address.Text ="Address: "+ value; }
        }
        
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; txt_Description.Text = value; }
        }
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value;lbl_price.Text = "Price: " + value; }
        }
        private bool _availability;

        public bool Availability
        {
            get { return _availability; }
            set { _availability = value;
                if (value) 
                {
                    this.BackColor = SystemColors.Control;
                    lbl_availability.Text = "Available";
                }
                else
                {
                    lbl_availability.Text = "Not Available";
                    this.BackColor = SystemColors.ControlDark;
                }
            }
        }


    }
}
