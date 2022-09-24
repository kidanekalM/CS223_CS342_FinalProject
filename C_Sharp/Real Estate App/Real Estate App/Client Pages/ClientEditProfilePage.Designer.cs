namespace Real_Estate_App
{
    partial class ClientEditProfilePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deletePic = new System.Windows.Forms.Button();
            this.btn_editPic = new System.Windows.Forms.Button();
            this.pic_ClientPic = new Real_Estate_App.User_Control.CircularPictureBox();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_PersonalInfo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ClientPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_deletePic);
            this.panel1.Controls.Add(this.btn_editPic);
            this.panel1.Controls.Add(this.pic_ClientPic);
            this.panel1.Controls.Add(this.txt_PhoneNo);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_LastName);
            this.panel1.Controls.Add(this.txt_FirstName);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.lbl_PersonalInfo);
            this.panel1.Location = new System.Drawing.Point(99, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 435);
            this.panel1.TabIndex = 2;
            // 
            // btn_deletePic
            // 
            this.btn_deletePic.BackgroundImage = global::Real_Estate_App.Properties.Resources.delete_icon;
            this.btn_deletePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deletePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePic.Location = new System.Drawing.Point(169, 278);
            this.btn_deletePic.Name = "btn_deletePic";
            this.btn_deletePic.Size = new System.Drawing.Size(30, 30);
            this.btn_deletePic.TabIndex = 34;
            this.btn_deletePic.UseVisualStyleBackColor = true;
            this.btn_deletePic.Click += new System.EventHandler(this.btn_deletePic_Click);
            // 
            // btn_editPic
            // 
            this.btn_editPic.BackgroundImage = global::Real_Estate_App.Properties.Resources.edit_icon;
            this.btn_editPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editPic.Location = new System.Drawing.Point(117, 278);
            this.btn_editPic.Name = "btn_editPic";
            this.btn_editPic.Size = new System.Drawing.Size(30, 30);
            this.btn_editPic.TabIndex = 33;
            this.btn_editPic.UseVisualStyleBackColor = true;
            this.btn_editPic.Click += new System.EventHandler(this.btn_editPic_Click);
            // 
            // pic_ClientPic
            // 
            this.pic_ClientPic.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
            this.pic_ClientPic.Location = new System.Drawing.Point(88, 127);
            this.pic_ClientPic.Name = "pic_ClientPic";
            this.pic_ClientPic.Size = new System.Drawing.Size(140, 140);
            this.pic_ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ClientPic.TabIndex = 32;
            this.pic_ClientPic.TabStop = false;
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txt_PhoneNo.Location = new System.Drawing.Point(288, 277);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.Size = new System.Drawing.Size(400, 29);
            this.txt_PhoneNo.TabIndex = 31;
            this.txt_PhoneNo.Text = "Phone Number";
            this.txt_PhoneNo.Enter += new System.EventHandler(this.txt_PhoneNo_Enter);
            this.txt_PhoneNo.Leave += new System.EventHandler(this.txt_PhoneNo_Leave);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.Location = new System.Drawing.Point(288, 227);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(400, 29);
            this.txt_Email.TabIndex = 30;
            this.txt_Email.Text = "E-mail";
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.ForeColor = System.Drawing.Color.Black;
            this.txt_LastName.Location = new System.Drawing.Point(288, 176);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(400, 29);
            this.txt_LastName.TabIndex = 28;
            this.txt_LastName.Text = "Last Name";
            this.txt_LastName.Enter += new System.EventHandler(this.txt_LastName_Enter);
            this.txt_LastName.Leave += new System.EventHandler(this.txt_LastName_Leave);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.ForeColor = System.Drawing.Color.Black;
            this.txt_FirstName.Location = new System.Drawing.Point(288, 127);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(400, 29);
            this.txt_FirstName.TabIndex = 27;
            this.txt_FirstName.Text = "First Name";
            this.txt_FirstName.Enter += new System.EventHandler(this.txt_FirstName_Enter);
            this.txt_FirstName.Leave += new System.EventHandler(this.txt_FirstName_Leave);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Back.Location = new System.Drawing.Point(402, 341);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(152, 48);
            this.btn_Back.TabIndex = 25;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(63)))), ((int)(((byte)(42)))));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Update.Location = new System.Drawing.Point(223, 341);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(152, 48);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_PersonalInfo
            // 
            this.lbl_PersonalInfo.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PersonalInfo.Location = new System.Drawing.Point(289, 39);
            this.lbl_PersonalInfo.Name = "lbl_PersonalInfo";
            this.lbl_PersonalInfo.Size = new System.Drawing.Size(201, 45);
            this.lbl_PersonalInfo.TabIndex = 0;
            this.lbl_PersonalInfo.Text = "Edit Profile";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Real_Estate_App.Properties.Resources.menna_ahmed_aBJ5EoAtRyw_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 782);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClientEditProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientEditProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientEditProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ClientPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_PersonalInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private Real_Estate_App.User_Control.CircularPictureBox pic_ClientPic;
        private System.Windows.Forms.Button btn_editPic;
        private System.Windows.Forms.Button btn_deletePic;
    }
}