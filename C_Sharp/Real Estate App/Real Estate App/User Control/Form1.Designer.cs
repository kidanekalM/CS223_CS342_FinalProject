﻿namespace Real_Estate_App.User_Control
{
    partial class Test_User_Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayProperties1 = new Real_Estate_App.User_Control.DisplayProperties();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayProperties1
            // 
            this.displayProperties1.AppointmentID = null;
            this.displayProperties1.AutoScroll = true;
            this.displayProperties1.Location = new System.Drawing.Point(24, 29);
            this.displayProperties1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayProperties1.Name = "displayProperties1";
            this.displayProperties1.Properties = null;
            this.displayProperties1.PropertyClicked = null;
            this.displayProperties1.Size = new System.Drawing.Size(1053, 560);
            this.displayProperties1.TabIndex = 4;
            this.displayProperties1.UserID = "0";
            this.displayProperties1.UserType = "Admin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1038, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 76);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1377, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayProperties1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Test_User_Control";
            this.Text = "TestUserControls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DisplayProperties displayProperties1;
        private System.Windows.Forms.Button button1;
    }
}