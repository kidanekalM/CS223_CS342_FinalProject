namespace Real_Estate_App.User_Control
{
    partial class DisplayProperty
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
            this.lbl_availability = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.PropertyPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_availability
            // 
            this.lbl_availability.AutoSize = true;
            this.lbl_availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_availability.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_availability.Location = new System.Drawing.Point(266, 76);
            this.lbl_availability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_availability.Name = "lbl_availability";
            this.lbl_availability.Size = new System.Drawing.Size(120, 29);
            this.lbl_availability.TabIndex = 6;
            this.lbl_availability.Text = "Available";
            // 
            // txt_Description
            // 
            this.txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Description.Enabled = false;
            this.txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(271, 169);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(387, 59);
            this.txt_Description.TabIndex = 5;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Description.Location = new System.Drawing.Point(266, 136);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Description.Size = new System.Drawing.Size(146, 29);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_price.Location = new System.Drawing.Point(265, 106);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(88, 29);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "Price :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_address.Location = new System.Drawing.Point(266, 47);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(123, 29);
            this.lbl_address.TabIndex = 0;
            this.lbl_address.Text = "Address :";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Id.Location = new System.Drawing.Point(266, 17);
            this.lbl_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(52, 29);
            this.lbl_Id.TabIndex = 7;
            this.lbl_Id.Text = "ID :";
            // 
            // PropertyPhoto
            // 
            this.PropertyPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.PropertyPhoto.Image = global::Real_Estate_App.Properties.Resources.RealEstate_App_Icon;
            this.PropertyPhoto.Location = new System.Drawing.Point(0, 0);
            this.PropertyPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PropertyPhoto.Name = "PropertyPhoto";
            this.PropertyPhoto.Size = new System.Drawing.Size(239, 233);
            this.PropertyPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PropertyPhoto.TabIndex = 0;
            this.PropertyPhoto.TabStop = false;
            // 
            // DisplayProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_availability);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.PropertyPhoto);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_price);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DisplayProperty";
            this.Size = new System.Drawing.Size(693, 233);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PropertyPhoto;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_availability;
        private System.Windows.Forms.Label lbl_Id;
    }
}
