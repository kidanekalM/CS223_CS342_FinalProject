using Real_Estate_App.Model;
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
    public partial class AgentProfilePage : Form
    {
        public AgentProfilePage(int id)
        {
            InitializeComponent();
            PopulateData(id);
        }

        private void PopulateData(int id)
        {
            try
            {
                using (RealEstateEDM rm = new RealEstateEDM("Client"))
                {
                    var result = rm.Search_Employee_By_ID(id);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            lbl_Firstname.Text = item.FirstName;
                            lbl_Lastname.Text = item.LastName;
                            lbl_PhoneNo.Text = item.PhoneNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Couldn't load Agents Data!\n" + ex.Message);
            }
        }
    }
}
