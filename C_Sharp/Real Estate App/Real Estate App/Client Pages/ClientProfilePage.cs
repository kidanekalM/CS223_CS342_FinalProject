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

namespace Real_Estate_App
{
    public partial class ClientProfilePage : Form
    {
        private ClientContainer container = null;
        private int Id;
        private string Password;
        private int AgentId;

        public ClientProfilePage(ClientContainer cc, int id)
        {
            InitializeComponent();

            container = cc;
            Id = id;
            PopulateData(id);
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            ClientEditProfilePage editPage = new ClientEditProfilePage(container, this, Id, pic_ClientProfilePic.Image, lbl_FirstName.Text, lbl_LastName.Text, lbl_Email.Text, lbl_PhoneNo.Text, Password, AgentId);
            editPage.MdiParent = container;
            editPage.Show();
            this.Hide();
        }

        private void PopulateData(int id)
        {
            try
            {
                using (RealEstateEDM rm = new RealEstateEDM("Client"))
                {
                    var result = rm.Search_Client_By_ID(id);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            using (MemoryStream s = new MemoryStream(item.Photo))
                            {
                                try
                                {
                                    pic_ClientProfilePic.Image = Image.FromStream(s);
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.ToString());
                                }
                            }
                            lbl_FirstName.Text = item.FirstName;
                            lbl_LastName.Text = item.LastName;
                            lbl_Email.Text = item.Email;
                            lbl_PhoneNo.Text = item.PhoneNumber;
                            Password = item.Password;
                            AgentId = item.EmpId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Couldn't load Clients Data!\n" + ex.Message);
            }
        }


    }
}
