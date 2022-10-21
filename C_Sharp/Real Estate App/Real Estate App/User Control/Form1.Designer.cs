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
            this.AppointmentPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.AppointmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.placeHolderTextBox1.Location = new System.Drawing.Point(129, 331);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolder = "THis is a trial ";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(618, 47);
            this.placeHolderTextBox1.TabIndex = 2;
            this.placeHolderTextBox1.Text = "THis is a trial ";
            // 
            // circularButton1
            // 
            this.circularButton1.Location = new System.Drawing.Point(767, 88);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(95, 95);
            this.circularButton1.TabIndex = 3;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = true;
            // 
            // AppointmentPanel
            // 
            this.AppointmentPanel.Controls.Add(this.dataGridView1);
            this.AppointmentPanel.Controls.Add(this.label18);
            this.AppointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentPanel.Location = new System.Drawing.Point(0, 0);
            this.AppointmentPanel.Name = "AppointmentPanel";
            this.AppointmentPanel.Size = new System.Drawing.Size(1130, 672);
            this.AppointmentPanel.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(573, 445);
            this.dataGridView1.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.label18.Location = new System.Drawing.Point(189, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(233, 38);
            this.label18.TabIndex = 0;
            this.label18.Text = "Appointments";
            // 
            // Test_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1130, 672);
            this.Controls.Add(this.AppointmentPanel);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Test_User_Control";
            this.Text = "TestUserControls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AppointmentPanel.ResumeLayout(false);
            this.AppointmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PlaceHolderTextBox placeHolderTextBox1;
        private CircularButton circularButton1;
        private System.Windows.Forms.Panel AppointmentPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
    }
}