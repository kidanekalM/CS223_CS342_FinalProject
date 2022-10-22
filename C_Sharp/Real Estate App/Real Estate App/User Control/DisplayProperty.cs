using Real_Estate_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    public partial class DisplayProperty : UserControl
    {
        private string propertyID;
        private string propertyAddress;
        private string propertyStatus;
        private string propertyPrice;
        private string propertyDescription;
        private Image _photo;
        public string ID
        {
            get { return propertyID; }
            set { propertyID = value; lbl_Id.Text = value; }
        }
        public string PropertyAddress
        {
            get { return propertyAddress; }
            set { propertyAddress = value; lbl_address.Text = value; }
        }
        public string Availablity
        {
            get { return propertyStatus; }
            set { propertyStatus = value; lbl_availability.Text = value; }
        }
        public string PropertyPrice
        {
            get { return propertyPrice; }
            set { propertyPrice = value; lbl_price.Text = value; }
        }
        public string PropertyDescription
        {
            get { return propertyDescription; }
            set { propertyDescription = value; txt_Description.Text = value; }
        }
        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; PropertyPhoto.Image = value; if (value == null) this.Photo = global::Real_Estate_App.Properties.Resources.RealEstate_App_Icon; }
        }
        public DisplayProperty(Get_All_Properties_Result Property)
        {
            InitializeComponent();

            ID += Property.ID.ToString();
            PropertyAddress += Property.Address;
            var stat = Property.Status;
            if (stat == false)
                Availablity += "Not Available";
            else if (stat == true)
                Availablity += "Available";
            PropertyPrice += Property.Price.ToString();
            PropertyDescription = Property.Description;
            if (Property.Property_Photo != null && (!Property.Property_Photo.All(val => val == 0)))
            {
                using (MemoryStream s = new MemoryStream(Property.Property_Photo))
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

        public DisplayProperty(Search_Property_By_ID_Result Property, List<Search_Property_Photo_By_ID_Result> PhotoList)
        {
            InitializeComponent();

            ID += Property.ID.ToString();
            PropertyAddress += Property.Address;
            var stat = Property.Status;
            if (stat == false)
                Availablity += "Not Available";
            else if (stat == true)
                Availablity += "Available";
            PropertyPrice += Property.Price.ToString();
            PropertyDescription = Property.Description;
            if (PhotoList != null)
            {
                //foreach (var photo in PhotoList)
                int i = 0;
                foreach (var photo in PhotoList)
                {
                    i++;
                    using (MemoryStream s = new MemoryStream(photo.Photo))
                    {
                        try
                        {
                            this.Photo = Image.FromStream(s);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Couldn't load property pictures in \"DisplayProperty\" user control! \n" + e.ToString());
                        }
                    }
                    if (i > 0)
                        break;
                }
            }
            else
            {
                this.Photo = global::Real_Estate_App.Properties.Resources.RealEstate_App_Icon;
            }
        }

        public DisplayProperty(Filter_Property_Result1 Property, List<Search_Property_Photo_By_ID_Result> PhotoList)
        {
            InitializeComponent();

            ID += Property.ID.ToString();
            PropertyAddress += Property.Address;
            var stat = Property.Status;
            if (stat == false)
                Availablity += "Not Available";
            else if (stat == true)
                Availablity += "Available";
            PropertyPrice += Property.Price.ToString();
            PropertyDescription = Property.Description;
            if (PhotoList != null)
            {
                int i = 0;
                foreach (var photo in PhotoList)
                {
                    i++;
                    using (MemoryStream s = new MemoryStream(photo.Photo))
                    {
                        try
                        {
                            this.Photo = Image.FromStream(s);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Couldn't load property pictures in \"DisplayProperty\" user control! \n" + e.ToString());
                        }
                    }
                    if (i > 0)
                        break;
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





    }
}
