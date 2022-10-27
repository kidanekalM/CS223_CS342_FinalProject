﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Real_Estate_App.User_Control
{
    public partial class Test_User_Control : Form
    {
        public Test_User_Control()
        {
            /*
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Client"))
            {
                var x = (List<Model.Login_Client_Result>)r.Login_Client(6, "adsf");
                
                foreach(var item in x)
                {
                    if (item != null)
                    MessageBox.Show(item.ID+"");
                }
            }
            */
            InitializeComponent();
            //circularButton1.BackColor = Color.Transparent;

            /*
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                foreach (var Client in r.Get_All_Clients())
                {
                   DisplayPerson d  = new DisplayPerson(Client);
                    d.Click += personClicked;
                    tableLayoutPanel1.Controls.Add(d);
                }
            }
            */
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Client"))
            {
                displayProperties1.Properties = r.Get_All_Properties();
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
            DisplayPerson s = (DisplayPerson)sender;
            MessageBox.Show($"{s.Name} Was Clicked");
        }

        private void displayPerson1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
            {
                //this.displayProperties1.Properties = r.Get_All_Properties();
            }/*
            for (int i = 1; i < 9; i++) {
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    MemoryStream ms = new MemoryStream();

                    // display image in picture box  
                    //Image i = new Bitmap(open.FileName);
                    //byte s = i as Stream;

                    byte[] img = File.ReadAllBytes(open.FileName);
                    using (Model.RealEstateEDM r = new Model.RealEstateEDM("Admin"))
                    {
                        r.Add_Property_Photo(i, img);
                    }
                    // image file path  
                    //textBox1.Text = open.FileName;
                } 
            }
            */
        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayProperties1.UserType = "Client";
            displayProperties1.UserID = "4";
            displayProperties1.AppointmentID = "1";
            using (Model.RealEstateEDM r = new Model.RealEstateEDM("Client"))
            {
                displayProperties1.Properties = r.Get_All_Properties();
            }
        }
    }
}
