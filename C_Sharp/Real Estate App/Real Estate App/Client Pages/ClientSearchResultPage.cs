using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.Client_Pages
{
    public partial class ClientSearchResultPage : Form
    {
        private ClientContainer container = null;
        private ClientBrowsePropertyPage propertyPage = null;
        public ClientSearchResultPage(ClientContainer container, ClientBrowsePropertyPage propertyPage)
        {
            InitializeComponent();
            this.container = container;
            this.propertyPage = propertyPage;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            propertyPage.Show();
        }
    }
}
