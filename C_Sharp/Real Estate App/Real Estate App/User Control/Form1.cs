using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                displayPeople1.Employees = r.Get_All_Employees();
                displayPeople1.Clients = r.Get_All_Clients();
                displayPeople1.PersonClicked += personClicked;
            } 
        }
        public void personClicked(object o, EventArgs e)
        {
            DisplayPerson s = (DisplayPerson)o;
            MessageBox.Show($"{s.Name} Was Clicked");
        }
        
    }
}
