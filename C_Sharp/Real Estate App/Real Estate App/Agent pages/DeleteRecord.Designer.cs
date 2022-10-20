namespace Real_Estate_App.Agent_pages
{
    partial class DeleteRecord
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
            this.btndelete = new System.Windows.Forms.Button();
            this.dgvrsalerecords = new System.Windows.Forms.DataGridView();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcomission = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpselldate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtagent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproperty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrsalerecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(570, 39);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(69, 23);
            this.btndelete.TabIndex = 37;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // dgvrsalerecords
            // 
            this.dgvrsalerecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrsalerecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyID,
            this.ClientID,
            this.AgentID,
            this.SellDate,
            this.Comission});
            this.dgvrsalerecords.Location = new System.Drawing.Point(84, 127);
            this.dgvrsalerecords.Name = "dgvrsalerecords";
            this.dgvrsalerecords.Size = new System.Drawing.Size(547, 176);
            this.dgvrsalerecords.TabIndex = 36;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "PropertyID";
            // 
            // txtcomission
            // 
            this.txtcomission.Location = new System.Drawing.Point(387, 25);
            this.txtcomission.Name = "txtcomission";
            this.txtcomission.Size = new System.Drawing.Size(100, 20);
            this.txtcomission.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Comission";
            // 
            // dtpselldate
            // 
            this.dtpselldate.Location = new System.Drawing.Point(107, 63);
            this.dtpselldate.Name = "dtpselldate";
            this.dtpselldate.Size = new System.Drawing.Size(200, 20);
            this.dtpselldate.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "SellDate";
            // 
            // txtagent
            // 
            this.txtagent.Location = new System.Drawing.Point(269, 25);
            this.txtagent.Name = "txtagent";
            this.txtagent.Size = new System.Drawing.Size(100, 20);
            this.txtagent.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "AgentID";
            // 
            // txtclient
            // 
            this.txtclient.Location = new System.Drawing.Point(150, 25);
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(100, 20);
            this.txtclient.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ClientID";
            // 
            // txtproperty
            // 
            this.txtproperty.Location = new System.Drawing.Point(30, 25);
            this.txtproperty.Name = "txtproperty";
            this.txtproperty.Size = new System.Drawing.Size(100, 20);
            this.txtproperty.TabIndex = 26;
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvrsalerecords);
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
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRecord";
            ((System.ComponentModel.ISupportInitialize)(this.dgvrsalerecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvrsalerecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcomission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpselldate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtagent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproperty;
    }
}