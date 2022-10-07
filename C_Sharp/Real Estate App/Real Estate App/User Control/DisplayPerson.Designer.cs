namespace Real_Estate_App.User_Control
{
    partial class DisplayPerson
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
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new Real_Estate_App.User_Control.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneNumber.Location = new System.Drawing.Point(212, 112);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(211, 20);
            this.lbl_phoneNumber.TabIndex = 2;
            this.lbl_phoneNumber.Text = "Phone Number: Unknown";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(212, 65);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(117, 20);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID:  Unknown";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(212, 24);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 24);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Unknown";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
            this.circularPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(176, 176);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // DisplayPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.lbl_name);
            this.Name = "DisplayPerson";
            this.Size = new System.Drawing.Size(492, 176);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
    }
}
