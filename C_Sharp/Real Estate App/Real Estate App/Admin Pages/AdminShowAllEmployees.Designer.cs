namespace Real_Estate_App.Admin_Pages
{
    partial class AdminShowAllEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_empType = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.pic_BigPicture = new Real_Estate_App.User_Control.CircularPictureBox();
            this.txt_Password = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.txt_PhoneNumber = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.txt_LastName = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.txt_firstName = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_SearchMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.displayPerson1 = new Real_Estate_App.User_Control.DisplayPerson();
            this.SearchButton = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cb_Department);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.txt_empType);
            this.panel2.Controls.Add(this.pic_BigPicture);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.txt_PhoneNumber);
            this.panel2.Controls.Add(this.txt_LastName);
            this.panel2.Controls.Add(this.txt_firstName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 610);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 442);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 24);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // cb_Department
            // 
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(14, 409);
            this.cb_Department.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(140, 24);
            this.cb_Department.TabIndex = 12;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(38, 508);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 28);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_empType
            // 
            this.txt_empType.BackColor = System.Drawing.Color.Gray;
            this.txt_empType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empType.ForeColor = System.Drawing.Color.Gray;
            this.txt_empType.Location = new System.Drawing.Point(14, 474);
            this.txt_empType.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empType.Name = "txt_empType";
            this.txt_empType.PlaceHolder = "Type";
            this.txt_empType.Size = new System.Drawing.Size(139, 26);
            this.txt_empType.TabIndex = 9;
            this.txt_empType.Text = "Type";
            // 
            // pic_BigPicture
            // 
            this.pic_BigPicture.Image = global::Real_Estate_App.Properties.Resources.Default_Profile;
            this.pic_BigPicture.Location = new System.Drawing.Point(38, 180);
            this.pic_BigPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pic_BigPicture.Name = "pic_BigPicture";
            this.pic_BigPicture.Size = new System.Drawing.Size(84, 84);
            this.pic_BigPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_BigPicture.TabIndex = 7;
            this.pic_BigPicture.TabStop = false;
            this.pic_BigPicture.Click += new System.EventHandler(this.pic_BigPicture_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Gray;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Gray;
            this.txt_Password.Location = new System.Drawing.Point(13, 374);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceHolder = "Password";
            this.txt_Password.Size = new System.Drawing.Size(139, 26);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.Text = "Password";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.BackColor = System.Drawing.Color.Gray;
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(14, 340);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PlaceHolder = "Phone Number";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(139, 26);
            this.txt_PhoneNumber.TabIndex = 4;
            this.txt_PhoneNumber.Text = "Phone Number";
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.Color.Gray;
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.ForeColor = System.Drawing.Color.Gray;
            this.txt_LastName.Location = new System.Drawing.Point(14, 305);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PlaceHolder = "Last Name";
            this.txt_LastName.Size = new System.Drawing.Size(139, 26);
            this.txt_LastName.TabIndex = 3;
            this.txt_LastName.Text = "Last Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.BackColor = System.Drawing.Color.Gray;
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.ForeColor = System.Drawing.Color.Gray;
            this.txt_firstName.Location = new System.Drawing.Point(14, 271);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PlaceHolder = "First Name";
            this.txt_firstName.Size = new System.Drawing.Size(140, 26);
            this.txt_firstName.TabIndex = 2;
            this.txt_firstName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Employee";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(217, 33);
            this.SearchtextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(152, 24);
            this.SearchtextBox.TabIndex = 15;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 510);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(1148, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(66, 32);
            this.btn_Exit.TabIndex = 17;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_SearchMessage
            // 
            this.lbl_SearchMessage.AutoSize = true;
            this.lbl_SearchMessage.BackColor = System.Drawing.Color.DimGray;
            this.lbl_SearchMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchMessage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_SearchMessage.Location = new System.Drawing.Point(211, 81);
            this.lbl_SearchMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SearchMessage.Name = "lbl_SearchMessage";
            this.lbl_SearchMessage.Size = new System.Drawing.Size(170, 36);
            this.lbl_SearchMessage.TabIndex = 18;
            this.lbl_SearchMessage.Text = "Employees";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.displayPerson1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(163, 121);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 452);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // displayPerson1
            // 
            this.displayPerson1.FullName = null;
            this.displayPerson1.ID = 0;
            this.displayPerson1.Location = new System.Drawing.Point(5, 5);
            this.displayPerson1.Margin = new System.Windows.Forms.Padding(5);
            this.displayPerson1.Name = "displayPerson1";
            this.displayPerson1.PersonPhoto = null;
            this.displayPerson1.PhoneNumber = null;
            this.displayPerson1.Size = new System.Drawing.Size(1014, 217);
            this.displayPerson1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Silver;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(377, 32);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(71, 25);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdminShowAllEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 573);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.lbl_SearchMessage);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminShowAllEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGetAllEmployees";
            this.Load += new System.EventHandler(this.AdminGetAllEmployees_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BigPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_SearchMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private User_Control.DisplayPerson displayPerson1;
        private System.Windows.Forms.Label SearchButton;
        private System.Windows.Forms.Label label1;
        private User_Control.PlaceHolderTextBox txt_empType;
        private User_Control.CircularPictureBox pic_BigPicture;
        private User_Control.PlaceHolderTextBox txt_Password;
        private User_Control.PlaceHolderTextBox txt_PhoneNumber;
        private User_Control.PlaceHolderTextBox txt_LastName;
        private User_Control.PlaceHolderTextBox txt_firstName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}