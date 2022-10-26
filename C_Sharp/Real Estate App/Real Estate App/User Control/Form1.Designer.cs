namespace Real_Estate_App.User_Control
{
    partial class Test_User_Control
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.placeHolderTextBox1 = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.circularButton1 = new Real_Estate_App.User_Control.CircularButton();
            this.displayProperties1 = new Real_Estate_App.User_Control.DisplayProperties("admin","1","1");
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.circularButton1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(685, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(94, 116);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.BackColor = System.Drawing.Color.White;
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(136, 297);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolder = "THis is a trial ";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(618, 47);
            this.placeHolderTextBox1.TabIndex = 2;
            this.placeHolderTextBox1.Text = "THis is a trial ";
            // 
            // circularButton1
            // 
            this.circularButton1.Location = new System.Drawing.Point(3, 61);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(52, 52);
            this.circularButton1.TabIndex = 3;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = true;
            // 
            // displayProperties1
            // 
            this.displayProperties1.AppointmentID = null;
            this.displayProperties1.AutoScroll = true;
            this.displayProperties1.Location = new System.Drawing.Point(51, 38);
            this.displayProperties1.Name = "displayProperties1";
            this.displayProperties1.Properties = null;
            this.displayProperties1.PropertyClicked = null;
            this.displayProperties1.Size = new System.Drawing.Size(608, 214);
            this.displayProperties1.TabIndex = 3;
            this.displayProperties1.UserID = null;
            this.displayProperties1.UserType = null;
            // 
            // Test_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.displayProperties1);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Test_User_Control";
            this.Text = "TestUserControls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PlaceHolderTextBox placeHolderTextBox1;
        private CircularButton circularButton1;
        private DisplayProperties displayProperties1;
    }
}