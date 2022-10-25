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
    public partial class AgentAppointment : Form
    {
        public Model.Login_Agent_Result Agent { get; set; }
        public AgentAppointment(Model.Login_Agent_Result agent)
        {
            InitializeComponent();
            Agent = agent;
        }

        private void AgentAppointment_Load(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Agent"))
            {
                dgvAgentAppointment.DataSource = r.Get_All_Clients_By_Agent(Agent.ID);
            }
        }
    }
}
