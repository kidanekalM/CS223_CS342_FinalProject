namespace Real_Estate_App.Agent_pages
{
    partial class EditRecord
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
            this.txtcomission = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpselldate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtagent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproperty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgvsalerecord = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalerecord)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcomission
            // 
            this.txtcomission.Location = new System.Drawing.Point(526, 23);
            this.txtcomission.Name = "txtcomission";
            this.txtcomission.Size = new System.Drawing.Size(100, 20);
            this.txtcomission.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Comission";
            // 
            // dtpselldate
            // 
            this.dtpselldate.Location = new System.Drawing.Point(77, 61);
            this.dtpselldate.Name = "dtpselldate";
            this.dtpselldate.Size = new System.Drawing.Size(200, 20);
            this.dtpselldate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "SellDate";
            // 
            // txtagent
            // 
            this.txtagent.Location = new System.Drawing.Point(396, 23);
            this.txtagent.Name = "txtagent";
            this.txtagent.Size = new System.Drawing.Size(100, 20);
            this.txtagent.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "AgentID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtclient
            // 
            this.txtclient.Location = new System.Drawing.Point(263, 23);
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(100, 20);
            this.txtclient.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ClientID";
            // 
            // txtproperty
            // 
            this.txtproperty.Location = new System.Drawing.Point(142, 23);
            this.txtproperty.Name = "txtproperty";
            this.txtproperty.Size = new System.Drawing.Size(100, 20);
            this.txtproperty.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "PropertyID";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(396, 268);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(69, 23);
            this.btnedit.TabIndex = 25;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(26, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(86, 20);
            this.txtid.TabIndex = 27;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(486, 268);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 29;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dgvsalerecord
            // 
            this.dgvsalerecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalerecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PropertyID,
            this.ClientID,
            this.AgentID,
            this.SellDate,
            this.Comission});
            this.dgvsalerecord.Location = new System.Drawing.Point(28, 91);
            this.dgvsalerecord.Name = "dgvsalerecord";
            this.dgvsalerecord.Size = new System.Drawing.Size(612, 171);
            this.dgvsalerecord.TabIndex = 30;
            this.dgvsalerecord.DoubleClick += new System.EventHandler(this.dgvsalerecord_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            // 
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "Property ID";
            this.PropertyID.Name = "PropertyID";
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "Client ID";
            this.ClientID.Name = "ClientID";
            // 
            // AgentID
            // 
            this.AgentID.DataPropertyName = "AgentID";
            this.AgentID.HeaderText = "Agent ID";
            this.AgentID.Name = "AgentID";
            // 
            // SellDate
            // 
            this.SellDate.DataPropertyName = "SellDate";
            this.SellDate.HeaderText = "Sell Date";
            this.SellDate.Name = "SellDate";
            // 
            // Comission
            // 
            this.Comission.DataPropertyName = "Comission";
            this.Comission.HeaderText = "comission";
            this.Comission.Name = "Comission";
            // 
            // EditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.dgvsalerecord);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcomission);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpselldate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtagent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproperty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRecord";
            this.Load += new System.EventHandler(this.EditRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalerecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcomission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpselldate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtagent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvsalerecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comission;
    }
}