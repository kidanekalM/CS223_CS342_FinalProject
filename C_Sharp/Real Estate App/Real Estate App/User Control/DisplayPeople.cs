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
    public partial class DisplayPeople : UserControl
    {
        public DisplayPeople()
        {
            InitializeComponent();
        }
        private IQueryable<Model.Get_All_Clients_Result> _clients;

        public IQueryable<Model.Get_All_Clients_Result> Clients
        {
            get { return _clients; }
            set 
            { _clients = value; 
                if (value != null)
                {
                    tableLayoutPanel1.Controls.Clear();
                    foreach (var item in value)
                    {
                        DisplayPerson d = new DisplayPerson();
                        d.FullName = item.FirstName + " " + item.LastName;
                        d.ID = item.ID;

                        if(item.Photo != null)
                        {
                            using(System.IO.MemoryStream s = new System.IO.MemoryStream(item.Photo,0,item.Photo.Length))
                            {
                                s.Position = 0;
                                try
                                {
                                    d.PersonPhoto = Image.FromStream(s, true);
                                }
                                catch(Exception e)
                                {
                                    MessageBox.Show(e.ToString()+"\n"+item.Photo.ToString());
                                }
                            }
                        }
                        //d.PersonPhoto = Image.FromStream(new System.IO.MemoryStream(item.Photo));
                        d.PhoneNumber = item.PhoneNumber;
                        d.Size = displayPerson1.Size;
                        d.BackColor = displayPerson1.BackColor;
                        d.Click += PersonClicked;

                        tableLayoutPanel1.Controls.Add(d);
                    }
                }
            }
        }

        private IQueryable<Model.Get_All_Employees_Result> _employees;
        
        public IQueryable<Model.Get_All_Employees_Result> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                if (value != null)
                {
                    
                    tableLayoutPanel1.Controls.Clear();
                    foreach (var item in value)
                    {
                        DisplayPerson d = new DisplayPerson()
                        {
                            Name = item.FirstName + " " + item.LastName,
                            ID = item.ID,
                            PersonPhoto = new Bitmap(new System.IO.MemoryStream(item.Photo)),
                            PhoneNumber = item.PhoneNumber,
                        };
                        d.Click += PersonClicked;
                        tableLayoutPanel1.Controls.Add(d);
                    }
                    
                }
            }
        }
        public event EventHandler PersonClicked;
        
    }
}
