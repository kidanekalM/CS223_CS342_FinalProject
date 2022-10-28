using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.Admin_Pages
{
    public partial class SoldProperties : Form
    {
        public SoldProperties()
        {
            InitializeComponent();
        }

        private void SoldProperties_Load(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                dataGridView1.DataSource = r.Get_All_Buys();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
