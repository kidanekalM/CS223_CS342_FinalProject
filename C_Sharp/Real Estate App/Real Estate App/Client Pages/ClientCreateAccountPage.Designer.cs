namespace Real_Estate_App
{
    partial class ClientCreateAccountPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deletePic = new System.Windows.Forms.Button();
            this.btn_editPic = new System.Windows.Forms.Button();
            this.pic_ClientProfilePic = new Assignment_4_GUI.CircularPictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Unhide = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ClientProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Real_Estate_App.Properties.Resources.luke_chesser_pJadQetzTkI_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1368, 1099);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_deletePic);
            this.panel1.Controls.Add(this.btn_editPic);
            this.panel1.Controls.Add(this.pic_ClientProfilePic);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_CreateAccount);
            this.panel1.Controls.Add(this.txt_PhoneNo);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_LastName);
            this.panel1.Controls.Add(this.txt_FirstName);
            this.panel1.Controls.Add(this.lbl_Login);
            this.panel1.Controls.Add(this.btn_Unhide);
            this.panel1.Controls.Add(this.btn_Hide);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Location = new System.Drawing.Point(154, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 453);
            this.panel1.TabIndex = 1;
            // 
            // btn_deletePic
            // 
            this.btn_deletePic.BackgroundImage = global::Real_Estate_App.Properties.Resources.delete_icon;
            this.btn_deletePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deletePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePic.Location = new System.Drawing.Point(161, 299);
            this.btn_deletePic.Name = "btn_deletePic";
            this.btn_deletePic.Size = new System.Drawing.Size(42, 37);
            this.btn_deletePic.TabIndex = 23;
            this.btn_deletePic.UseVisualStyleBackColor = true;
            this.btn_deletePic.Click += new System.EventHandler(this.btn_deletePic_Click);
            // 
            // btn_editPic
            // 
            this.btn_editPic.BackgroundImage = global::Real_Estate_App.Properties.Resources.edit_icon;
            this.btn_editPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editPic.Location = new System.Drawing.Point(96, 298);
            this.btn_editPic.Name = "btn_editPic";
            this.btn_editPic.Size = new System.Drawing.Size(42, 37);
            this.btn_editPic.TabIndex = 22;
            this.btn_editPic.UseVisualStyleBackColor = true;
            this.btn_editPic.Click += new System.EventHandler(this.btn_editPic_Click);
            // 
            // pic_ClientProfilePic
            // 
            this.pic_ClientProfilePic.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
            this.pic_ClientProfilePic.Location = new System.Drawing.Point(78, 115);
            this.pic_ClientProfilePic.Name = "pic_ClientProfilePic";
            this.pic_ClientProfilePic.Size = new System.Drawing.Size(155, 155);
            this.pic_ClientProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ClientProfilePic.TabIndex = 21;
            this.pic_ClientProfilePic.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Back.Location = new System.Drawing.Point(360, 378);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(152, 48);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(122)))), ((int)(((byte)(163)))));
            this.btn_CreateAccount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CreateAccount.Location = new System.Drawing.Point(181, 378);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(152, 48);
            this.btn_CreateAccount.TabIndex = 14;
            this.btn_CreateAccount.Text = "Create Account";
            this.btn_CreateAccount.UseVisualStyleBackColor = false;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_PhoneNo.Location = new System.Drawing.Point(290, 319);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.Size = new System.Drawing.Size(367, 29);
            this.txt_PhoneNo.TabIndex = 12;
            this.txt_PhoneNo.Text = "Phone Number";
            this.txt_PhoneNo.Enter += new System.EventHandler(this.txt_PhoneNo_Enter);
            this.txt_PhoneNo.Leave += new System.EventHandler(this.txt_PhoneNo_Leave);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Email.Location = new System.Drawing.Point(290, 267);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(367, 29);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.Text = "E-mail";
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_LastName.Location = new System.Drawing.Point(290, 163);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(367, 29);
            this.txt_LastName.TabIndex = 7;
            this.txt_LastName.Text = "Last Name";
            this.txt_LastName.Enter += new System.EventHandler(this.txt_LastName_Enter);
            this.txt_LastName.Leave += new System.EventHandler(this.txt_LastName_Leave);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_FirstName.Location = new System.Drawing.Point(290, 115);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(367, 29);
            this.txt_FirstName.TabIndex = 6;
            this.txt_FirstName.Text = "First Name";
            this.txt_FirstName.Enter += new System.EventHandler(this.txt_Firstname_Enter);
            this.txt_FirstName.Leave += new System.EventHandler(this.txt_FirstName_Leave);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(216, 38);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(259, 45);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Create Account";
            // 
            // btn_Unhide
            // 
            this.btn_Unhide.BackColor = System.Drawing.Color.White;
            this.btn_Unhide.BackgroundImage = global::Real_Estate_App.Properties.Resources.Unhide_com;
            this.btn_Unhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Unhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Unhide.Location = new System.Drawing.Point(623, 213);
            this.btn_Unhide.Name = "btn_Unhide";
            this.btn_Unhide.Size = new System.Drawing.Size(34, 34);
            this.btn_Unhide.TabIndex = 20;
            this.btn_Unhide.UseVisualStyleBackColor = false;
            this.btn_Unhide.Click += new System.EventHandler(this.btn_Unhide_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.AutoEllipsis = true;
            this.btn_Hide.BackColor = System.Drawing.Color.White;
            this.btn_Hide.BackgroundImage = global::Real_Estate_App.Properties.Resources.hide_com;
            this.btn_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hide.Location = new System.Drawing.Point(623, 213);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(34, 34);
            this.btn_Hide.TabIndex = 19;
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Password.Location = new System.Drawing.Point(290, 214);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(367, 29);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.Text = "Password";
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ClientCreateAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientCreateAccountPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientCreatePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ClientProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Unhide;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_deletePic;
        private System.Windows.Forms.Button btn_editPic;
        private Assignment_4_GUI.CircularPictureBox pic_ClientProfilePic;
    }
}