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
    public partial class AppointmentPage : Form
    {
        public int AgentID { get; set; }
        public AppointmentPage(int agentID)
        {
            InitializeComponent();
            AgentID = agentID;
        }

        private void AppointmentPage_Load(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Agent"))
            {
                dataGridView1.DataSource = r.Get_All_Appointments();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Agent"))
            {
                dataGridView1.DataSource = r.Search_Appointment_By_AgentID(AgentID).Where(App => App.ClientID.ToString().Contains(txt_Search.Text) || App.AppointmentDate.ToString().Contains(txt_Search.Text) || App.Comment.ToLower().Contains(txt_Search.Text.ToLower()));
            }
        }
    }
}
