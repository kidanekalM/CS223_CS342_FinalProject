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
        public ClientContainer()
        {
            InitializeComponent();
        }
        private void ClientContainer_Load(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientHomePage homePage = new ClientHomePage(this);
            homePage.MdiParent = this;
            homePage.Show();
        }


        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientProfilePage profilePage = new ClientProfilePage(this, Properties.Resources.Default_Profile, "Hawariaw", "Paulos", "hawariaw@email.com", "0972503268");
            profilePage.MdiParent = this;
            profilePage.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientPasswordPage passwordPage = new ClientPasswordPage();
            passwordPage.MdiParent = this;
            passwordPage.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", buttons);
            if (result == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.Show();
            }
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientAppointmentPage appointmentPage = new ClientAppointmentPage();
            appointmentPage.MdiParent = this;
            appointmentPage.Show();
        }

        private void browsePropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientBrowsePropertyPage browsePage = new ClientBrowsePropertyPage(this);
            browsePage.MdiParent = this;
            browsePage.Show();
        }

        private void ownedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientPropertyPage propertyPage = new ClientPropertyPage();
            propertyPage.MdiParent = this;
            propertyPage.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientHomePage homePage = new ClientHomePage(this);
            homePage.MdiParent = this;
            homePage.Show();
        }

        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentProfilePage agentPage = new AgentProfilePage();
            agentPage.MdiParent = this;
            agentPage.Show();
        }
    }
}
