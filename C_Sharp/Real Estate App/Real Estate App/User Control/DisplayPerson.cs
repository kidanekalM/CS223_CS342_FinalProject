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
    public partial class DisplayPerson : UserControl
    {
        public DisplayPerson(Model.Get_All_Employees_Result Employee )
        {
            InitializeComponent();
            this.FullName = Employee.FirstName + " " + Employee.LastName;
            this.ID = Employee.ID;
            this.PhoneNumber = Employee.PhoneNumber;
           
            if (Employee.Photo != null && (! Employee.Photo.All(val => val == 0)))
            {
                using (System.IO.MemoryStream s = new System.IO.MemoryStream(Employee.Photo))
                {
                    try
                    {
                        this.PersonPhoto = Image.FromStream(s);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            else
            {
               this.PersonPhoto = global::Real_Estate_App.Properties.Resources.Default_Profile;
            }
        }
        public DisplayPerson(Model.Get_All_Clients_Result Client)
        {
            InitializeComponent();
            this.FullName = Client.FirstName + " " + Client.LastName;
            this.ID = Client.ID;
            this.PhoneNumber = Client.PhoneNumber;
            
            if (Client.Photo != null && (!Client.Photo.All(val => val == 0)))
            {
                using (System.IO.MemoryStream s = new System.IO.MemoryStream(Client.Photo))
                {
                    try
                    {
                        this.PersonPhoto = Image.FromStream(s);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
        }
        public DisplayPerson()
        {
            InitializeComponent();
        }
        private string _fullname;

        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; lbl_name.Text = value; }
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value;lbl_id.Text = "ID: " + value; }
        }
        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; lbl_phoneNumber.Text = "Phone Number: " + value; }
        }
        private Image _personPhoto;
        public Image PersonPhoto
        {
            get { return _personPhoto; }
            set { _personPhoto = value; circularPictureBox1.Image = value; }
        }


    }
}
