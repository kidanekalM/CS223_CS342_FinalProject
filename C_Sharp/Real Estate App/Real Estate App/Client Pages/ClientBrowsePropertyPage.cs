using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Real_Estate_App.Client_Pages
{
    public partial class ClientBrowsePropertyPage : Form
    {
        private ClientContainer container = null;
        public ClientBrowsePropertyPage(ClientContainer container)
        {
            InitializeComponent();
            this.container = container;
        }
        private void lbl_IdSearch_Click(object sender, EventArgs e)
        {
            pnl_IdButtonPanel.BackColor = Color.Gainsboro;
            pnl_IdSearch.Visible = true;
            pnl_FilterButtonPanel.BackColor = Color.DimGray;
            pnl_FilterSearch.Visible = false;
        }

        private void lbl_Filter_Click(object sender, EventArgs e)
        {
            pnl_FilterButtonPanel.BackColor = Color.Gainsboro;
            pnl_FilterSearch.Visible = true;
            pnl_IdButtonPanel.BackColor = Color.DimGray;
            pnl_IdSearch.Visible = false;
        }

        private void txt_id_Enter(object sender, EventArgs e)
        {
            if (txt_id.Text == "Property Id")
            {
                txt_id.Text = "";
                txt_id.ForeColor = Color.Black;
            }
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                txt_id.Text = "Property Id";
                txt_id.ForeColor = Color.Silver;
            }
        }

        private void txt_Price_Enter(object sender, EventArgs e)
        {
            if (txt_Price.Text == "Price")
            {
                txt_Price.Text = "";
                txt_Price.ForeColor = Color.Black;
            }
        }

        private void txt_Price_Leave(object sender, EventArgs e)
        {
            if (txt_Price.Text == "")
            {
                txt_Price.Text = "Price";
                txt_Price.ForeColor = Color.Silver;
            }
        }

        private void btn_IdSearch_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            errorProvider.Clear();

            if (txt_id.Text == "Property Id")
            {
                errorProvider.SetError(btn_IdSearch, "Id must be provided!");
                hasError = true;
            }

            if (hasError == false)
            {
                ClientSearchResultPage searchResult = new ClientSearchResultPage(container, this);
                searchResult.MdiParent = container;
                searchResult.Show();
                this.Hide();
            }
        }

        private void btn_FilterSearch_Click(object sender, EventArgs e)
        {
            ClientSearchResultPage searchResult = new ClientSearchResultPage(container, this);
            searchResult.MdiParent = container;
            searchResult.Show();
            this.Hide();
        }
    }
}
