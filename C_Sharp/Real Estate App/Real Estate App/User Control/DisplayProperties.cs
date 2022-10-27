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
    public partial class DisplayProperties : UserControl
    {
        public DisplayProperties(string userType, string userID, string appointmentID)
        {
            InitializeComponent();
            this.UserType = userType;
            this.UserID = userID;
            this.AppointmentID = appointmentID;
        }
        public DisplayProperties()
        {
            InitializeComponent();
        }
        private EventHandler _propertyClicked;

        public EventHandler PropertyClicked
        {
            get { return _propertyClicked; }
            set { _propertyClicked = value; }
        }
        public string AppointmentID { get; set; }
        public string UserType { get; set; }
        public string UserID { get; set; }
        private IQueryable<Model.Get_All_Properties_Result> _properties;
        public IQueryable<Model.Get_All_Properties_Result> Properties
        {
            get { return _properties; }
            set { _properties = value; Display(); }
        }
        public void Display()
        {
            tableLayoutPanel1.Controls.Clear();
            if (_properties != null)
                foreach (var property in Properties)
                {
                    DisplayProperty d = new DisplayProperty(property);
                    d.Click += PropertyClicked + Click;
                    d.Size = displayProperty1.Size;
                    tableLayoutPanel1.Controls.Add(d);
                }
            if (UserID != null)
                if (UserType.ToLower().Contains("agent") || UserType.ToLower().Contains("admin"))
                {
                    CircularButton cb = new CircularButton();
                    cb.Image = global::Real_Estate_App.Properties.Resources.Add2;
                    Size s = new Size();
                    s.Width = displayProperty1.Height;
                    s.Height = displayProperty1.Height;
                    cb.Size = s;
                    cb.BackgroundImageLayout = ImageLayout.Zoom;
                    cb.Click += AddClick;
                    tableLayoutPanel1.Controls.Add(cb);
                }
        }
        public void AddClick(object sender, EventArgs e)
        {
            DetailPage d = new DetailPage("admin", "0", "addproperty");
            d.Show();
        }
        public void Click(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM rdm = new Model.RealEstateEDM("Admin"))
            {
                var obj = (DisplayProperty)sender;
                var SearchResult = rdm.Search_Property_By_ID(int.Parse(obj.ID)).FirstOrDefault();
                DetailPage d = new DetailPage(SearchResult, rdm.Search_Property_Photo_By_ID(SearchResult.ID).ToList<Model.Search_Property_Photo_By_ID_Result>(), UserType, UserID, AppointmentID);
                d.UserType = UserType;
            }
        }

    }
}
