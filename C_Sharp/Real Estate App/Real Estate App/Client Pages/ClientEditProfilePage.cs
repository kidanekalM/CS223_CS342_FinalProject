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

namespace Real_Estate_App
{
    public partial class ClientEditProfilePage : Form
    {
        private ClientContainer containerPage = null;
        private ClientProfilePage profilePage = null;
        public ClientEditProfilePage(ClientContainer containerPage, ClientProfilePage profilePage, string firstName, string lastName, string email, string phoneNumber, string gender)
        {
            InitializeComponent();
            this.containerPage = containerPage;
            this.profilePage = profilePage;
            txt_FirstName.Text = firstName;
            txt_LastName.Text = lastName;
            txt_Email.Text = email;
            txt_PhoneNo.Text = phoneNumber;

            if (gender.Equals("male", StringComparison.OrdinalIgnoreCase))
            {
                rb_Male.Checked = true;
                rb_Female.Checked = false;
            }
            else if (gender.Equals("female", StringComparison.OrdinalIgnoreCase))
            {
                rb_Male.Checked = false;
                rb_Female.Checked = true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Regex name = new Regex(@"^[A-Za-z]{1,50}$");
            Regex email = new Regex(@"^[A-Za-z0-9]+[.-_]{0,1}[A-Za-z0-9]+[@][A-Za-z]+[.][a-z]{2,3}");
            Regex phone = new Regex(@"^[0-9]{10}$");

            bool hasError = false;
            errorProvider.Clear();

            //Checking if the proper characters are used
            if (!name.IsMatch(txt_FirstName.Text))
            {
                errorProvider.SetError(txt_FirstName, "Only characters A-Z are allowed!");
                hasError = true;
            }
            if (!name.IsMatch(txt_LastName.Text))
            {
                errorProvider.SetError(txt_LastName, "Only characters A-Z are allowed!");
                hasError = true;
            }
            if (!email.IsMatch(txt_Email.Text))
            {
                errorProvider.SetError(txt_Email, "Invalid E-mail!");
                hasError = true;
            }
            if (!phone.IsMatch(txt_PhoneNo.Text))
            {
                errorProvider.SetError(txt_PhoneNo, "Only numbers of 10 digits are allowed!");
                hasError = true;
            }

            //Checking if the text boxes are filled in
            if (txt_FirstName.Text == "First Name")
            {
                errorProvider.SetError(txt_FirstName, "First Name must be provided!");
                hasError = true;
            }
            if (txt_LastName.Text == "Last Name")
            {
                errorProvider.SetError(txt_LastName, "Last Name must be provided!");
                hasError = true;
            }
            if (txt_Email.Text == "E-mail")
            {
                errorProvider.SetError(txt_Email, "E-mail must be provided!");
                hasError = true;
            }
            if (txt_PhoneNo.Text == "Phone Number")
            {
                errorProvider.SetError(txt_PhoneNo, "Phone Number must be provided!");
                hasError = true;
            }
            if (!rb_Male.Checked && !rb_Female.Checked)
            {
                errorProvider.SetError(grpbx_Gender, "Gender must be provided!");
                hasError = true;
            }

            //Performing the action after validating
            if (hasError == false)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to save the changes?", "Edit Profile", buttons);
                if (result == DialogResult.Yes)
                {
                    String gender = null;
                    if (rb_Male.Checked)
                        gender = "Male";
                    else if (rb_Female.Checked)
                        gender = "Female";

                    MessageBox.Show("Update successfull!");

                    ClientProfilePage profilePage = new ClientProfilePage(containerPage, txt_FirstName.Text, txt_LastName.Text, txt_Email.Text, txt_PhoneNo.Text, gender);
                    profilePage.MdiParent = containerPage;
                    profilePage.Show();
                    this.Hide();
                }

            }

        }

        private void txt_FirstName_Enter(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "First Name")
            {
                txt_FirstName.Text = "";
                txt_FirstName.ForeColor = Color.Black;
            }
        }

        private void txt_FirstName_Leave(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "")
            {
                txt_FirstName.Text = "First Name";
                txt_FirstName.ForeColor = Color.Silver;
            }
        }

        private void txt_LastName_Enter(object sender, EventArgs e)
        {
            if (txt_LastName.Text == "Last Name")
            {
                txt_LastName.Text = "";
                txt_LastName.ForeColor = Color.Black;
            }
        }

        private void txt_LastName_Leave(object sender, EventArgs e)
        {
            if (txt_LastName.Text == "")
            {
                txt_LastName.Text = "Last Name";
                txt_LastName.ForeColor = Color.Silver;
            }
        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if (txt_Email.Text == "E-mail")
            {
                txt_Email.Text = "";
                txt_Email.ForeColor = Color.Black;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                txt_Email.Text = "E-mail";
                txt_Email.ForeColor = Color.Silver;
            }
        }

        private void txt_PhoneNo_Enter(object sender, EventArgs e)
        {
            if (txt_PhoneNo.Text == "Phone Number")
            {
                txt_PhoneNo.Text = "09";
                txt_PhoneNo.ForeColor = Color.Black;
            }
        }

        private void txt_PhoneNo_Leave(object sender, EventArgs e)
        {
            if (txt_PhoneNo.Text == "09" || txt_PhoneNo.Text == "")
            {
                txt_PhoneNo.Text = "Phone Number";
                txt_PhoneNo.ForeColor = Color.Silver;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            profilePage.Show();
        }
    }
}
