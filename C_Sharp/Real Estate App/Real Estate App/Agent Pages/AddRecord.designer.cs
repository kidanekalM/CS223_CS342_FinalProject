﻿namespace Real_Estate_App.Agent_pages
{
    partial class AddRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtproperty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtagent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpselldate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcomission = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PropertyID";
            // 
            // txtproperty
            // 
            this.txtproperty.Location = new System.Drawing.Point(181, 32);
            this.txtproperty.Name = "txtproperty";
            this.txtproperty.Size = new System.Drawing.Size(100, 20);
            this.txtproperty.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ClientID";
            // 
            // txtclient
            // 
            this.txtclient.Location = new System.Drawing.Point(181, 87);
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(100, 20);
            this.txtclient.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "AgentID";
            // 
            // txtagent
            // 
            this.txtagent.Location = new System.Drawing.Point(181, 143);
            this.txtagent.Name = "txtagent";
            this.txtagent.Size = new System.Drawing.Size(100, 20);
            this.txtagent.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SellDate";
            // 
            // dtpselldate
            // 
            this.dtpselldate.Location = new System.Drawing.Point(166, 203);
            this.dtpselldate.Name = "dtpselldate";
            this.dtpselldate.Size = new System.Drawing.Size(200, 20);
            this.dtpselldate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comission";
            // 
            // txtcomission
            // 
            this.txtcomission.Location = new System.Drawing.Point(181, 267);
            this.txtcomission.Name = "txtcomission";
            this.txtcomission.Size = new System.Drawing.Size(100, 20);
            this.txtcomission.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(307, 308);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(413, 308);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 352);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtcomission);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpselldate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtagent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproperty);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecord";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproperty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtagent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpselldate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcomission;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
    }
}