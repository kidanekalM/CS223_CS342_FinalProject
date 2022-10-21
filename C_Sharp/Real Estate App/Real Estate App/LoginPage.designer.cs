namespace Real_Estate_App
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_AdminLabel = new System.Windows.Forms.Panel();
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.pnl_AgentLabel = new System.Windows.Forms.Panel();
            this.lbl_Agent = new System.Windows.Forms.Label();
            this.pnl_ClientLabel = new System.Windows.Forms.Panel();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.pnl_AdminLogin = new System.Windows.Forms.Panel();
            this.btn_UnhideAdminPassword = new System.Windows.Forms.Button();
            this.btn_HideAdminPassword = new System.Windows.Forms.Button();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.txt_AdminPassword = new System.Windows.Forms.TextBox();
            this.txt_AdminId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_AgentLogin = new System.Windows.Forms.Panel();
            this.btn_UnhideAgentPassword = new System.Windows.Forms.Button();
            this.btn_AgentLogin = new System.Windows.Forms.Button();
            this.btn_HideAgentPassword = new System.Windows.Forms.Button();
            this.txt_AgentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AgentPassword = new System.Windows.Forms.TextBox();
            this.pnl_ClientLogin = new System.Windows.Forms.Panel();
            this.btn_UnhideClientPassword = new System.Windows.Forms.Button();
            this.lk_lbl_CreateAccount = new System.Windows.Forms.LinkLabel();
            this.btn_ClientLogin = new System.Windows.Forms.Button();
            this.txt_ClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HideClientPassword = new System.Windows.Forms.Button();
            this.txt_ClientPassword = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_AdminLabel.SuspendLayout();
            this.pnl_AgentLabel.SuspendLayout();
            this.pnl_ClientLabel.SuspendLayout();
            this.pnl_AdminLogin.SuspendLayout();
            this.pnl_AgentLogin.SuspendLayout();
            this.pnl_ClientLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Real_Estate_App.Properties.Resources.etienne_beauregard_riverin_B0aCvAVSX8E_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(-19, -14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_AdminLabel
            // 
            this.pnl_AdminLabel.BackColor = System.Drawing.Color.DimGray;
            this.pnl_AdminLabel.Controls.Add(this.lbl_Admin);
            this.pnl_AdminLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_AdminLabel.Location = new System.Drawing.Point(458, 142);
            this.pnl_AdminLabel.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_AdminLabel.Name = "pnl_AdminLabel";
            this.pnl_AdminLabel.Size = new System.Drawing.Size(130, 34);
            this.pnl_AdminLabel.TabIndex = 5;
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.Location = new System.Drawing.Point(2, 0);
            this.lbl_Admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(128, 31);
            this.lbl_Admin.TabIndex = 8;
            this.lbl_Admin.Text = "Admin";
            this.lbl_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Admin.Click += new System.EventHandler(this.lbl_Admin_Click);
            // 
            // pnl_AgentLabel
            // 
            this.pnl_AgentLabel.BackColor = System.Drawing.Color.Gray;
            this.pnl_AgentLabel.Controls.Add(this.lbl_Agent);
            this.pnl_AgentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_AgentLabel.Location = new System.Drawing.Point(330, 142);
            this.pnl_AgentLabel.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_AgentLabel.Name = "pnl_AgentLabel";
            this.pnl_AgentLabel.Size = new System.Drawing.Size(130, 34);
            this.pnl_AgentLabel.TabIndex = 4;
            // 
            // lbl_Agent
            // 
            this.lbl_Agent.Location = new System.Drawing.Point(2, 0);
            this.lbl_Agent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Agent.Name = "lbl_Agent";
            this.lbl_Agent.Size = new System.Drawing.Size(130, 31);
            this.lbl_Agent.TabIndex = 7;
            this.lbl_Agent.Text = "Agent";
            this.lbl_Agent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Agent.Click += new System.EventHandler(this.lbl_Agent_Click);
            // 
            // pnl_ClientLabel
            // 
            this.pnl_ClientLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_ClientLabel.Controls.Add(this.lbl_Client);
            this.pnl_ClientLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_ClientLabel.Location = new System.Drawing.Point(201, 142);
            this.pnl_ClientLabel.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ClientLabel.Name = "pnl_ClientLabel";
            this.pnl_ClientLabel.Size = new System.Drawing.Size(131, 34);
            this.pnl_ClientLabel.TabIndex = 3;
            // 
            // lbl_Client
            // 
            this.lbl_Client.Location = new System.Drawing.Point(2, 0);
            this.lbl_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(126, 31);
            this.lbl_Client.TabIndex = 6;
            this.lbl_Client.Text = "Client";
            this.lbl_Client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Client.Click += new System.EventHandler(this.lbl_Client_Click);
            // 
            // pnl_AdminLogin
            // 
            this.pnl_AdminLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_AdminLogin.Controls.Add(this.btn_UnhideAdminPassword);
            this.pnl_AdminLogin.Controls.Add(this.btn_HideAdminPassword);
            this.pnl_AdminLogin.Controls.Add(this.btn_AdminLogin);
            this.pnl_AdminLogin.Controls.Add(this.txt_AdminPassword);
            this.pnl_AdminLogin.Controls.Add(this.txt_AdminId);
            this.pnl_AdminLogin.Controls.Add(this.label3);
            this.pnl_AdminLogin.Location = new System.Drawing.Point(201, 175);
            this.pnl_AdminLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_AdminLogin.Name = "pnl_AdminLogin";
            this.pnl_AdminLogin.Size = new System.Drawing.Size(387, 258);
            this.pnl_AdminLogin.TabIndex = 6;
            // 
            // btn_UnhideAdminPassword
            // 
            this.btn_UnhideAdminPassword.BackColor = System.Drawing.Color.White;
            this.btn_UnhideAdminPassword.BackgroundImage = global::Real_Estate_App.Properties.Resources.Unhide_com;
            this.btn_UnhideAdminPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UnhideAdminPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UnhideAdminPassword.Location = new System.Drawing.Point(313, 143);
            this.btn_UnhideAdminPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UnhideAdminPassword.Name = "btn_UnhideAdminPassword";
            this.btn_UnhideAdminPassword.Size = new System.Drawing.Size(23, 25);
            this.btn_UnhideAdminPassword.TabIndex = 22;
            this.btn_UnhideAdminPassword.UseVisualStyleBackColor = false;
            this.btn_UnhideAdminPassword.Click += new System.EventHandler(this.btn_UnhideAdminPassword_Click);
            // 
            // btn_HideAdminPassword
            // 
            this.btn_HideAdminPassword.AutoEllipsis = true;
            this.btn_HideAdminPassword.BackColor = System.Drawing.Color.White;
            this.btn_HideAdminPassword.BackgroundImage = global::Real_Estate_App.Properties.Resources.hide_com;
            this.btn_HideAdminPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HideAdminPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HideAdminPassword.Location = new System.Drawing.Point(313, 143);
            this.btn_HideAdminPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HideAdminPassword.Name = "btn_HideAdminPassword";
            this.btn_HideAdminPassword.Size = new System.Drawing.Size(23, 25);
            this.btn_HideAdminPassword.TabIndex = 21;
            this.btn_HideAdminPassword.UseVisualStyleBackColor = false;
            this.btn_HideAdminPassword.Click += new System.EventHandler(this.btn_HideAdminPassword_Click);
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(128)))));
            this.btn_AdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdminLogin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.ForeColor = System.Drawing.Color.White;
            this.btn_AdminLogin.Location = new System.Drawing.Point(150, 190);
            this.btn_AdminLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(96, 31);
            this.btn_AdminLogin.TabIndex = 3;
            this.btn_AdminLogin.Text = "Login";
            this.btn_AdminLogin.UseVisualStyleBackColor = false;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // txt_AdminPassword
            // 
            this.txt_AdminPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_AdminPassword.Location = new System.Drawing.Point(50, 143);
            this.txt_AdminPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AdminPassword.Name = "txt_AdminPassword";
            this.txt_AdminPassword.Size = new System.Drawing.Size(289, 24);
            this.txt_AdminPassword.TabIndex = 2;
            this.txt_AdminPassword.Text = "Password";
            this.txt_AdminPassword.Enter += new System.EventHandler(this.txt_AdminPassword_Enter);
            this.txt_AdminPassword.Leave += new System.EventHandler(this.txt_AdminPassword_Leave);
            // 
            // txt_AdminId
            // 
            this.txt_AdminId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_AdminId.Location = new System.Drawing.Point(50, 98);
            this.txt_AdminId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AdminId.Name = "txt_AdminId";
            this.txt_AdminId.Size = new System.Drawing.Size(289, 24);
            this.txt_AdminId.TabIndex = 1;
            this.txt_AdminId.Text = "Admin Id";
            this.txt_AdminId.Enter += new System.EventHandler(this.txt_AdminId_Enter);
            this.txt_AdminId.Leave += new System.EventHandler(this.txt_AdminId_Leave);
            this.txt_AdminId.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AdminId_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log In";
            // 
            // pnl_AgentLogin
            // 
            this.pnl_AgentLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_AgentLogin.Controls.Add(this.btn_UnhideAgentPassword);
            this.pnl_AgentLogin.Controls.Add(this.btn_AgentLogin);
            this.pnl_AgentLogin.Controls.Add(this.btn_HideAgentPassword);
            this.pnl_AgentLogin.Controls.Add(this.txt_AgentId);
            this.pnl_AgentLogin.Controls.Add(this.label2);
            this.pnl_AgentLogin.Controls.Add(this.txt_AgentPassword);
            this.pnl_AgentLogin.Location = new System.Drawing.Point(201, 175);
            this.pnl_AgentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_AgentLogin.Name = "pnl_AgentLogin";
            this.pnl_AgentLogin.Size = new System.Drawing.Size(387, 258);
            this.pnl_AgentLogin.TabIndex = 7;
            // 
            // btn_UnhideAgentPassword
            // 
            this.btn_UnhideAgentPassword.BackColor = System.Drawing.Color.White;
            this.btn_UnhideAgentPassword.BackgroundImage = global::Real_Estate_App.Properties.Resources.Unhide_com;
            this.btn_UnhideAgentPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UnhideAgentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UnhideAgentPassword.Location = new System.Drawing.Point(313, 143);
            this.btn_UnhideAgentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UnhideAgentPassword.Name = "btn_UnhideAgentPassword";
            this.btn_UnhideAgentPassword.Size = new System.Drawing.Size(23, 25);
            this.btn_UnhideAgentPassword.TabIndex = 22;
            this.btn_UnhideAgentPassword.UseVisualStyleBackColor = false;
            this.btn_UnhideAgentPassword.Click += new System.EventHandler(this.btn_UnhideAgentPassword_Click);
            // 
            // btn_AgentLogin
            // 
            this.btn_AgentLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(128)))));
            this.btn_AgentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgentLogin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgentLogin.ForeColor = System.Drawing.Color.White;
            this.btn_AgentLogin.Location = new System.Drawing.Point(150, 190);
            this.btn_AgentLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgentLogin.Name = "btn_AgentLogin";
            this.btn_AgentLogin.Size = new System.Drawing.Size(96, 31);
            this.btn_AgentLogin.TabIndex = 3;
            this.btn_AgentLogin.Text = "Login";
            this.btn_AgentLogin.UseVisualStyleBackColor = false;
            this.btn_AgentLogin.Click += new System.EventHandler(this.btn_AgentLogin_Click);
            // 
            // btn_HideAgentPassword
            // 
            this.btn_HideAgentPassword.AutoEllipsis = true;
            this.btn_HideAgentPassword.BackColor = System.Drawing.Color.White;
            this.btn_HideAgentPassword.BackgroundImage = global::Real_Estate_App.Properties.Resources.hide_com;
            this.btn_HideAgentPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HideAgentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HideAgentPassword.Location = new System.Drawing.Point(313, 143);
            this.btn_HideAgentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HideAgentPassword.Name = "btn_HideAgentPassword";
            this.btn_HideAgentPassword.Size = new System.Drawing.Size(23, 25);
            this.btn_HideAgentPassword.TabIndex = 21;
            this.btn_HideAgentPassword.UseVisualStyleBackColor = false;
            this.btn_HideAgentPassword.Click += new System.EventHandler(this.btn_HideAgentPassword_Click);
            // 
            // txt_AgentId
            // 
            this.txt_AgentId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_AgentId.Location = new System.Drawing.Point(50, 98);
            this.txt_AgentId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AgentId.Name = "txt_AgentId";
            this.txt_AgentId.Size = new System.Drawing.Size(289, 24);
            this.txt_AgentId.TabIndex = 1;
            this.txt_AgentId.Text = "Agent Id";
            this.txt_AgentId.Enter += new System.EventHandler(this.txt_AgentId_Enter);
            this.txt_AgentId.Leave += new System.EventHandler(this.txt_AgentId_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Log In";
            // 
            // txt_AgentPassword
            // 
            this.txt_AgentPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_AgentPassword.Location = new System.Drawing.Point(50, 143);
            this.txt_AgentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AgentPassword.Name = "txt_AgentPassword";
            this.txt_AgentPassword.Size = new System.Drawing.Size(289, 24);
            this.txt_AgentPassword.TabIndex = 2;
            this.txt_AgentPassword.Text = "Password";
            this.txt_AgentPassword.Enter += new System.EventHandler(this.txt_AgentPassword_Enter);
            this.txt_AgentPassword.Leave += new System.EventHandler(this.txt_AgentPassword_Leave);
            // 
            // pnl_ClientLogin
            // 
            this.pnl_ClientLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_ClientLogin.Controls.Add(this.btn_UnhideClientPassword);
            this.pnl_ClientLogin.Controls.Add(this.lk_lbl_CreateAccount);
            this.pnl_ClientLogin.Controls.Add(this.btn_ClientLogin);
            this.pnl_ClientLogin.Controls.Add(this.txt_ClientId);
            this.pnl_ClientLogin.Controls.Add(this.label1);
            this.pnl_ClientLogin.Controls.Add(this.btn_HideClientPassword);
            this.pnl_ClientLogin.Controls.Add(this.txt_ClientPassword);
            this.pnl_ClientLogin.Location = new System.Drawing.Point(202, 175);
            this.pnl_ClientLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ClientLogin.Name = "pnl_ClientLogin";
            this.pnl_ClientLogin.Size = new System.Drawing.Size(387, 258);
            this.pnl_ClientLogin.TabIndex = 8;
            // 
            // btn_UnhideClientPassword
            // 
            this.btn_UnhideClientPassword.BackColor = System.Drawing.Color.White;
            this.btn_UnhideClientPassword.BackgroundImage = global::Real_Estate_App.Properties.Resources.Unhide_com;
            this.btn_UnhideClientPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UnhideClientPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UnhideClientPassword.Location = new System.Drawing.Point(313, 135);
            this.btn_UnhideClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UnhideClientPassword.Name = "btn_UnhideClientPassword";
            this.btn_UnhideClientPassword.Size = new System.Drawing.Size(23, 25);
            this.btn_UnhideClientPassword.TabIndex = 22;
            this.btn_UnhideClientPassword.UseVisualStyleBackColor = false;
            this.btn_UnhideClientPassword.Click += new System.EventHandler(this.btn_UnhideClientPassword_Click);
            // 
            // lk_lbl_CreateAccount
            // 
            this.lk_lbl_CreateAccount.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lk_lbl_CreateAccount.AutoSize = true;
            this.lk_lbl_CreateAccount.Location = new System.Drawing.Point(142, 229);
            this.lk_lbl_CreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lk_lbl_CreateAccount.Name = "lk_lbl_CreateAccount";
            this.lk_lbl_CreateAccount.Size = new System.Drawing.Size(129, 17);
            this.lk_lbl_CreateAccount.TabIndex = 4;
            this.lk_lbl_CreateAccount.TabStop = true;
            this.lk_lbl_CreateAccount.Text = "Create an Account?";
            this.lk_lbl_CreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_lbl_CreateAccount_LinkClicked);
            // 
            // btn_ClientLogin
            // 
            this.btn_ClientLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(62)))), ((int)(((byte)(128)))));
            this.btn_ClientLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientLogin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientLogin.ForeColor = System.Drawing.Color.White;
            this.btn_ClientLogin.Location = new System.Drawing.Point(150, 182);
            this.btn_ClientLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ClientLogin.Name = "btn_ClientLogin";
            this.btn_ClientLogin.Size = new System.Drawing.Size(96, 31);
            this.btn_ClientLogin.TabIndex = 3;
            this.btn_ClientLogin.Text = "Login";
            this.btn_ClientLogin.UseVisualStyleBackColor = false;
            this.btn_ClientLogin.Click += new System.EventHandler(this.btn_ClientLogin_Click);
            // 
            // txt_ClientId
            // 
            this.txt_ClientId.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ClientId.Location = new System.Drawing.Point(50, 91);
            this.txt_ClientId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ClientId.Name = "txt_ClientId";
            this.txt_ClientId.Size = new System.Drawing.Size(289, 24);
            this.txt_ClientId.TabIndex = 1;
            this.txt_ClientId.Text = "Client Id";
            this.txt_ClientId.Enter += new System.EventHandler(this.txt_ClientId_Enter);
            this.txt_ClientId.Leave += new System.EventHandler(this.txt_ClientId_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // btn_HideClientPassword
            // 
            this.btn_HideClientPassword.AutoEllipsis = true;
            this.btn_HideClientPassword.BackColor = System.Drawing.Color.White;
            this.btn_HideClientPassword.BackgroundImage = global::Real_Estate_App.Properties.Resources.hide_com;
            this.btn_HideClientPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HideClientPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HideClientPassword.Location = new System.Drawing.Point(313, 135);
            this.btn_HideClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HideClientPassword.Name = "btn_HideClientPassword";
            this.btn_HideClientPassword.Size = new System.Drawing.Size(23, 25);
            this.btn_HideClientPassword.TabIndex = 21;
            this.btn_HideClientPassword.UseVisualStyleBackColor = false;
            this.btn_HideClientPassword.Click += new System.EventHandler(this.btn_HideClientPassword_Click);
            // 
            // txt_ClientPassword
            // 
            this.txt_ClientPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ClientPassword.Location = new System.Drawing.Point(50, 135);
            this.txt_ClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ClientPassword.Name = "txt_ClientPassword";
            this.txt_ClientPassword.Size = new System.Drawing.Size(289, 24);
            this.txt_ClientPassword.TabIndex = 2;
            this.txt_ClientPassword.Text = "Password";
            this.txt_ClientPassword.Enter += new System.EventHandler(this.txt_ClientPassword_Enter);
            this.txt_ClientPassword.Leave += new System.EventHandler(this.txt_ClientPassword_Leave);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.btn_Exit.BackgroundImage = global::Real_Estate_App.Properties.Resources.x_com;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(744, -1);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 32);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 523);
            this.Controls.Add(this.pnl_AdminLogin);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pnl_AdminLabel);
            this.Controls.Add(this.pnl_AgentLabel);
            this.Controls.Add(this.pnl_ClientLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_ClientLogin);
            this.Controls.Add(this.pnl_AgentLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_AdminLabel.ResumeLayout(false);
            this.pnl_AgentLabel.ResumeLayout(false);
            this.pnl_ClientLabel.ResumeLayout(false);
            this.pnl_AdminLogin.ResumeLayout(false);
            this.pnl_AdminLogin.PerformLayout();
            this.pnl_AgentLogin.ResumeLayout(false);
            this.pnl_AgentLogin.PerformLayout();
            this.pnl_ClientLogin.ResumeLayout(false);
            this.pnl_ClientLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_AdminLabel;
        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.Panel pnl_AgentLabel;
        private System.Windows.Forms.Label lbl_Agent;
        private System.Windows.Forms.Panel pnl_ClientLabel;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.Panel pnl_AdminLogin;
        private System.Windows.Forms.Button btn_UnhideAdminPassword;
        private System.Windows.Forms.Button btn_HideAdminPassword;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.TextBox txt_AdminPassword;
        private System.Windows.Forms.TextBox txt_AdminId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_AgentLogin;
        private System.Windows.Forms.Button btn_UnhideAgentPassword;
        private System.Windows.Forms.Button btn_AgentLogin;
        private System.Windows.Forms.Button btn_HideAgentPassword;
        private System.Windows.Forms.TextBox txt_AgentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AgentPassword;
        private System.Windows.Forms.Panel pnl_ClientLogin;
        private System.Windows.Forms.Button btn_UnhideClientPassword;
        private System.Windows.Forms.LinkLabel lk_lbl_CreateAccount;
        private System.Windows.Forms.Button btn_ClientLogin;
        private System.Windows.Forms.TextBox txt_ClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HideClientPassword;
        private System.Windows.Forms.TextBox txt_ClientPassword;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}