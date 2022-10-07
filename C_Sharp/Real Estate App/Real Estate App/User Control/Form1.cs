using System;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    public partial class Test_User_Control : Form
    {
        public Test_User_Control()
        {
            InitializeComponent();

            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                foreach (var Client in r.Get_All_Clients())
                {
                   DisplayPerson d  = new DisplayPerson(Client);
                    d.Click += personClicked;
                    tableLayoutPanel1.Controls.Add(d);
                }
            }
            
        }
        public void personClicked(object o, EventArgs e)
        {
            DisplayPerson s = (DisplayPerson)o;
            MessageBox.Show($"{s.Name} Was Clicked");
        }

        private void displayPerson1_Load(object sender, EventArgs e)
        {

        }

        private void displayPerson1_DoubleClick(object sender, EventArgs e)
        {
            DisplayPerson s = (DisplayPerson) sender;
            MessageBox.Show($"{s.Name} Was Clicked");
        }

        private void displayPerson1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
