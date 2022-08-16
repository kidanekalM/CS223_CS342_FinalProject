namespace Real_Estate_App.Client_Pages
{
    partial class ClientPropertyPage
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
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rb_Descending = new System.Windows.Forms.RadioButton();
            this.rb_Asscending = new System.Windows.Forms.RadioButton();
            this.cmbx_SortBy = new System.Windows.Forms.ComboBox();
            this.lbl_SortBy = new System.Windows.Forms.Label();
            this.lbl_My = new System.Windows.Forms.Label();
            this.lbl_OwnedProperties = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Property = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel.Controls.Add(this.groupBox);
            this.panel.Controls.Add(this.cmbx_SortBy);
            this.panel.Controls.Add(this.lbl_SortBy);
            this.panel.Controls.Add(this.lbl_My);
            this.panel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.ForeColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(234, 594);
            this.panel.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rb_Descending);
            this.groupBox.Controls.Add(this.rb_Asscending);
            this.groupBox.Location = new System.Drawing.Point(18, 466);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 100);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // rb_Descending
            // 
            this.rb_Descending.AutoSize = true;
            this.rb_Descending.Location = new System.Drawing.Point(7, 53);
            this.rb_Descending.Name = "rb_Descending";
            this.rb_Descending.Size = new System.Drawing.Size(140, 25);
            this.rb_Descending.TabIndex = 1;
            this.rb_Descending.TabStop = true;
            this.rb_Descending.Text = "Descending";
            this.rb_Descending.UseVisualStyleBackColor = true;
            // 
            // rb_Asscending
            // 
            this.rb_Asscending.AutoSize = true;
            this.rb_Asscending.Location = new System.Drawing.Point(7, 21);
            this.rb_Asscending.Name = "rb_Asscending";
            this.rb_Asscending.Size = new System.Drawing.Size(137, 25);
            this.rb_Asscending.TabIndex = 0;
            this.rb_Asscending.TabStop = true;
            this.rb_Asscending.Text = "Asscending";
            this.rb_Asscending.UseVisualStyleBackColor = true;
            // 
            // cmbx_SortBy
            // 
            this.cmbx_SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_SortBy.FormattingEnabled = true;
            this.cmbx_SortBy.Items.AddRange(new object[] {
            "Date",
            "Type",
            "Price"});
            this.cmbx_SortBy.Location = new System.Drawing.Point(18, 418);
            this.cmbx_SortBy.Name = "cmbx_SortBy";
            this.cmbx_SortBy.Size = new System.Drawing.Size(198, 29);
            this.cmbx_SortBy.TabIndex = 2;
            // 
            // lbl_SortBy
            // 
            this.lbl_SortBy.AutoSize = true;
            this.lbl_SortBy.Location = new System.Drawing.Point(14, 394);
            this.lbl_SortBy.Name = "lbl_SortBy";
            this.lbl_SortBy.Size = new System.Drawing.Size(69, 21);
            this.lbl_SortBy.TabIndex = 1;
            this.lbl_SortBy.Text = "Sort By";
            // 
            // lbl_My
            // 
            this.lbl_My.AutoSize = true;
            this.lbl_My.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_My.Location = new System.Drawing.Point(133, 36);
            this.lbl_My.Name = "lbl_My";
            this.lbl_My.Size = new System.Drawing.Size(110, 66);
            this.lbl_My.TabIndex = 0;
            this.lbl_My.Text = "My";
            // 
            // lbl_OwnedProperties
            // 
            this.lbl_OwnedProperties.AutoSize = true;
            this.lbl_OwnedProperties.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OwnedProperties.Location = new System.Drawing.Point(257, 123);
            this.lbl_OwnedProperties.Name = "lbl_OwnedProperties";
            this.lbl_OwnedProperties.Size = new System.Drawing.Size(220, 23);
            this.lbl_OwnedProperties.TabIndex = 1;
            this.lbl_OwnedProperties.Text = "Owned Properties = 0";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(261, 149);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(715, 419);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // lbl_Property
            // 
            this.lbl_Property.AutoSize = true;
            this.lbl_Property.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Property.ForeColor = System.Drawing.Color.Black;
            this.lbl_Property.Location = new System.Drawing.Point(235, 36);
            this.lbl_Property.Name = "lbl_Property";
            this.lbl_Property.Size = new System.Drawing.Size(253, 66);
            this.lbl_Property.TabIndex = 3;
            this.lbl_Property.Text = "Property";
            // 
            // ClientPropertyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 589);
            this.Controls.Add(this.lbl_Property);
            this.Controls.Add(this.lbl_OwnedProperties);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientPropertyPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientPropertyPage";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_My;
        private System.Windows.Forms.Label lbl_OwnedProperties;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lbl_Property;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rb_Descending;
        private System.Windows.Forms.RadioButton rb_Asscending;
        private System.Windows.Forms.ComboBox cmbx_SortBy;
        private System.Windows.Forms.Label lbl_SortBy;
    }
}