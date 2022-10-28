using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.Agent_pages
{
    public partial class My_Clients : Form
    {
        public int AgentID { get; set; }
        public List<Model.Get_All_Clients_By_Agent_Result1> Clients { get; set; }
        public My_Clients(int agentID)
        {
            InitializeComponent();
            AgentID = agentID;
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Agent"))
            {
                Clients = r.Get_All_Clients_By_Agent(AgentID).ToList();
            }
            tableLayoutPanel1.Controls.Clear();
            if (Clients.Count < 1)
            {
                label1.Text = "There are no clients";
            }
            else
            {
                label1.Text = "My Clients";
            }
            foreach (var cl in Clients)
            {
                User_Control.DisplayPerson d = new User_Control.DisplayPerson();
                using (MemoryStream mr = new MemoryStream(cl.Photo))
                {
                    d.PersonPhoto = Image.FromStream(mr);
                }
                d.FullName = cl.FirstName + " " + cl.LastName;
                d.PhoneNumber = cl.PhoneNumber;
                tableLayoutPanel1.Controls.Add(d);
            }

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            var searched = Clients.Where(client => client.FirstName.Contains(txt_Search.Text) || client.LastName.Contains(txt_Search.Text) || client.PhoneNumber.Contains(txt_Search.Text));
            tableLayoutPanel1.Controls.Clear();
            if (searched.Count() < 1)
            {
                label1.Text = "There are no clients";
            }
            else
            {
                label1.Text = "My Clients";
            }
            foreach (var cl in searched)
            {
                User_Control.DisplayPerson d = new User_Control.DisplayPerson();
                using (MemoryStream mr = new MemoryStream(cl.Photo))
                {
                    d.PersonPhoto = Image.FromStream(mr);
                }
                d.FullName = cl.FirstName + " " + cl.LastName;
                d.PhoneNumber = cl.PhoneNumber;
                tableLayoutPanel1.Controls.Add(d);
            }
        }

        private void My_Clients_Load(object sender, EventArgs e)
        {

        }
    }
}
