using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Real_Estate_App.Admin_Pages
{
    public partial class AdminGetAllEmployees : Form
    {
        public AdminGetAllEmployees()
        {
            InitializeComponent();
        }
        public AdminGetAllEmployees(string userName)
        {
            InitializeComponent();
            if (userName != null)
                this.UserName = userName;   
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; lbl_Name.Text = _userName; }
        }

        public List<Model.Get_All_Employees_Result> Employees { get; set; } 
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (Employees != null)
                { 
                 var SearchRsult = Employees.Where(emp => emp.FirstName.ToLower().Contains(SearchtextBox.Text.ToLower()) || emp.LastName.ToLower().Contains(SearchtextBox.Text.ToLower())).ToList();
                    if (SearchRsult == null || SearchRsult.ToArray().Length == 0)
                    {
                        lbl_SearchMessage.Text = "There are no Employees found";
                        return;
                    }
                    else
                    {
                        lbl_SearchMessage.Text = "Employees";
                        tableLayoutPanel1.Controls.Clear();
                        foreach (var employee in Employees.Where(emp => emp.FirstName.ToLower().Contains(SearchtextBox.Text.ToLower()) || emp.LastName.ToLower().Contains(SearchtextBox.Text.ToLower())).ToList())
                        {
                            User_Control.DisplayPerson d = new User_Control.DisplayPerson(employee);
                            d.Click += EmployeeClicked;
                            tableLayoutPanel1.Controls.Add(d);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EmployeeClicked(object sender, EventArgs e)
        {
            User_Control.DisplayPerson d = (User_Control.DisplayPerson) sender;
            using(Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
            AdminGetAllEmployees_Load(sender, e);
        }
        private void AdminGetAllEmployees_Load(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                cb_Department.Items.Clear();
                try
                {
                    foreach(var dep in r.Get_All_Departments())
                    {
                        cb_Department.Items.Add(dep.ID + ": " + dep.Name);
                    }
                }
                catch(Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                try
                {
                    var SearchEmployees = r.Get_All_Employees();
                    Employees = SearchEmployees.ToList<Model.Get_All_Employees_Result>();
                    if (SearchEmployees == null)
                    {
                        lbl_SearchMessage.Text = "There are no Employees found";
                    }
                    else
                    {
                        lbl_SearchMessage.Text = "Employees";
                        tableLayoutPanel1.Controls.Clear();
                        foreach (var employee in SearchEmployees)
                        {
                            User_Control.DisplayPerson d = new User_Control.DisplayPerson(employee);
                            d.Click += EmployeeClicked;
                            tableLayoutPanel1.Controls.Add(d);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchtextBox.Text != null || SearchtextBox.Text.All(c => c==' '))
            SearchtextBox_TextChanged(sender, e);
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
                using(Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                {
                    var d = r.Add_Employee(txt_firstName.Text, txt_LastName.Text, txt_PhoneNumber.Text, txt_Password.Text, ImageToByteArray(pic_BigPicture.Image), txt_empType.Text, dateTimePicker1.Value,int.Parse( cb_Department.SelectedItem.ToString().Substring(0, cb_Department.SelectedItem.ToString().IndexOf(':'))));
                    MessageBox.Show(d.First().EmployeeID.ToString() + "is the ID, Use this ID to login in the future");
                    
                }
            }
            catch(Exception ex)
            {
                if (ex.InnerException != null)
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                else
                    MessageBox.Show(ex.Message);
            }
            AdminGetAllEmployees_Load(sender, e);
            clear();
        }
        void clear()
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
        public byte[] ImageToByteArray(Image image)
        {
            Bitmap b = new Bitmap(image);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                b.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();

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
    }
}
