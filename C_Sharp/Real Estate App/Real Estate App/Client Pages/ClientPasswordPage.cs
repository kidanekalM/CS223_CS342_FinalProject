using Real_Estate_App.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Real_Estate_App
{
    public partial class ClientPasswordPage : Form
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private byte[] Photo;
        private string PhoneNo;
        private string Email;
        private string Password;
        private int AgentId;
        private ClientContainer container;
        public ClientPasswordPage(ClientContainer container, int id)
        {
            InitializeComponent();

            this.container = container;
            Id = id;
            PopulateData(id);
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
            bool hasError = false;
            errorProvider.Clear();

            if (txt_OldPassword.Text != Password)
            {
                errorProvider.SetError(txt_OldPassword, "Incorrect Password!");
                hasError = true;
            }
            if (txt_NewPassword1.Text != txt_NewPassword2.Text)
            {
                errorProvider.SetError(txt_NewPassword2, "The passwords don't match!");
                hasError = true;
            }
            if (txt_OldPassword.Text == "Old Password")
            {
                errorProvider.SetError(txt_OldPassword, "Old Password must be provided!");
                hasError = true;
            }
            if (txt_NewPassword1.Text == "New Password")
            {
                errorProvider.SetError(txt_NewPassword1, "New Password must be provided!");
                hasError = true;
            }
            if (txt_NewPassword2.Text == "Confirm Password")
            {
                errorProvider.SetError(txt_NewPassword2, "Conformation Password must be provided!");
                hasError = true;
            }

            if (hasError == false)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to save the changes?", "Change Password", buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (RealEstateEDM rm = new RealEstateEDM("Client"))
                        {
                            rm.Update_Client(Id, FirstName, LastName, Photo, PhoneNo, Email, txt_NewPassword1.Text, AgentId);

                            MessageBox.Show("Password changed!");

                            ClientHomePage homePage = new ClientHomePage();
                            homePage.MdiParent = container;
                            homePage.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured! \n" + ex.Message);
                    }
                }

            }
        }

        private void PopulateData(int id)
        {
            try
            {
                using (RealEstateEDM rm = new RealEstateEDM("Client"))
                {
                    var result = rm.Search_Client_By_ID(id);
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            FirstName = item.FirstName;
                            LastName = item.LastName;
                            Photo = item.Photo;
                            PhoneNo = item.PhoneNumber;
                            Email = item.Email;
                            Password = item.Password;
                            AgentId = item.EmpId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured. Couldn't load Agents Data!\n" + ex.Message);
            }
        }
    }
}
