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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.displayProperties1 = new Real_Estate_App.User_Control.DisplayProperties("Agent","1","1");
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(762, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(17, 10);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // displayProperties1
            // 
            this.displayProperties1.AutoScroll = true;
            this.displayProperties1.Location = new System.Drawing.Point(12, 12);
            this.displayProperties1.Name = "displayProperties1";
            this.displayProperties1.Properties = null;
            this.displayProperties1.PropertyClicked = null;
            this.displayProperties1.Size = new System.Drawing.Size(791, 359);
            this.displayProperties1.TabIndex = 2;
            // 
            // Test_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.displayProperties1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Test_User_Control";
            this.Text = "TestUserControls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DisplayProperties displayProperties1;
    }
}