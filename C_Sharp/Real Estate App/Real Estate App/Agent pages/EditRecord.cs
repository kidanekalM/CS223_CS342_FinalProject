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
    public partial class EditRecord : Form
    {
        Search_Buy_By_AgentId_Result x = new Search_Buy_By_AgentId_Result();
        public EditRecord()
        {
            InitializeComponent();
        }

        private void EditRecord_Load(object sender, EventArgs e)
        {
            populatedatagridview();
        }
        void populatedatagridview()
        {
            using (RealEstateEDM m = new RealEstateEDM(" agent "))
            {
                dgvrsalerecords.DataSource = m.Search_Buy_By_AgentId(1);
            }
        }

        private void dgvrsalerecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvrsalerecords.CurrentRow.Index != -1)
            {
                x.PropertyID = Convert.ToInt32(dgvrsalerecords.CurrentRow.Cells[" PropertyID"].Value);
               x.ClientID = Convert.ToInt32(dgvrsalerecords.CurrentRow.Cells["ClientID"].Value);
                 x.AgentID = Convert.ToInt32(dgvrsalerecords.CurrentRow.Cells[" AgentID"].Value);
                x.SellDate = Convert.ToDateTime(dgvrsalerecords.CurrentRow.Cells[" SellDate"].Value);
                x.Comission = Convert.ToDecimal(dgvrsalerecords.CurrentRow.Cells[" Comission"].Value);

                txtagent.Text = x.AgentID.ToString();
                txtclient.Text = x.ClientID.ToString();
                txtcomission.Text = x.Comission.ToString();
                txtproperty.Text = x.PropertyID.ToString();
                dtpselldate.Value = x.SellDate;

            }
        }

        

        private void btnedit_Click(object sender, EventArgs e)
        {
            using (RealEstateEDM rs = new RealEstateEDM(" agent "))
            {

                rs.Update_Buy(x.PropertyID, x.ClientID, x.AgentID, x.SellDate, x.Comission);

            }
        }
    }
}
