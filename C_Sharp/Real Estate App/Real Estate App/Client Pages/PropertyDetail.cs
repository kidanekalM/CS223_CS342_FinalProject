using Real_Estate_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    public partial class PropertyDetail : Form
    {
        private int UserId;
        private int AgentId;
        private static DateTime date;
        private string id;
        private string usedFor;

        public PropertyDetail(string usedFor, string id, string address, bool availability, string price, string description, int userId)
        {
            InitializeComponent();

            this.id = id;
            lbl_Id.Text = id;
            lbl_Address.Text = address;
            bool status = availability;
            if (status == true)
                lbl_Availability.Text = "Available";
            else if (status == false)
                lbl_Availability.Text = "Not available";
            lbl_Price.Text = price;
            txt_Descrption.Text = description;
            UserId = userId;

            if (usedFor == "Viewing Owned Properties")
                btn_MakeAppointment.Visible = false;
            else
                btn_MakeAppointment.Visible = true;
        }

        private void PropertyDetail_Load(object sender, EventArgs e)
        {
            using (RealEstateEDM r = new RealEstateEDM("Client"))
            {
                var pics = r.Search_Property_Photo_By_ID(int.Parse(id)).ToList();
                Display(pics);
            }
        }

        public void Display(List<Search_Property_Photo_By_ID_Result> ph)
        {
            int i = 0;
            foreach (var b in ph)
            {
                using (MemoryStream ms = new MemoryStream(b.Photo))
                {
                    i++;
                    if (i == 1)
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pic_BigPicture.Image = Image.FromStream(ms);
                    }
                    else if (i == 2)
                        pictureBox2.Image = Image.FromStream(ms);
                    else if (i == 3)
                        pictureBox3.Image = Image.FromStream(ms);
                    else if (i == 4)
                        pictureBox4.Image = Image.FromStream(ms);
                    else if (i == 5)
                        pictureBox5.Image = Image.FromStream(ms);
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic_BigPicture.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pic_BigPicture.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pic_BigPicture.Image = pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pic_BigPicture.Image = pictureBox4.Image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pic_BigPicture.Image = pictureBox5.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MakeAppointment_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to make the appointment?", "Appointment", buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (RealEstateEDM rm = new RealEstateEDM("Client"))
                    {
                        var empDetail = rm.Search_Client_By_ID(UserId).FirstOrDefault();
                        if (empDetail != null)
                            AgentId = empDetail.EmpId;
                        else
                            MessageBox.Show("EmpDetail was null");

                        date = DateTime.Now;
                        date = date.AddDays(3);
                        rm.Add_Appointment(date, "Appointment for property with Id " + id.ToString(), UserId, AgentId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An appointment is made for " + date.ToString());
                    //MessageBox.Show("Failed to make an appointment! \n" + ex.Message);
                }
            }
        }
    }
}
