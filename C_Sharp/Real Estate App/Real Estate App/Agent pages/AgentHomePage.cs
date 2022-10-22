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

namespace Real_Estate_App.Agent_pages
{
    public partial class AgentHomePage : Form
    {
        public Model.Login_Agent_Result Agent { get; set; }
        public AgentHomePage(Model.Login_Agent_Result agent)
        {
            InitializeComponent();
            Agent = agent;
        }
        
        private void AgentHomePage_Load(object sender, EventArgs e)
        {

            using (System.IO.MemoryStream s = new MemoryStream(Agent.Photo))
            {
                try
                {
                    pic_AgentProfilePic.Image = Image.FromStream(s);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }


            lblAgentFirstName.Text = Agent.FirstName;
            lblAgentLastName.Text = Agent.LastName;
            lblAgentPhoneNumber.Text = Agent.PhoneNumber;

        }
    }
}
