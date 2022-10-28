using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.Agent_pages
{
    public partial class AgentContainor : Form
    {
        public Model.Login_Agent_Result Agent { get; set; }
        public LoginPage Login { get; set; }
        public AgentContainor()
        {
            InitializeComponent();
        }
        public AgentContainor(Model.Login_Agent_Result agent,LoginPage login)
        {
            InitializeComponent();
            Agent = agent;
            Login = login;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentHomePage agentPage = new AgentHomePage( Agent );
            agentPage.MdiParent = this;
            agentPage.Show();

        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentPageProperties pro = new AgentPageProperties();
            pro.MdiParent = this;
            pro.Show();

        }

        private void AgentContainor_Load(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentHomePage agentPage = new AgentHomePage( Agent );
            agentPage.MdiParent = this;
            agentPage.Show();
        }

        private void lInkedClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientsLinkedtoAgent Client = new ClientsLinkedtoAgent(Agent);
            Client.MdiParent = this;
            Client.Show();

        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentAppointment app = new AgentAppointment(Agent);
            app.MdiParent = this;
            app.Show();

        }

        private void saleRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            SaleRecords sale = new SaleRecords();
            sale.MdiParent = this;
            sale.Show();


        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AddRecord addsale = new AddRecord();
            addsale.MdiParent = this;
            addsale.Show();

        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            EditRecord editsale = new EditRecord();
            editsale.MdiParent = this;
            editsale.Show();

        }

        private void propertiesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentPageProperties ap = new AgentPageProperties();
            ap.MdiParent = this;
            ap.Show();
        }

        private void AgentContainor_Load_1(object sender, EventArgs e)
        {
            homeToolStripMenuItem_Click(sender, e);
        }

        private void appointmentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            AppointmentPage appointment = new AppointmentPage(Agent.ID);
            appointment.MdiParent = this;
            appointment.Show();
        }

        private void linkedClientsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            My_Clients cl = new My_Clients(Agent.ID);
            cl.MdiParent = this;
            cl.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Are you sure ?", "Log Out", msb);
            if(dr == DialogResult.Yes)
            {
                this.Close();
                Login.Show();
            }
        }
    }
}
