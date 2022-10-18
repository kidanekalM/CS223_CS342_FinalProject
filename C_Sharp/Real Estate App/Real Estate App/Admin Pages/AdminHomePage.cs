using Real_Estate_App;
using Real_Estate_App.Admin_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;  
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRealEstate
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }
       
        AdminShowAllProperties a = new AdminShowAllProperties();
        AdminShowAllEmployees b = new AdminShowAllEmployees();

        private void HomeButton_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = false;
            EmployeesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            HomePanel.Visible = true;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;

            pictureBox2.Top = 88;
            pictureBox2.Height = 112;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = true;
            HomePanel.Visible = false;
            EmployeesPanel.Visible = false;
            CustomersPanel.Visible = false;
            AppointmentPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;

            pictureBox2.Top = 199;
            pictureBox2.Height = 88;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = true;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;

            pictureBox2.Top = 288;
            pictureBox2.Height = 88;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = false;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            CustomersPanel.Visible = true;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;

            pictureBox2.Top = 377;
            pictureBox2.Height = 88;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = false;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            AppointmentPanel.Visible = true;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;

            pictureBox2.Top = 467;
            pictureBox2.Height = 88;

        }

        private void BarHideButton_Click(object sender, EventArgs e)
        {
            HomeButton.Hide();
            PropertiesButton.Hide();
            EmployeesButton.Hide();
            CustomersButton.Hide();
            BarHideButton.Hide();
            FinanceButton.Hide();
            pictureBox2.Hide();
            BarShowButton.Show();

        }

        private void BarShowButton_Click(object sender, EventArgs e)
        {


        }
        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = false;
            EmployeesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            HomePanel.Visible = false;
            CustomersPanel.Visible = false;
            AddPropertyPanel.Visible = false;
            EditProfilePanel.Visible = true;
            AddEmployeePanel.Visible = false;
            idtext.Text = IDlbl.Text;
            fullnametext.Text = NAMElbl.Text;
            emailtext.Text = EMAILlbl.Text;

        }
        private void addPropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* visibility part */

            PropertiesPanel.Visible = true;
            EmployeesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            HomePanel.Visible = false;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = true;
            AddEmployeePanel.Visible = false;


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = true;
            HomePanel.Visible = false;
            EmployeesPanel.Visible = false;
            CustomersPanel.Visible = false;
            AppointmentPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", buttons);
            if (result == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.Show();
            }
        }

        private void allPropertiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAddress.Text) || string.IsNullOrEmpty(textArea.Text) || string.IsNullOrEmpty(textSell.Text) || string.IsNullOrEmpty(textDescription.Text))
            {
                if (string.IsNullOrEmpty(textAddress.Text))
                {
                    errorProvider1.SetError(textAddress, "Address is required!!");
                }
                else
                {
                    errorProvider1.SetError(textAddress, "");
                }
                if (string.IsNullOrEmpty(textArea.Text))
                {
                    errorProvider1.SetError(textArea, "Area is required!!");
                }
                else
                {
                    errorProvider1.SetError(textArea, "");
                }
                if (string.IsNullOrEmpty(textSell.Text))
                {
                    errorProvider1.SetError(textSell, "Sell Price is required!!");
                }
                else
                {
                    errorProvider1.SetError(textSell, "");
                }
                if (string.IsNullOrEmpty(textDescription.Text))
                {
                    errorProvider1.SetError(textDescription, "Description is required!!");
                }
                else
                {
                    errorProvider1.SetError(textDescription, "");
                }
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
                    {
                        var d = r.Add_Property(textAddress.Text, double.Parse(textSell.Text),BigR.Text, double.Parse(textArea.Text),StatusCheckBox.Checked,textDescription.Text);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        errorProvider1.SetError(AddPropertyButton, ex.Message + ex.InnerException.Message);
                    else
                        errorProvider1.SetError(AddPropertyButton, ex.Message);
                }
                clear();
            }
        }
        void clear()
        {
            textArea.Text = "";
            textAddress.Text = "";
            textDescription.Text = "";
            textSell.Text = "";
            groupBox1.Text = "";
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = false;
            EmployeesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            HomePanel.Visible = true;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            pictureBox2.Top = 88;
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = true;
            HomePanel.Visible = false;
            EmployeesPanel.Visible = false;
            CustomersPanel.Visible = false;
            AppointmentPanel.Visible = false;
            EditProfilePanel.Visible = false;
            if (PropertiesPanel.Visible == true)
            {
                AddPropertyPanel.Visible = true;
            }
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = false;
            EmployeesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            HomePanel.Visible = true;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;
        }

        private void SaveProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtext.Text) || string.IsNullOrEmpty(fullnametext.Text) || string.IsNullOrEmpty(emailtext.Text))
            {
                if (string.IsNullOrEmpty(idtext.Text))
                {
                    errorProvider1.SetError(idtext, "ID is required!!");
                }
                else
                {
                    errorProvider1.SetError(idtext, "");
                }
                if (string.IsNullOrEmpty(fullnametext.Text))
                {
                    errorProvider1.SetError(fullnametext, "Name is required!!");
                }
                else
                {
                    errorProvider1.SetError(fullnametext, "");
                }
                if (string.IsNullOrEmpty(emailtext.Text))
                {
                    errorProvider1.SetError(emailtext, "E-mail is required!!");
                }
                else
                {
                    errorProvider1.SetError(emailtext, "");
                }
            }
            else
            {
                IDlbl.Text = idtext.Text;
                NAMElbl.Text = fullnametext.Text;
                EMAILlbl.Text = emailtext.Text;
                clear2();
            }

        }
        void clear2()
        {
            idtext.Text = "";
            fullnametext.Text = "";
            emailtext.Text = "";
        }

        private void addempToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = true;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = true;
        }

        private void showToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            b.Show();
        }

        private void BarShowButton_Click_1(object sender, EventArgs e)
        {
            HomeButton.Show();
            PropertiesButton.Show();
            EmployeesButton.Show();
            CustomersButton.Show();
            BarHideButton.Show();
            FinanceButton.Show();
            pictureBox2.Show();
            BarShowButton.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cb_Department.SelectedItem == null)
            {
                errorProvider1.SetError(cb_Department, "Choose a valid value");
                return;
            }
            Regex name = new Regex(@"^[A-Za-z]{1,50}$");
            Regex phone = new Regex(@"^[0-9]{10}$");
            if (!name.IsMatch(txt_firstName.Text))
            {
                errorProvider1.SetError(txt_firstName, "Only characters A-Z are allowed!");
                return;
            }
            if (!name.IsMatch(txt_LastName.Text))
            {
                errorProvider1.SetError(txt_LastName, "Only characters A-Z are allowed!");
                return;
            }
            if (!phone.IsMatch(txt_PhoneNumber.Text))
            {
                errorProvider1.SetError(txt_PhoneNumber, "Only numbers of 10 digits are allowed!");
                return;
            }
            try
            {
                using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
                { 
                    var d = r.Add_Employee(txt_firstName.Text, txt_LastName.Text, txt_PhoneNumber.Text, txt_Password.Text, b.ImageToByteArray(pic_BigPicture.Image), txt_empType.Text, dateTimePicker1.Value, int.Parse(cb_Department.SelectedItem.ToString().Substring(0, cb_Department.SelectedItem.ToString().IndexOf(':'))));
                    MessageBox.Show(d.First().EmployeeID.ToString() + "is the ID, Use this ID to login in the future");

                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                else
                    MessageBox.Show(ex.Message);
            }
            b.AdminGetAllEmployees_Load(sender, e);
            clear3();
        }
        void clear3()
        {
            pic_BigPicture.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
            txt_empType.Text = "";
            txt_firstName.Text = "";
            txt_LastName.Text = "";
            txt_Password.Text = "";
            txt_PhoneNumber.Text = "";
            cb_Department.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;

        }
    }


}
