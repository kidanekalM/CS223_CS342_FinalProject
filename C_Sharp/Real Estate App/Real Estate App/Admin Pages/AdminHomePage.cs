using Real_Estate_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void HomeButton_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = false;
            EmployeesPanel.Visible = false;
            FinancePanel.Visible = false;
            HomePanel.Visible = true;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            pictureBox2.Top = 88;
            pictureBox2.Height = 112;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = true;
            HomePanel.Visible = false;
            EmployeesPanel.Visible = false;
            CustomersPanel.Visible = false;
            FinancePanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            pictureBox2.Top = 199;
            pictureBox2.Height = 88;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = true;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            FinancePanel.Visible = false;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            pictureBox2.Top = 288;
            pictureBox2.Height = 88;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = false;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            FinancePanel.Visible = false;
            CustomersPanel.Visible = true;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            pictureBox2.Top = 377;
            pictureBox2.Height = 88;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmployeesPanel.Visible = false;
            HomePanel.Visible = false;
            PropertiesPanel.Visible = false;
            FinancePanel.Visible = true;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
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
            HomeButton.Show();
            PropertiesButton.Show();
            EmployeesButton.Show();
            CustomersButton.Show();
            FinanceButton.Show();
            pictureBox2.Show();
            BarShowButton.Hide();
            BarHideButton.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = false;
            EmployeesPanel.Visible = false;
            FinancePanel.Visible = false;
            HomePanel.Visible = true;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
            pictureBox2.Top = 88;
        }
        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = false;
            EmployeesPanel.Visible = false;
            FinancePanel.Visible = false;
            HomePanel.Visible = false;
            CustomersPanel.Visible = false;
            AddPropertyPanel.Visible = false;
            EditProfilePanel.Visible = true;
        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {

        }
        private void Exit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = true;
            EmployeesPanel.Visible = false;
            FinancePanel.Visible = false;
            HomePanel.Visible = false;
            CustomersPanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertiesPanel.Visible = true;
            HomePanel.Visible = false;
            EmployeesPanel.Visible = false;
            CustomersPanel.Visible = false;
            FinancePanel.Visible = false;
            EditProfilePanel.Visible = false;
            AddPropertyPanel.Visible = false;
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
    }

}
