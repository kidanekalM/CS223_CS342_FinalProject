using Real_Estate_App.Model;
using Real_Estate_App.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.Client_Pages
{
    public partial class ClientSearchResultPage : Form
    {
        private ClientContainer container;
        private ClientBrowsePropertyPage propertyPage;
        private Search_Property_By_ID_Result result;
        private List<Get_All_Properties_Result> filteredResult;
        private string usedFor;
        private int UserId;
        private int count;
        public ClientSearchResultPage(ClientContainer container, ClientBrowsePropertyPage propertyPage, Search_Property_By_ID_Result result, string usedFor, int userId)
        {
            InitializeComponent();
            this.container = container;
            this.propertyPage = propertyPage;
            this.result = result;
            this.usedFor = usedFor;
            UserId = userId;
        }
        public ClientSearchResultPage(ClientContainer container, ClientBrowsePropertyPage propertyPage, List<Get_All_Properties_Result> filteredResult, string usedFor, int userId)
        {
            InitializeComponent();
            this.container = container;
            this.propertyPage = propertyPage;
            this.filteredResult = filteredResult;
            this.usedFor = usedFor;
            UserId = userId;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            propertyPage.Show();
        }

        private void ClientSearchResultPage_Load(object sender, EventArgs e)
        {
            count = 0;
            if (usedFor == "Id search")
            {
                using (RealEstateEDM rm = new RealEstateEDM("Client"))
                {
                    var propPhoto = rm.Search_Property_Photo_By_ID(result.ID).ToList();

                    DisplayProperty ds = new DisplayProperty(result, propPhoto);
                    ds.Click += (object o, EventArgs e2) =>
                    {
                        PropertyDetail details = new PropertyDetail("Viewing on search", result.ID.ToString(), result.Address, result.Status, result.Price.ToString(), result.Description, UserId);
                        details.Height += 60;
                        details.ShowDialog();
                    };

                    flowLayoutPanel.Controls.Add(ds);
                    count++;
                }
                lbl_Result.Text += count.ToString();
            }
            else if (usedFor == "Filter search")
            {
                count = 0;
                using (RealEstateEDM rm = new RealEstateEDM("Client"))
                {
                    foreach (var property in filteredResult)
                    {
                        DisplayProperty ds = new DisplayProperty(property);
                        ds.Click += (object o, EventArgs e2) =>
                        {
                            PropertyDetail details = new PropertyDetail("Viewing on search", property.ID.ToString(), property.Address, property.Status, property.Price.ToString(), property.Description, UserId);
                            details.Height += 60;
                            details.ShowDialog();
                        };

                        flowLayoutPanel.Controls.Add(ds);
                        count++;
                    }
                    lbl_Result.Text += count.ToString();
                }
            }
        }
    }
}
