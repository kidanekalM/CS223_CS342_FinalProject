using Real_Estate_App.Model;
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
    public partial class AdminShowAllProperties : Form
    {
        public AdminShowAllProperties()
        {
            InitializeComponent();
        }

        private void AdminShowAllProperties_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Property.GetAllProperties();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (comboBox_Search.Text == "Id")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Property.SearchPropertiesbyId(SearchtextBox.Text);
            }
            else if (comboBox_Search.Text == "Type")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Property.SearchPropertiesbyType(SearchtextBox.Text);
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
