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
    public partial class ClientProfilePage : Form
    {
        private ClientContainer container = null;
        public ClientProfilePage(ClientContainer cc, string firstName, string lastName, string email, string phoneNumber, string gender)
        {
            InitializeComponent();
            container = cc;
            lbl_FirstName.Text = firstName;
            lbl_LastName.Text = lastName;
            lbl_Email.Text = email;
            lbl_PhoneNo.Text = phoneNumber;
            if (gender.Equals("male", StringComparison.OrdinalIgnoreCase))
                lbl_Gender.Text = "Male";
            else if (gender.Equals("female", StringComparison.OrdinalIgnoreCase))
                lbl_Gender.Text = "Female";

        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            ClientEditProfilePage editPage = new ClientEditProfilePage(container, this, lbl_FirstName.Text, lbl_LastName.Text, lbl_Email.Text, lbl_PhoneNo.Text, lbl_Gender.Text);
            editPage.MdiParent = container;
            editPage.Show();
            this.Hide();
        }
    }
}
