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
            using (RealEstateEDM m = new RealEstateEDM("Agent"))
            {
                dgvsalerecord.DataSource = m.Search_Buy_By_AgentId(1);
            }
        }

      

        

        private void btnedit_Click(object sender, EventArgs e)
        {
            using (RealEstateEDM rs = new RealEstateEDM("Agent"))
            {

                rs.Update_Buy(x.ID, x.PropertyID, x.ClientID, x.AgentID, x.SellDate, x.Comission);
                MessageBox.Show("The sale record has been edited!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvsalerecord_DoubleClick(object sender, EventArgs e)
        {
            if (dgvsalerecord.CurrentRow.Index != -1)
            {
                x.ID = Convert.ToInt32(dgvsalerecord.CurrentRow.Cells[" ID "].Value);
                x.PropertyID = Convert.ToInt32(dgvsalerecord.CurrentRow.Cells[" PropertyID"].Value);
                x.ClientID = Convert.ToInt32(dgvsalerecord.CurrentRow.Cells["ClientID"].Value);
                x.AgentID = Convert.ToInt32(dgvsalerecord.CurrentRow.Cells[" AgentID"].Value);
                x.SellDate = Convert.ToDateTime(dgvsalerecord.CurrentRow.Cells[" SellDate"].Value);
                x.Comission = Convert.ToDecimal(dgvsalerecord.CurrentRow.Cells[" Comission"].Value);

                txtid.Text = x.ID.ToString();
                txtagent.Text = x.AgentID.ToString();
                txtclient.Text = x.ClientID.ToString();
                txtcomission.Text = x.Comission.ToString();
                txtproperty.Text = x.PropertyID.ToString();
                dtpselldate.Value = x.SellDate;

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure to delete the record?","crud operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(RealEstateEDM y = new RealEstateEDM("Agent"))
                {
                    y.Delete_Buy(x.ID);
                    MessageBox.Show("The sale record has been deleted!");
                }
            }
        }
    }
}
