using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.Admin_Pages
{
    public partial class EmployeeDetail : Form
    {
        public EmployeeDetail()
        {
            InitializeComponent();
        }

        public Model.Search_Employee_By_ID_Result Employee { get; set; }
        public EmployeeDetail(Model.Search_Employee_By_ID_Result emp )
        {
            InitializeComponent();
            if(emp != null)
            Employee = emp;
            else
            {
                MessageBox.Show("No employee found");
                return;
            }
            
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            if (this.Employee != null)
            {
                txt_id.Text = Employee.ID.ToString();
                txt_id.ReadOnly = true;
                txt_fname.Text = Employee.FirstName;
                txt_fname.ReadOnly = true;
                txt_lName.Text = Employee.LastName;
                txt_lName.ReadOnly = true;
                txt_pwd.Text = Employee.Password;
                txt_pwd.ReadOnly = true;
                txt_Type.Text = Employee.EmpType;
                txt_Type.ReadOnly = true;
                dateTimePicker1.Value = Employee.EmpDate;
                dateTimePicker1.Enabled = false;
                try
                {
                    if (Employee.Photo != null && !Employee.Photo.All(bit1 => bit1 == 0))
                    {
                        using (MemoryStream ms = new MemoryStream(Employee.Photo))
                        {
                            pic_BigPicture.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pic_BigPicture.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
                    }
                }
                catch (Exception ex)
                {
                    pic_BigPicture.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
                try
                {
                    using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                    {
                        comboBox1.Items.Clear();
                        foreach(var dep in r.Get_All_Departments())
                        {
                            comboBox1.Items.Add(dep.ID +": "+ dep.Name);
                        }
                        foreach (var dep in r.Search_Department_By_ID(Employee.DepartmentID))
                        {
                            comboBox1.SelectedItem = dep.ID+": "+dep.Name;
                        }
                    }
                }
                catch(Exception ex)
                {
                    comboBox1.Items.Add( Employee.DepartmentID.ToString()+":");
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
                comboBox1.Enabled = false;
                btn_delete.Hide();
                btn_save.Hide();
                ReplaceImage.Hide();
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_fname.ReadOnly)
            {
                ReplaceImage.Show();
                btn_save.Show();
                btn_delete.Show();
                txt_fname.ReadOnly = false;
                txt_lName.ReadOnly=false;
                txt_pNumber.ReadOnly = false;
                txt_pwd.ReadOnly = false;
                txt_Type.ReadOnly = false;
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
            else
            {
                ReplaceImage.Hide();
                btn_save.Hide();
                btn_delete.Hide();
                txt_fname.ReadOnly = true;
                txt_lName.ReadOnly = true;
                txt_pNumber.ReadOnly = true;
                txt_pwd.ReadOnly = true;
                txt_Type.ReadOnly =true;
                comboBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Are you sure you want to delete an employee?","Delete Employee",btns);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                    {
                        r.Delete_Employee(Employee.ID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.InnerException.Message);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Regex name = new Regex(@"^[A-Za-z]{1,50}$");
            Regex phone = new Regex(@"^[0-9]{10}$");
            if (!name.IsMatch(txt_fname.Text))
            {
                errorProvider1.SetError(txt_fname, "Only characters A-Z are allowed!");
                return;
            }
            if (!name.IsMatch(txt_lName.Text))
            {
                errorProvider1.SetError(txt_lName, "Only characters A-Z are allowed!");
                return;
            }
            if (!phone.IsMatch(txt_pNumber.Text))
            {
                errorProvider1.SetError(txt_pNumber, "Only numbers of 10 digits are allowed!");
                return;
            }
            try
            {
                using(Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                {
                    r.Update_Employee(Employee.ID, txt_fname.Text, txt_lName.Text, txt_pNumber.Text, txt_pwd.Text, ImageToByteArray(pic_BigPicture.Image), txt_Type.Text, dateTimePicker1.Value, int.Parse( comboBox1.SelectedItem.ToString().Substring(0, comboBox1.SelectedItem.ToString().IndexOf(":")) ));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException.Message);
            }
        }

        private void ReplaceImage_Click(object sender, EventArgs e)
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
