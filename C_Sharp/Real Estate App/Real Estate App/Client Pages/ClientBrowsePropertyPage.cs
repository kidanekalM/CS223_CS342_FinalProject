using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Real_Estate_App.Model;

namespace Real_Estate_App.Client_Pages
{
    public partial class ClientBrowsePropertyPage : Form
    {
        private ClientContainer container = null;
        private int UserId;
        private Regex num = new Regex(@"^[0-9]");
        public ClientBrowsePropertyPage(ClientContainer container, int UserId)
        {
            InitializeComponent();

            this.container = container;
            this.UserId = UserId;
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

            if (!num.IsMatch(txt_id.Text))
            {
                errorProvider.SetError(btn_IdSearch, "Id must be a number!");
                hasError = true;
            }
            if (txt_id.Text == "Property Id")
            {
                errorProvider.SetError(btn_IdSearch, "Id must be provided!");
                hasError = true;
            }

            if (hasError == false)
            {
                try
                {
                    using (RealEstateEDM rm = new RealEstateEDM("Client"))
                    {
                        Search_Property_By_ID_Result propResult = (Search_Property_By_ID_Result)rm.Search_Property_By_ID(int.Parse(txt_id.Text)).FirstOrDefault();

                        if (propResult != null)
                        {
                            ClientSearchResultPage searchResult = new ClientSearchResultPage(container, this, propResult, "Id search", UserId);
                            searchResult.MdiParent = container;
                            searchResult.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("No search results were found!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Property search failed! \n" + ex.Message);
                }
            }
        }

        private void btn_FilterSearch_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            errorProvider.Clear();

            if (!num.IsMatch(txt_Price.Text))
            {
                errorProvider.SetError(txt_Price, "Price must be a number!");
                hasError = true;
            }
            if (string.IsNullOrEmpty(cmbx_Address.Text) && txt_Price.Text == "Price")
            {
                errorProvider.SetError(cmbx_Address, "At least one field must be provided!");
                errorProvider.SetError(txt_Price, "At least one field must be provided!");
                hasError = true;
            }

            if (hasError == false)
            {
                try
                {
                    using (RealEstateEDM rm = new RealEstateEDM("Client"))
                    {
                        double price;
                        List<Get_All_Properties_Result> QueriedResults;
                        if (txt_Price.Text != "Price")
                            price = double.Parse(txt_Price.Text);
                        else
                            price = 9999999999999;

                        var allProperties = rm.Get_All_Properties();

                        if (string.IsNullOrEmpty(cmbx_Address.Text) || cmbx_Address.Text == "(none)")
                            QueriedResults = allProperties.Where(property => property.Status == true && property.Price <= price).ToList<Get_All_Properties_Result>();
                        else
                            QueriedResults = allProperties.Where(property => property.Status == true && property.Address == cmbx_Address.Text && property.Price <= price).ToList<Get_All_Properties_Result>();

                        if (QueriedResults.Count > 0)
                        {
                            ClientSearchResultPage searchResult = new ClientSearchResultPage(container, this, QueriedResults, "Filter search", UserId);
                            searchResult.MdiParent = container;
                            searchResult.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("No filter results were found!");

                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        MessageBox.Show("Property filter failed! \n" + ex.Message + ex.InnerException);
                    else
                        MessageBox.Show("Property filter failed! \n" + ex.Message);
                }
            }
        }
    }
}
