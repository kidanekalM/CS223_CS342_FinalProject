﻿using System;
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
    public partial class ClientCreateAccountPage : Form
    {
        public ClientCreateAccountPage()
        {
            InitializeComponent();
        }

        /*
         * For first name 
         */
        private void txt_Firstname_Enter(object sender, EventArgs e)
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

        /*
         * For Last name 
         */
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


        /*
         * For Password 
         */
        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.PasswordChar = '*';
                txt_Password.ForeColor = Color.Black;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.PasswordChar = '\0';
                txt_Password.ForeColor = Color.Silver;
            }
        }

        /*
         * For Email 
         */
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

        /*
         * For Phone Number 
         */
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
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            Regex name = new Regex(@"^[A-Za-z]{1,50}$");
            Regex email = new Regex(@"^[A-Za-z0-9]+[.-_]{0,1}[A-Za-z0-9]+[@][A-Za-z]+[.][a-z]{2,3}");
            Regex phone = new Regex(@"^[0-9]{10}$");

            errorProvider.Clear();

            if (!name.IsMatch(txt_FirstName.Text))
                errorProvider.SetError(txt_FirstName, "Only characters A-Z are allowed!");
            if (!name.IsMatch(txt_LastName.Text))
                errorProvider.SetError(txt_LastName, "Only characters A-Z are allowed!");
            if (!email.IsMatch(txt_Email.Text))
                errorProvider.SetError(txt_Email, "Invalid E-mail!");
            if (!phone.IsMatch(txt_PhoneNo.Text))
                errorProvider.SetError(txt_PhoneNo, "Only numbers of 10 digits are allowed!");

            if (txt_FirstName.Text == "First Name")
                errorProvider.SetError(txt_FirstName, "First Name must be provided!");
            if (txt_LastName.Text == "Last Name")
                errorProvider.SetError(txt_LastName, "Last Name must be provided!");
            if (txt_Password.Text == "Password")
                errorProvider.SetError(txt_Password, "Password must be provided!");
            if (txt_Email.Text == "E-mail")
                errorProvider.SetError(txt_Email, "E-mail must be provided!");
            if (txt_PhoneNo.Text == "Phone Number")
                errorProvider.SetError(txt_PhoneNo, "Phone Number must be provided!");
            if (!rb_Male.Checked && !rb_Female.Checked)
                errorProvider.SetError(grpbx_Gender, "Gender must be provided!");
        }

        private void btn_Unhide_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '*')
            {
                btn_Hide.BringToFront();
                txt_Password.PasswordChar = '\0';
            }
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '\0')
            {
                btn_Unhide.BringToFront();
                txt_Password.PasswordChar = '*';

            }
        }
    }
}
