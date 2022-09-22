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
using MyRealEstate;

namespace Real_Estate_App
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void lbl_Client_Click(object sender, EventArgs e)
        {
            pnl_ClientLabel.BackColor = Color.Gainsboro;
            pnl_ClientLogin.Visible = true;
            pnl_AgentLabel.BackColor = Color.Gray;
            pnl_AgentLogin.Visible = false;
            pnl_AdminLabel.BackColor = Color.DimGray;
            pnl_AdminLogin.Visible = false;
        }

        private void lbl_Agent_Click(object sender, EventArgs e)
        {
            pnl_AgentLabel.BackColor = Color.Gainsboro;
            pnl_AgentLogin.Visible = true;
            pnl_ClientLabel.BackColor = Color.DimGray;
            pnl_ClientLogin.Visible = false;
            pnl_AdminLabel.BackColor = Color.DimGray;
            pnl_AdminLogin.Visible = false;
        }

        private void lbl_Admin_Click(object sender, EventArgs e)
        {
            pnl_AdminLabel.BackColor = Color.Gainsboro;
            pnl_AdminLogin.Visible = true;
            pnl_AgentLabel.BackColor = Color.Gray;
            pnl_AgentLogin.Visible = false;
            pnl_ClientLabel.BackColor = Color.DimGray;
            pnl_ClientLogin.Visible = false;
        }

        /*
         * Admin Enter/Leave events, Hide/Unhide Buttons and Login Button
         */

        private void txt_AdminId_Enter(object sender, EventArgs e)
        {
            if (txt_AdminId.Text == "Admin Id")
            {
                txt_AdminId.Text = "";
                txt_AdminId.ForeColor = Color.Black;
            }
        }

        private void txt_AdminId_Leave(object sender, EventArgs e)
        {
            if (txt_AdminId.Text == "")
            {
                txt_AdminId.Text = "Admin Id";
                txt_AdminId.ForeColor = Color.Silver;
            }
        }

        private void txt_AdminPassword_Enter(object sender, EventArgs e)
        {
            if (txt_AdminPassword.Text == "Password")
            {
                txt_AdminPassword.Text = "";
                txt_AdminPassword.PasswordChar = '*';
                txt_AdminPassword.ForeColor = Color.Black;
            }
        }

        private void txt_AdminPassword_Leave(object sender, EventArgs e)
        {
            if (txt_AdminPassword.Text == "")
            {
                txt_AdminPassword.Text = "Password";
                txt_AdminPassword.PasswordChar = '\0';
                txt_AdminPassword.ForeColor = Color.Silver;
            }
        }

        private void btn_UnhideAdminPassword_Click(object sender, EventArgs e)
        {
            if (txt_AdminPassword.PasswordChar == '*')
            {
                btn_HideAdminPassword.BringToFront();
                txt_AdminPassword.PasswordChar = '\0';
            }
        }

        private void btn_HideAdminPassword_Click(object sender, EventArgs e)
        {
            if (txt_AdminPassword.PasswordChar == '\0')
            {
                btn_UnhideAdminPassword.BringToFront();
                txt_AdminPassword.PasswordChar = '*';
            }
        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            errorProvider.Clear();

            if (txt_AdminId.Text == "Admin Id")
            {
                errorProvider.SetError(txt_AdminId, "Admin Id must be provided!");
                hasError = true;
            }
            if (txt_AdminPassword.Text == "Password")
            {
                errorProvider.SetError(txt_AdminPassword, "Admin Password must be provided!");
                hasError = true;
            }

            if (hasError == false)
            {
                Model.SQL_Connection sQL_Connection = new Model.SQL_Connection("Client");
                AdminHomePage a = new AdminHomePage();
                a.Show();
                this.Hide();
            }
        }

        /*
         * Agent Enter/Leave events, Hide/Unhide Buttons and Login Button
         */
        private void txt_AgentId_Enter(object sender, EventArgs e)
        {
            if (txt_AgentId.Text == "Agent Id")
            {
                txt_AgentId.Text = "";
                txt_AgentId.ForeColor = Color.Black;
            }
        }

        private void txt_AgentId_Leave(object sender, EventArgs e)
        {
            if (txt_AgentId.Text == "")
            {
                txt_AgentId.Text = "Agent Id";
                txt_AgentId.ForeColor = Color.Silver;
            }
        }

        private void txt_AgentPassword_Enter(object sender, EventArgs e)
        {
            if (txt_AgentPassword.Text == "Password")
            {
                txt_AgentPassword.Text = "";
                txt_AgentPassword.PasswordChar = '*';
                txt_AgentPassword.ForeColor = Color.Black;
            }
        }

        private void txt_AgentPassword_Leave(object sender, EventArgs e)
        {
            if (txt_AgentPassword.Text == "")
            {
                txt_AgentPassword.Text = "Password";
                txt_AgentPassword.PasswordChar = '\0';
                txt_AgentPassword.ForeColor = Color.Silver;
            }
        }

        private void btn_UnhideAgentPassword_Click(object sender, EventArgs e)
        {
            if (txt_AgentPassword.PasswordChar == '*')
            {
                btn_HideAgentPassword.BringToFront();
                txt_AgentPassword.PasswordChar = '\0';
            }
        }

        private void btn_HideAgentPassword_Click(object sender, EventArgs e)
        {
            if (txt_AgentPassword.PasswordChar == '\0')
            {
                btn_UnhideAgentPassword.BringToFront();
                txt_AgentPassword.PasswordChar = '*';
            }
        }

        private void btn_AgentLogin_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            errorProvider.Clear();

            if (txt_AgentId.Text == "Agent Id")
            {
                errorProvider.SetError(txt_AgentId, "Agent Id must be provided!");
                hasError = true;
            }
            if (txt_AgentPassword.Text == "Password")
            {
                errorProvider.SetError(txt_AgentPassword, "Agent Password must be provided!");
                hasError = true;
            }

            if (hasError == false)
            {
                Model.SQL_Connection sQL_Connection = new Model.SQL_Connection("Agent");
                //open agent page
            }
        }

        /*
         * Client Enter/Leave events, Hide/Unhide Buttons, Login Button and Create Account Link
         */
        private void txt_ClientId_Enter(object sender, EventArgs e)
        {
            if (txt_ClientId.Text == "Client Id")
            {
                txt_ClientId.Text = "";
                txt_ClientId.ForeColor = Color.Black;
            }
        }

        private void txt_ClientId_Leave(object sender, EventArgs e)
        {
            if (txt_ClientId.Text == "")
            {
                txt_ClientId.Text = "Client Id";
                txt_ClientId.ForeColor = Color.Silver;
            }
        }

        private void txt_ClientPassword_Enter(object sender, EventArgs e)
        {
            if (txt_ClientPassword.Text == "Password")
            {
                txt_ClientPassword.Text = "";
                txt_ClientPassword.PasswordChar = '*';
                txt_ClientPassword.ForeColor = Color.Black;
            }
        }

        private void txt_ClientPassword_Leave(object sender, EventArgs e)
        {
            if (txt_ClientPassword.Text == "")
            {
                txt_ClientPassword.Text = "Password";
                txt_ClientPassword.PasswordChar = '\0';
                txt_ClientPassword.ForeColor = Color.Silver;
            }
        }

        private void btn_UnhideClientPassword_Click(object sender, EventArgs e)
        {
            if (txt_ClientPassword.PasswordChar == '*')
            {
                btn_HideClientPassword.BringToFront();
                txt_ClientPassword.PasswordChar = '\0';
            }
        }

        private void btn_HideClientPassword_Click(object sender, EventArgs e)
        {
            if (txt_ClientPassword.PasswordChar == '\0')
            {
                btn_UnhideClientPassword.BringToFront();
                txt_ClientPassword.PasswordChar = '*';
            }
        }

        private void lk_lbl_CreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientCreateAccountPage createPage = new ClientCreateAccountPage();
            createPage.Show();
            this.Hide();
        }

        private void btn_ClientLogin_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            errorProvider.Clear();

            if (txt_ClientId.Text == "Client Id")
            {
                errorProvider.SetError(txt_ClientId, "Client Id must be provided!");
                hasError = true;
            }
            if (txt_ClientPassword.Text == "Password")
            {
                errorProvider.SetError(txt_ClientPassword, "Client Password must be provided!");
                hasError = true;
            }

            if (hasError == false)
            {
                ClientContainer containerPage = new ClientContainer();
                containerPage.Show();
                this.Hide();
                Model.SQL_Connection sQL_Connection = new Model.SQL_Connection("Client");
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
