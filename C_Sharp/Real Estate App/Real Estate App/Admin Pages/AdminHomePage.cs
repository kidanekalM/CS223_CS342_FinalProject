﻿using Real_Estate_App;
using Real_Estate_App.Admin_Pages;
using Real_Estate_App.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;  
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRealEstate
{
    public partial class AdminHomePage : Form
    {
        private int v;

        public Real_Estate_App.Model.Search_Employee_By_ID_Result Admin { get; set; }

        public AdminHomePage(int v)
        {
            InitializeComponent();
            this.v = v;

        }



        public List<Real_Estate_App.Model.Get_All_Employees_Result> Employees { get; set; }
        public List<Real_Estate_App.Model.Get_All_Properties_Result> Properties { get; set; }
        public List<Real_Estate_App.Model.Get_All_Clients_Result> Clients { get; set; }


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
            ShowAllCustPanel.Visible = false;


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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

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
            pictureBox2.Hide();
            BarShowButton.Show();

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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

            idtext.Text = IDlbl.Text;
            fullnametext.Text = NAMElbl.Text;
            phonetext.Text = PHONElbl.Text;

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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

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

        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAddress.Text) || string.IsNullOrEmpty(textArea.Text) || string.IsNullOrEmpty(textSell.Text) || string.IsNullOrEmpty(textDescription.Text) || string.IsNullOrEmpty(txtType.Text))
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
                if (string.IsNullOrEmpty(txtType.Text))
                {
                    errorProvider1.SetError(txtType, "Type is required!!");
                }
                else
                {
                    errorProvider1.SetError(txtType, "");
                }
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
                    {
                        var d = r.Add_Property(textAddress.Text, double.Parse(textSell.Text),txtType.Text, double.Parse(textArea.Text),StatusCheckBox.Checked,textDescription.Text);
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
            txtType.Text = "";
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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;
            if (PropertiesPanel.Visible == true)
            {
                AddPropertyPanel.Visible = true;
            }
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = true;
            HomePanel.Visible = false;
            EmployeesPanel.Visible = false;
            CustomersPanel.Visible = false;
            AppointmentPanel.Visible = false;
            EditProfilePanel.Visible = false;
            ShowAllEmpPanel.Visible = false;
            AddPropertyPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

            if (PropertiesPanel.Visible == true)
            {
                ShowAllPropPanel.Visible = true;
            }
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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

        }

        private void SaveProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtext.Text) || string.IsNullOrEmpty(fullnametext.Text) || string.IsNullOrEmpty(phonetext.Text) || string.IsNullOrEmpty(pwdtext.Text))
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
                if (string.IsNullOrEmpty(phonetext.Text))
                {
                    errorProvider1.SetError(phonetext, "Phone is required!!");
                }
                else
                {
                    errorProvider1.SetError(phonetext, "");
                }
                if (string.IsNullOrEmpty(pwdtext.Text))
                {
                    errorProvider1.SetError(pwdtext, "Password is required!!");
                }
                else
                {
                    errorProvider1.SetError(pwdtext, "");
                }
            }
            else
            {
                IDlbl.Text = idtext.Text;
                NAMElbl.Text = fullnametext.Text;
                PHONElbl.Text = phonetext.Text;
                Admin.Password = pwdtext.Text;
                clear2();
            }

        }
        void clear2()
        {
            idtext.Text = "";
            fullnametext.Text = "";
            phonetext.Text = "";
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
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

        }

        private void showToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = true;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;
            ShowAllEmpPanel.Visible = true;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;
            using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
            {
                cb_Department.Items.Clear();
                try
                {
                    foreach (var dep in r.Get_All_Departments())
                    {
                        cb_Department.Items.Add(dep.ID + ": " + dep.Name);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                try
                {
                    var SearchEmployees = r.Get_All_Employees();
                    Employees = SearchEmployees.ToList<Real_Estate_App.Model.Get_All_Employees_Result>();
                    if (SearchEmployees == null)
                    {
                        lbl_SearchMessage.Text = "There are no Employees found";
                    }
                    else
                    {
                        lbl_SearchMessage.Text = "Employees";
                        tableLayoutPanel2.Controls.Clear();
                        foreach (var employee in SearchEmployees)
                        {
                            Real_Estate_App.User_Control.DisplayPerson d = new Real_Estate_App.User_Control.DisplayPerson(employee);
                            d.Click += EmployeeClicked;
                            tableLayoutPanel2.Controls.Add(d);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
        }

        private void BarShowButton_Click_1(object sender, EventArgs e)
        {
            HomeButton.Show();
            PropertiesButton.Show();
            EmployeesButton.Show();
            CustomersButton.Show();
            BarHideButton.Show();
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
                    var d = r.Add_Employee(txt_firstName.Text, txt_LastName.Text, txt_PhoneNumber.Text, txt_Password.Text, ImageToByteArray(pic_BigPicture.Image), txt_empType.Text, dateTimePicker1.Value, int.Parse(cb_Department.SelectedItem.ToString().Substring(0, cb_Department.SelectedItem.ToString().IndexOf(':'))));
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

        private void PropRefresh_lbl_Click(object sender, EventArgs e)
        {
            using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
            {
                cb_Department.Items.Clear();
                try
                {
                    foreach (var dep in r.Get_All_Departments())
                    {
                        cb_Department.Items.Add(dep.ID + ": " + dep.Name);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                try
                {
                    var SearchProperties = r.Get_All_Properties();
                    Properties = SearchProperties.ToList<Real_Estate_App.Model.Get_All_Properties_Result>();
                    if (SearchProperties == null)
                    {
                        label28.Text = "There are no Properties found";
                    }
                    else
                    {
                        label28.Text = "Properties";
                        tableLayoutPanel1.Controls.Clear();
                        foreach (var property in SearchProperties)
                        {
                            Real_Estate_App.User_Control.DisplayProperties d = new DisplayProperties();
                            /*d.Click += EmployeeClicked;*/
                            tableLayoutPanel1.Controls.Add(d);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
            ShowAllPropPanel.Refresh();
        }

        private void circularPictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(op.FileName);
                circularPictureBox3.Image = img;
            }
        }

        private void pic_BigPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(op.FileName);
                pic_BigPicture.Image = img;
            }
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

        private void label21_Click(object sender, EventArgs e)
        {
            if (SearchtextBox.Text != null || SearchtextBox.Text.All(c => c == ' '))
            textBox2_TextChanged(sender, e);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Employees != null)
                {
                    var SearchRsult = Employees.Where(emp => emp.FirstName.ToLower().Contains(SearchtextBox2.Text.ToLower()) || emp.LastName.ToLower().Contains(SearchtextBox2.Text.ToLower())).ToList();
                    if (SearchRsult == null || SearchRsult.ToArray().Length == 0)
                    {
                        lbl_SearchMessage.Text = "There are no Employees found";
                        return;
                    }
                    else
                    {
                        lbl_SearchMessage.Text = "Employees";
                        tableLayoutPanel2.Controls.Clear();
                        foreach (var employee in Employees.Where(emp => emp.FirstName.ToLower().Contains(SearchtextBox2.Text.ToLower()) || emp.LastName.ToLower().Contains(SearchtextBox2.Text.ToLower())).ToList())
                        {
                            Real_Estate_App.User_Control.DisplayPerson d = new Real_Estate_App.User_Control.DisplayPerson(employee);
                            d.Click += EmployeeClicked;
                            tableLayoutPanel2.Controls.Add(d);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeClicked(object sender, EventArgs e)
        {
            Real_Estate_App.User_Control.DisplayPerson d = (Real_Estate_App.User_Control.DisplayPerson)sender;
            using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
            {
                try
                {
                    var employee = r.Search_Employee_By_ID(d.ID);
                    EmployeeDetail empD = new EmployeeDetail();
                    foreach (var emp in employee)
                    {
                        empD = new EmployeeDetail(emp);
                    }
                    if (empD != null)
                        empD.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
        }

        private void homeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = true;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = false;

        }

        private void showToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = false;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            AppointmentPanel.Visible = false;
            CustomersPanel.Visible = true;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            AddEmployeePanel.Visible = false;
            ShowAllEmpPanel.Visible = false;
            ShowAllPropPanel.Visible = false;
            ShowAllCustPanel.Visible = true;
            using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
            {
                cb_Department.Items.Clear();
                try
                {
                    foreach (var dep in r.Get_All_Departments())
                    {
                        cb_Department.Items.Add(dep.ID + ": " + dep.Name);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                try
                {
                    var SearchEmployees = r.Get_All_Clients();
                    Clients = SearchEmployees.ToList<Real_Estate_App.Model.Get_All_Clients_Result>();
                    if (SearchEmployees == null)
                    {
                        label31.Text = "There are no Customers found";
                    }
                    else
                    {
                        label31.Text = "Customers";
                        tableLayoutPanel4.Controls.Clear();
                        foreach (var employee in SearchEmployees)
                        {
                            Real_Estate_App.User_Control.DisplayPerson d = new Real_Estate_App.User_Control.DisplayPerson(employee);
                            d.Click += CustomerClicked;
                            tableLayoutPanel4.Controls.Add(d);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
        }

        private void PropertyClicked(object sender, EventArgs e)
        {

        }

        private void CustomerClicked(object sender, EventArgs e)
        {
            Real_Estate_App.User_Control.DisplayPerson d = (Real_Estate_App.User_Control.DisplayPerson)sender;
            using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
            {
                try
                {
                    var customer = r.Search_Client_By_ID(d.ID);
                    CustomerDetail custD = new CustomerDetail();
                    foreach (var cust in customer)
                    {
                        custD = new CustomerDetail(cust);
                    }
                    if (custD != null)
                        custD.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
        }
        private void EmpRefreshlbl_Click(object sender, EventArgs e)
        {
            using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
            {
                cb_Department.Items.Clear();
                try
                {
                    foreach (var dep in r.Get_All_Departments())
                    {
                        cb_Department.Items.Add(dep.ID + ": " + dep.Name);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                try
                {
                    var SearchEmployees = r.Get_All_Employees();
                    Employees = SearchEmployees.ToList<Real_Estate_App.Model.Get_All_Employees_Result>();
                    if (SearchEmployees == null)
                    {
                        lbl_SearchMessage.Text = "There are no Employees found";
                    }
                    else
                    {
                        lbl_SearchMessage.Text = "Employees";
                        tableLayoutPanel2.Controls.Clear();
                        foreach (var employee in SearchEmployees)
                        {
                            Real_Estate_App.User_Control.DisplayPerson d = new Real_Estate_App.User_Control.DisplayPerson(employee);
                            d.Click += EmployeeClicked;
                            tableLayoutPanel2.Controls.Add(d);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
            ShowAllEmpPanel.Refresh();

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Clients != null)
                {
                    var SearchRsult = Clients.Where(emp => emp.FirstName.ToLower().Contains(textBox2.Text.ToLower()) || emp.LastName.ToLower().Contains(textBox2.Text.ToLower())).ToList();
                    if (SearchRsult == null || SearchRsult.ToArray().Length == 0)
                    {
                        label31.Text = "There are no Customers found";
                        return;
                    }
                    else
                    {
                        label31.Text = "Customers";
                        tableLayoutPanel4.Controls.Clear();
                        foreach (var employee in Clients.Where(emp => emp.FirstName.ToLower().Contains(textBox2.Text.ToLower()) || emp.LastName.ToLower().Contains(textBox2.Text.ToLower())).ToList())
                        {
                            Real_Estate_App.User_Control.DisplayPerson d = new Real_Estate_App.User_Control.DisplayPerson(employee);
                            d.Click += CustomerClicked;
                            tableLayoutPanel4.Controls.Add(d);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustRefresh_lbl_Click(object sender, EventArgs e)
        {
            using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
            {
                cb_Department.Items.Clear();
                try
                {
                    foreach (var dep in r.Get_All_Departments())
                    {
                        cb_Department.Items.Add(dep.ID + ": " + dep.Name);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                try
                {
                    var SearchEmployees = r.Get_All_Clients();
                    Clients = SearchEmployees.ToList<Real_Estate_App.Model.Get_All_Clients_Result>();
                    if (SearchEmployees == null)
                    {
                        label31.Text = "There are no Customers found";
                    }
                    else
                    {
                        label31.Text = "Customers";
                        tableLayoutPanel4.Controls.Clear();
                        foreach (var employee in SearchEmployees)
                        {
                            Real_Estate_App.User_Control.DisplayPerson d = new Real_Estate_App.User_Control.DisplayPerson(employee);
                            d.Click += CustomerClicked;
                            tableLayoutPanel4.Controls.Add(d);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
                ShowAllCustPanel.Refresh();
            }
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {
            if (this.Admin != null)
            {
                IDlbl.Text = Admin.ID.ToString();
                NAMElbl.Text = Admin.FirstName + " " + Admin.LastName;
                PHONElbl.Text = Admin.PhoneNumber;
                idtext.Text = Admin.ID.ToString();
                fullnametext.Text = Admin.FirstName + " " + Admin.LastName;
                phonetext.Text = Admin.PhoneNumber;
                pwdtext.Text = Admin.Password;

                try
                {
                    if (Admin.Photo != null && !Admin.Photo.All(bit1 => bit1 == 0))
                    {
                        using (MemoryStream ms = new MemoryStream(Admin.Photo))
                        {
                            circularPictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        circularPictureBox1.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
                    }
                }
                catch (Exception ex)
                {
                    pic_BigPicture.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
                /*try
                {
                    using (Real_Estate_App.Model.RealEstateEDM r = new Real_Estate_App.Model.RealEstateEDM("Admin"))
                    {
                        comboBox1.Items.Clear();
                        foreach (var dep in r.Get_All_Employees())
                        {
                            comboBox1.Items.Add(dep.ID + ": " + dep.FirstName);
                        }
                        foreach (var dep in r.Search_Employee_By_ID(Customer.EmpId))
                        {
                            comboBox1.SelectedItem = dep.ID + ": " + dep.FirstName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    comboBox1.Items.Add(Customer.EmpId.ToString() + ":");
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
                comboBox1.Enabled = false;
                btn_delete.Hide();
                btn_save.Hide();
                ReplaceImage.Hide();
                */
            }
        }
    }


}
