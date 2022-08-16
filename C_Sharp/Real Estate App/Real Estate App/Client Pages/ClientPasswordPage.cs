using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App
{
    public partial class ClientPasswordPage : Form
    {
        public ClientPasswordPage()
        {
            InitializeComponent();
        }

        private void txt_OldPassword_Enter(object sender, EventArgs e)
        {
            if (txt_OldPassword.Text == "Old Password")
            {
                txt_OldPassword.Text = "";
                txt_OldPassword.ForeColor = Color.Black;
            }
        }

        private void txt_OldPassword_Leave(object sender, EventArgs e)
        {
            if (txt_OldPassword.Text == "")
            {
                txt_OldPassword.Text = "Old Password";
                txt_OldPassword.ForeColor = Color.Silver;
            }
        }

        private void txt_NewPassword1_Enter(object sender, EventArgs e)
        {
            if (txt_NewPassword1.Text == "New Password")
            {
                txt_NewPassword1.Text = "";
                txt_NewPassword1.ForeColor = Color.Black;
            }
        }

        private void txt_NewPassword1_Leave(object sender, EventArgs e)
        {
            if (txt_NewPassword1.Text == "")
            {
                txt_NewPassword1.Text = "New Password";
                txt_NewPassword1.ForeColor = Color.Silver;
            }
        }

        private void txt_NewPassword2_Enter(object sender, EventArgs e)
        {
            if (txt_NewPassword2.Text == "Confirm Password")
            {
                txt_NewPassword2.Text = "";
                txt_NewPassword2.ForeColor = Color.Black;
            }
        }

        private void txt_NewPassword2_Leave(object sender, EventArgs e)
        {
            if (txt_NewPassword2.Text == "")
            {
                txt_NewPassword2.Text = "Confirm Password";
                txt_NewPassword2.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            //if (txt_OldPassword.Text != )
            //  errorProvider.SetError(txt_OldPassword, "Incorrect Password!");
            if (txt_NewPassword1.Text != txt_NewPassword2.Text)
                errorProvider.SetError(txt_NewPassword2, "The passwords don't match!");
            if (txt_OldPassword.Text == "Old Password")
                errorProvider.SetError(txt_OldPassword, "Old Password must be provided!");
            if (txt_NewPassword1.Text == "New Password")
                errorProvider.SetError(txt_NewPassword1, "New Password must be provided!");
            if (txt_NewPassword2.Text == "Confirm Password")
                errorProvider.SetError(txt_NewPassword2, "Conformation Password must be provided!");

            if (txt_NewPassword1.Text == txt_NewPassword2.Text)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to save the changes?", "Change Password", buttons);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Password changed!");
                }

            }
        }
    }
}
