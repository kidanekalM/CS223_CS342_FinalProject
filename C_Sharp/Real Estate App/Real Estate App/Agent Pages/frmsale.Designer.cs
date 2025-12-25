namespace Real_Estate_App.Agent_pages
{
    partial class frmsale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsale));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textproperty = new System.Windows.Forms.TextBox();
            this.textagent = new System.Windows.Forms.TextBox();
            this.textclient = new System.Windows.Forms.TextBox();
            this.dtpsell = new System.Windows.Forms.DateTimePicker();
            this.textcomission = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgvsalerecords = new System.Windows.Forms.DataGridView();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalerecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "property id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agent id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "client id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "sell date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "comission";
            // 
            // textproperty
            // 
            this.textproperty.Location = new System.Drawing.Point(165, 95);
            this.textproperty.Name = "textproperty";
            this.textproperty.Size = new System.Drawing.Size(100, 20);
            this.textproperty.TabIndex = 6;
            // 
            // textagent
            // 
            this.textagent.Location = new System.Drawing.Point(165, 151);
            this.textagent.Name = "textagent";
            this.textagent.Size = new System.Drawing.Size(100, 20);
            this.textagent.TabIndex = 7;
            // 
            // textclient
            // 
            this.textclient.Location = new System.Drawing.Point(165, 211);
            this.textclient.Name = "textclient";
            this.textclient.Size = new System.Drawing.Size(100, 20);
            this.textclient.TabIndex = 8;
            // 
            // dtpsell
            // 
            this.dtpsell.Location = new System.Drawing.Point(147, 272);
            this.dtpsell.Name = "dtpsell";
            this.dtpsell.Size = new System.Drawing.Size(200, 20);
            this.dtpsell.TabIndex = 10;
            // 
            // textcomission
            // 
            this.textcomission.Location = new System.Drawing.Point(165, 339);
            this.textcomission.Name = "textcomission";
            this.textcomission.Size = new System.Drawing.Size(100, 20);
            this.textcomission.TabIndex = 11;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(84, 405);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(207, 405);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(339, 405);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // dgvsalerecords
            // 
            this.dgvsalerecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalerecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyID,
            this.ClientID,
            this.AgentID,
            this.SellDate,
            this.Comission});
            this.dgvsalerecords.Location = new System.Drawing.Point(377, 106);
            this.dgvsalerecords.Name = "dgvsalerecords";
            this.dgvsalerecords.ReadOnly = true;
            this.dgvsalerecords.Size = new System.Drawing.Size(531, 282);
            this.dgvsalerecords.TabIndex = 16;
            this.dgvsalerecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalerecords_CellDoubleClick);
            // 
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "property id";
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.ReadOnly = true;
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "client id";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // AgentID
            // 
            this.AgentID.DataPropertyName = "AgentID";
            this.AgentID.HeaderText = "agent id";
            this.AgentID.Name = "AgentID";
            this.AgentID.ReadOnly = true;
            // 
            // SellDate
            // 
            this.SellDate.DataPropertyName = "SellDate";
            this.SellDate.HeaderText = "sell date";
            this.SellDate.Name = "SellDate";
            this.SellDate.ReadOnly = true;
            // 
            // Comission
            // 
            this.Comission.DataPropertyName = "Comission";
            this.Comission.HeaderText = "comission";
            this.Comission.Name = "Comission";
            this.Comission.ReadOnly = true;
            // 
            // frmsale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.dgvsalerecords);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.textcomission);
            this.Controls.Add(this.dtpsell);
            this.Controls.Add(this.textclient);
            this.Controls.Add(this.textagent);
            this.Controls.Add(this.textproperty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmsale";
            this.Size = new System.Drawing.Size(936, 521);
            this.Load += new System.EventHandler(this.frmsale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalerecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textproperty;
        private System.Windows.Forms.TextBox textagent;
        private System.Windows.Forms.TextBox textclient;
        private System.Windows.Forms.DateTimePicker dtpsell;
        private System.Windows.Forms.TextBox textcomission;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvsalerecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comission;
    }
}
