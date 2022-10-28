namespace Real_Estate_App
{
    partial class ClientPasswordPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPasswordPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_NewPassword2 = new System.Windows.Forms.TextBox();
            this.txt_NewPassword1 = new System.Windows.Forms.TextBox();
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Real_Estate_App.Properties.Resources.keenan_barber_pPfJN6wfYC0_unsplash1;
            this.pictureBox1.Location = new System.Drawing.Point(-59, -22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_NewPassword2);
            this.panel1.Controls.Add(this.txt_NewPassword1);
            this.panel1.Controls.Add(this.txt_OldPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(147, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 227);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(77)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(135, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_NewPassword2
            // 
            this.txt_NewPassword2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NewPassword2.Location = new System.Drawing.Point(59, 136);
            this.txt_NewPassword2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NewPassword2.Name = "txt_NewPassword2";
            this.txt_NewPassword2.Size = new System.Drawing.Size(274, 22);
            this.txt_NewPassword2.TabIndex = 3;
            this.txt_NewPassword2.Text = "Confirm Password";
            this.txt_NewPassword2.Enter += new System.EventHandler(this.txt_NewPassword2_Enter);
            this.txt_NewPassword2.Leave += new System.EventHandler(this.txt_NewPassword2_Leave);
            // 
            // txt_NewPassword1
            // 
            this.txt_NewPassword1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NewPassword1.Location = new System.Drawing.Point(59, 104);
            this.txt_NewPassword1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NewPassword1.Name = "txt_NewPassword1";
            this.txt_NewPassword1.Size = new System.Drawing.Size(274, 22);
            this.txt_NewPassword1.TabIndex = 2;
            this.txt_NewPassword1.Text = "New Password";
            this.txt_NewPassword1.Enter += new System.EventHandler(this.txt_NewPassword1_Enter);
            this.txt_NewPassword1.Leave += new System.EventHandler(this.txt_NewPassword1_Leave);
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_OldPassword.Location = new System.Drawing.Point(60, 73);
            this.txt_OldPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Size = new System.Drawing.Size(274, 22);
            this.txt_OldPassword.TabIndex = 1;
            this.txt_OldPassword.Text = "Old Password";
            this.txt_OldPassword.Enter += new System.EventHandler(this.txt_OldPassword_Enter);
            this.txt_OldPassword.Leave += new System.EventHandler(this.txt_OldPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ClientPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientPasswordPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientChangePasswordPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_NewPassword2;
        private System.Windows.Forms.TextBox txt_NewPassword1;
        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}