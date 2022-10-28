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
    public partial class AgentPageProperties : Form
    {
        public AgentPageProperties()
        {
            InitializeComponent();
            AgentPageProperties_Load(this, null);
        }

        private void AgentPageProperties_Load(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Agent"))
            {
                this.displayProperties1.Properties = r.Get_All_Properties();
            }
        }


        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            using(Model.RealEstateEDM r = new Model.RealEstateEDM("Agent"))
            {
                this.displayProperties1.Properties = r.Get_All_Properties().Where(property => property.Address.ToLower().Contains(txt_Search.Text.ToLower()));
            }
        }
    }
}
