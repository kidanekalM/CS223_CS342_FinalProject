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
        public DisplayProperty(Model.Get_All_Properties_Result Property)
        {
            InitializeComponent();

            Address = Property.Address;
            Availability = Property.Status;
            Price = Property.Price.ToString();
            Id = Property.ID.ToString();
            Description = Property.Description;
            if (Property.Property_Photo != null && (!Property.Property_Photo.All(val => val == 0)))
            {
                using (System.IO.MemoryStream s = new System.IO.MemoryStream(Property.Property_Photo))
                {
                    try
                    {
                        this.Photo = Image.FromStream(s);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            else
            {
                this.Photo = global::Real_Estate_App.Properties.Resources.RealEstate_App_Icon;
            }
        }
        public DisplayProperty()
        {
            InitializeComponent();
        }
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; lbl_Id.Text = "ID: " + value;  }
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

        private Image _photo;

        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; PropertyPhoto.Image = value; if (value == null) this.Photo = global::Real_Estate_App.Properties.Resources.RealEstate_App_Icon; }
        }


    }
}
