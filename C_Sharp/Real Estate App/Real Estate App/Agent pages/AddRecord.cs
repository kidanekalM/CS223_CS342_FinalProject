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
    public partial class AddRecord : Form
    {
        Search_Buy_By_AgentId_Result p = new Search_Buy_By_AgentId_Result();

        public AddRecord()
        {
            InitializeComponent();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txtagent.Text = "";
            txtclient.Text = "";
            txtcomission.Text = "";
            txtproperty.Text = "";


        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            p.AgentID = int.Parse(txtagent.Text);
            p.PropertyID = int.Parse(txtproperty.Text);
            p.SellDate = DateTime.Now;
            p.ClientID = int.Parse(txtclient.Text);
            p.Comission = decimal.Parse(txtcomission.Text);
            using (RealEstateEDM rs = new RealEstateEDM(" agent "))
            {

                rs.Add_Buy(p.PropertyID, p.ClientID, p.AgentID, p.SellDate, p.Comission);
                //rs.SaveChanges();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();    
        }
    }
}


