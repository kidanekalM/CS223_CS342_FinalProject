using Real_Estate_App.Client_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App
{
    public partial class ClientContainer : Form
    {
        private int Id;
        public ClientContainer(int id)
        {
            InitializeComponent();

            Id = id;
        }
        private void ClientContainer_Load(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientHomePage homePage = new ClientHomePage();
            homePage.MdiParent = this;
            homePage.Show();
        }

        //Calls client profile page
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientProfilePage profilePage = new ClientProfilePage(this, Id);
            profilePage.MdiParent = this;
            profilePage.Show();
        }

        //Calls the page for changing passwords
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientPasswordPage passwordPage = new ClientPasswordPage(this, Id);
            passwordPage.MdiParent = this;
            passwordPage.Show();
        }

        //Used for logging out
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", buttons);
            if (result == DialogResult.Yes)
            {
                Id = 0;

                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.Show();
            }
        }

        //Calls the appointment page
        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientAppointmentPage appointmentPage = new ClientAppointmentPage(this, Id);
            appointmentPage.MdiParent = this;
            appointmentPage.Show();
        }

        //Calls the search property page
        private void browsePropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientBrowsePropertyPage browsePage = new ClientBrowsePropertyPage(this, Id);
            browsePage.MdiParent = this;
            browsePage.Show();
        }

        //Calls the owned property page
        private void ownedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientPropertyPage propertyPage = new ClientPropertyPage(Id);
            propertyPage.MdiParent = this;
            propertyPage.Show();
        }

        //Home page
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientHomePage homePage = new ClientHomePage();
            homePage.MdiParent = this;
            homePage.Show();
        }

        //Used to call the agent page
        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentProfilePage agentPage = new AgentProfilePage(Id);
            agentPage.MdiParent = this;
            agentPage.Show();
        }
    }
}
