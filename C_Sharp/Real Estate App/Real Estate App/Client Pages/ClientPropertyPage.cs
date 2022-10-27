using Real_Estate_App.Model;
using Real_Estate_App.User_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Real_Estate_App.Client_Pages
{
    public partial class ClientPropertyPage : Form
    {
        private int count = 0;
        private int id;
        public ClientPropertyPage(int id)
        {
            InitializeComponent();

            this.id = id;
            LoadTable();
        }

        private void LoadTable()
        {
            List<int> propertyIds = new List<int>();

            //Populating the propertyIds
            using (RealEstateEDM r = new RealEstateEDM("client"))
            {
                flowLayoutPanel1.Controls.Clear();
                var propIdResult = r.Search_Buy_By_ClientID(id);
                foreach (var id in propIdResult)
                {
                    propertyIds.Add(id.PropertyID);
                }
            }
            if (propertyIds != null)
            {
                //Populating the "DisplayProperty" with property info
                using (RealEstateEDM r = new RealEstateEDM("client"))
                {
                    foreach (var id in propertyIds)
                    {
                        var propResult = r.Search_Property_By_ID(id);
                        foreach (var property in propResult)
                        {
                            //Getting the photos of a property by its ID
                            var propPhoto = r.Search_Property_Photo_By_ID(property.ID).ToList();

                            DisplayProperty ds = new DisplayProperty(property, propPhoto);
                            ds.Click += (object o, EventArgs e2) =>
                            {
                                PropertyDetail details = new PropertyDetail("Viewing Owned Properties", property.ID.ToString(), property.Address, property.Status, property.Price.ToString(), property.Description, id);
                                details.Height += 60;
                                details.ShowDialog();
                            };

                            flowLayoutPanel1.Controls.Add(ds);
                            count++;
                        }
                    }
                    lbl_Result.Text += count.ToString();
                }
            }
            else
            {
                MessageBox.Show("There are no owned properties yet!");
                lbl_Result.Text += "0";

            }
        }
    }
}
