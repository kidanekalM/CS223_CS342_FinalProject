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
using Real_Estate_App.Model;
using System.IO;
using System.Drawing.Imaging;

namespace Real_Estate_App
{
    public partial class ClientEditProfilePage : Form
    {
        private ClientContainer containerPage = null;
        private ClientProfilePage profilePage = null;
        private int Id;
        private string Password;
        private int AgentId;
        public ClientEditProfilePage(ClientContainer containerPage, ClientProfilePage profilePage, int id, Image ProfilePic, string firstName, string lastName, string email, string phoneNumber, string password, int agentId)
        {
            InitializeComponent();

            this.containerPage = containerPage;
            this.profilePage = profilePage;
            Id = id;
            Password = password;
            AgentId = agentId;
            pic_ClientPic.Image = ProfilePic;
            txt_FirstName.Text = firstName;
            txt_LastName.Text = lastName;
            txt_Email.Text = email;
            txt_PhoneNo.Text = phoneNumber;

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

            //Performing the action after validating
            if (hasError == false)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to save the changes?", "Edit Profile", buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (RealEstateEDM rm = new RealEstateEDM("Client"))
                        {
                            rm.Update_Client(Id, txt_FirstName.Text, txt_LastName.Text, ImageToByteArray(pic_ClientPic.Image), txt_PhoneNo.Text, txt_Email.Text, Password, AgentId);

                            MessageBox.Show("Update successfull!");

                            ClientProfilePage profilePage = new ClientProfilePage(containerPage, Id);
                            profilePage.MdiParent = containerPage;
                            profilePage.Show();
                            this.Hide();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update failed! \n" + ex.Message);
                    }
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

        private void btn_editPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif;...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_ClientPic.Image = Bitmap.FromFile(ofd.FileName);
            }
        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {
            pic_ClientPic.Image = Properties.Resources.Default_Profile;
        }

        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        public byte[] ImageToByteArray(Image image)
        {
            Bitmap b = new Bitmap(image);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                b.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();

            }
        }
    }
}
