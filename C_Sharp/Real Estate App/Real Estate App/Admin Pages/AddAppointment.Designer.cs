namespace Real_Estate_App.Admin_Pages
{
    partial class AddAppointment
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Comment = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.txt_EmployeeID = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.txt_propertyID = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.txt_ClientID = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(579, 11);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(57, 26);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Comment);
            this.panel1.Controls.Add(this.txt_EmployeeID);
            this.panel1.Controls.Add(this.txt_propertyID);
            this.panel1.Controls.Add(this.txt_ClientID);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(135, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 323);
            this.panel1.TabIndex = 21;
            // 
            // txt_Comment
            // 
            this.txt_Comment.BackColor = System.Drawing.Color.White;
            this.txt_Comment.ForeColor = System.Drawing.Color.Gray;
            this.txt_Comment.Location = new System.Drawing.Point(88, 245);
            this.txt_Comment.Multiline = true;
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.PlaceHolder = "Comment";
            this.txt_Comment.Size = new System.Drawing.Size(177, 36);
            this.txt_Comment.TabIndex = 15;
            this.txt_Comment.Text = "Comment";
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.BackColor = System.Drawing.Color.White;
            this.txt_EmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.txt_EmployeeID.Location = new System.Drawing.Point(114, 193);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.PlaceHolder = "Employee ID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(125, 20);
            this.txt_EmployeeID.TabIndex = 14;
            this.txt_EmployeeID.Text = "Employee ID";
            // 
            // txt_propertyID
            // 
            this.txt_propertyID.BackColor = System.Drawing.Color.White;
            this.txt_propertyID.ForeColor = System.Drawing.Color.Gray;
            this.txt_propertyID.Location = new System.Drawing.Point(114, 137);
            this.txt_propertyID.Name = "txt_propertyID";
            this.txt_propertyID.PlaceHolder = "Property ID\'s";
            this.txt_propertyID.Size = new System.Drawing.Size(125, 20);
            this.txt_propertyID.TabIndex = 13;
            this.txt_propertyID.Text = "Property ID\'s";
            // 
            // txt_ClientID
            // 
            this.txt_ClientID.BackColor = System.Drawing.Color.White;
            this.txt_ClientID.ForeColor = System.Drawing.Color.Gray;
            this.txt_ClientID.Location = new System.Drawing.Point(114, 82);
            this.txt_ClientID.Name = "txt_ClientID";
            this.txt_ClientID.PlaceHolder = "Client ID";
            this.txt_ClientID.Size = new System.Drawing.Size(125, 20);
            this.txt_ClientID.TabIndex = 12;
            this.txt_ClientID.Text = "Client ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(207, 416);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(324, 416);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(60, 23);
            this.btn_Clear.TabIndex = 23;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add Appointment";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Real_Estate_App.Properties.Resources.istockphoto_1192524192_170667a;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private User_Control.PlaceHolderTextBox txt_Comment;
        private User_Control.PlaceHolderTextBox txt_EmployeeID;
        private User_Control.PlaceHolderTextBox txt_propertyID;
        private User_Control.PlaceHolderTextBox txt_ClientID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
    }
}