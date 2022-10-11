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
    public partial class DetailPage : Form
    {
        public DetailPage()
        {
            InitializeComponent();
        }
        public string UserType { get; set; }
        public string UserID { get; set; }
        public string AppointmentID { get; set; }
        public DetailPage(Model.Search_Property_By_ID_Result r,List< Model.Search_Property_Photo_By_ID_Result> ph, string userType,string userID, string appointmentID)
        {
            UserType = userType;
            UserID = userID;
            AppointmentID = appointmentID;

            InitializeComponent();
            Editable(false);
            this.Show();
            Display(r,ph);
            
            if(userID == null)
            {
                btn_addToMyProperties.Enabled = false;
                btn_addToMyProperties.Hide();
            }
            if (UserType == null || UserType.Equals("Client"))
            {
                pic_Edit.Hide();
                pic_Edit_Click(this,null);
                btn_addToMyProperties.Show();
            }
            else if(UserType == "Admin" || UserType == "Agent")
            {
                pic_Edit.Show();
                pic_Edit.Enabled = true;
                btn_addToMyProperties.Hide();
            }
            txt_Id.ReadOnly = true;
        }
        public void Display(Model.Search_Property_By_ID_Result r, List<Model.Search_Property_Photo_By_ID_Result> ph)
        {
            txt_Id.Text = r.ID.ToString();
            txt_Address.Text = r.Address;
            txt_Price.Text = r.Price.ToString();
            chk_Status.Checked = r.Status;
            if (chk_Status.Checked)
            {
                chk_Status.Text = "Available";
            }
            else
            {
                chk_Status.Text = "Not Available";
            }
            txt_Type.Text = r.Type;
            txt_Description.Text = r.Description;
            txt_Area.Text = r.Area.ToString();
            int i = 0;
            foreach (var b in ph)
            {
                using (MemoryStream ms = new MemoryStream(b.Photo))
                {
                    i++;
                    if (i == 1)
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    else if (i == 2)
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                    else if (i == 3)
                    {
                        pictureBox3.Image = Image.FromStream(ms);
                    }
                    else if (i == 4)
                    {
                        pictureBox4.Image = Image.FromStream(ms);
                    }
                    else if (i == 5)
                    {
                        pictureBox5.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        public bool CompareImages(Image i1, Image i2)
        {
            byte[] b2 = ImageToByteArray(i2);
            byte[] b1 = ImageToByteArray(i1);
            if (b1.Length != b2.Length)
            {
                return false;
            }
            for(int i =0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i])
                {
                    return false;
                }
            }
            return true;
        }
        private void pictureBoxEvent(PictureBox p)
        {
            Image addImage = (Image)global::Real_Estate_App.Properties.Resources.Add2;
            if (CompareImages( p.Image,addImage))
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Image img = new Bitmap(op.FileName);
                    p.Image = img;
                    using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                    {
                        byte[] newImg = ImageToByteArray(img);

                        r.Add_Property_Photo(int.Parse(txt_Id.Text), newImg);
                    }
                }
                
            }
            else
            {
                    pic_BigPicture.Image = p.Image;
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxEvent((PictureBox)sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBoxEvent((PictureBox)sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBoxEvent((PictureBox)sender);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBoxEvent((PictureBox)sender);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBoxEvent((PictureBox)sender);
        }

        private void pic_Edit_Click(object sender, EventArgs e)
        {
            btn_addToMyProperties.Hide();

            if (txt_Address.ReadOnly)
            {
                btn_save.Hide();
                Editable(true);
                //txt_Address.ReadOnly = false;
            }
            else
            {
                btn_save.Show();
                Editable(false);
                //tableLayoutPanel1.Enabled = true;
            }
        }
        public void Editable(bool value)
        {
            txt_Address.ReadOnly = !value;
            txt_Area.ReadOnly = !value;
            txt_Description.ReadOnly = !value;
            txt_Price.ReadOnly = !value;
            txt_Type.ReadOnly = !value;
            chk_Status.Enabled = value;
            if (value)
            {
                ReplaceImage.Show();
                btn_save.Show();
                btn_delete.Show();
            }
            else
            {
                ReplaceImage.Hide();
                btn_save.Hide();
                btn_delete.Hide();
            }
        }
        private void ReplaceImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(op.FileName);
                if (pictureBox1.Image.Equals(pic_BigPicture.Image))
                {
                    pictureBox1.Image = img;
                }
                else if (pictureBox2.Image.Equals(pic_BigPicture.Image))
                {
                    pictureBox2.Image = img;
                }
                else if (pictureBox3.Image.Equals(pic_BigPicture.Image))
                {
                    pictureBox3.Image = img;
                }
                else if (pictureBox4.Image.Equals(pic_BigPicture.Image))
                {
                    pictureBox4.Image = img;
                }
                else if (pictureBox5.Image.Equals(pic_BigPicture.Image))
                {
                    pictureBox5.Image = img;
                }

                    using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                    {
                        byte[] oldImg = ImageToByteArray(pic_BigPicture.Image);
                        byte[] newImg = ImageToByteArray(new Bitmap(op.FileName));
                        r.Update_Property_Photo(oldImg, newImg);
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                r.Update_Property(int.Parse(txt_Id.Text), txt_Address.Text, double.Parse(txt_Price.Text), txt_Type.Text, double.Parse(txt_Area.Text), chk_Status.Checked, txt_Description.Text);
            }
            pic_Edit_Click(sender, e);
        }

        private void pic_Delete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons bs = MessageBoxButtons.YesNo;
            DialogResult d = MessageBox.Show("Are you sure you want to delete this property ? ", "Delete Property", bs);
            if (d == DialogResult.Yes)
            {
                using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                {
                    r.Delete_Property(int.Parse(txt_Id.Text));
                }
                MessageBox.Show("Deleted");
            }
        }

        private void btn_addToMyProperties_Click(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                if (AppointmentID == null || UserID == null || UserType == null)
                {
                    return;
                }
                r.Add_Choosen_Property(int.Parse(AppointmentID), int.Parse(txt_Id.Text));
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons bs = MessageBoxButtons.YesNo;
            DialogResult d = MessageBox.Show("Are you sure you want to delete this property ? ", "Delete Property", bs);
            if (d == DialogResult.Yes)
            {
                using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                {
                    r.Delete_Property(int.Parse(txt_Id.Text));
                }
                MessageBox.Show("Deleted");
            }

        }

    }
}
