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
        public AgentContainor()
        {
            InitializeComponent();
        }
        public AgentContainor(Model.Login_Agent_Result agent)
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentHomePage agentPage = new AgentHomePage();
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

            AgentHomePage agentPage = new AgentHomePage();
            agentPage.MdiParent = this;
            agentPage.Show();
        }

        private void lInkedClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            ClientsLinkedtoAgent Client = new ClientsLinkedtoAgent();
            Client.MdiParent = this;
            Client.Show();

        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            AgentAppointment app = new AgentAppointment();
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

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            //DeleteRecord Deletesale = new DeleteRecord();
            //Deletesale.MdiParent = this;
            //Deletesale.Show();

        }
    }
}
