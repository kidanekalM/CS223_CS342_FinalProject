using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Real_Estate_App.Model;

namespace Real_Estate_App.Agent_pages
{
    public partial class frmsale : UserControl
    {
        Search_Buy_By_AgentId_Result pro = new Search_Buy_By_AgentId_Result();
       
        public frmsale()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            pro.AgentID = int.Parse(textagent.Text);
            pro.PropertyID = int.Parse(textproperty.Text);
            pro.SellDate = DateTime.Now;
            pro.ClientID = int.Parse(textclient.Text);
            pro.Comission = decimal.Parse(textcomission.Text);
            using (RealEstateEDM rs = new RealEstateEDM(" agent "))
            {

                rs.Add_Buy(pro.PropertyID, pro.ClientID, pro.AgentID, pro.SellDate, pro.Comission);
                //rs.SaveChanges();

            }
        }

       void populatedatagridview()
        {
            using(RealEstateEDM rs = new RealEstateEDM(" agent "))
            {
                dgvsalerecords.DataSource = rs.Add_Buy(pro.PropertyID, pro.ClientID, pro.AgentID, pro.SellDate, pro.Comission); 
            }
        }

        private void frmsale_Load(object sender, EventArgs e)
        {
            populatedatagridview();
        }

        private void dgvsalerecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvsalerecords.CurrentRow.Index != -1)
            {
                pro.PropertyID = Convert.ToInt32(dgvsalerecords.CurrentRow.Cells[" PropertyID"].Value);
                pro.ClientID = Convert.ToInt32(dgvsalerecords.CurrentRow.Cells["ClientID"].Value);
                pro.AgentID = Convert.ToInt32(dgvsalerecords.CurrentRow.Cells[" AgentID"].Value);
                pro.SellDate = Convert.ToDateTime(dgvsalerecords.CurrentRow.Cells[" SellDate"].Value);
                pro.Comission = Convert.ToDecimal(dgvsalerecords.CurrentRow.Cells[" Comission"].Value);

                textagent.Text = pro.AgentID.ToString();
                textclient.Text = pro.ClientID.ToString();
                textcomission.Text = pro.Comission.ToString();
                textproperty.Text = pro.PropertyID.ToString();
                dtpsell.Value = pro.SellDate;

            }
        }
    }
}
