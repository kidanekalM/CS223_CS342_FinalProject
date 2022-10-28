namespace Real_Estate_App.Client_Pages
{
    partial class ClientAppointmentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAppointmentPage));
            this.panel = new System.Windows.Forms.Panel();
            this.btn_CancleAppointment = new System.Windows.Forms.Button();
            this.dgv_AppointmentTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_CancleAppointment);
            this.panel.Controls.Add(this.dgv_AppointmentTable);
            this.panel.Controls.Add(this.label1);
            this.panel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(43, 73);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(577, 285);
            this.panel.TabIndex = 1;
            // 
            // btn_CancleAppointment
            // 
            this.btn_CancleAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_CancleAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancleAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancleAppointment.ForeColor = System.Drawing.Color.White;
            this.btn_CancleAppointment.Location = new System.Drawing.Point(225, 234);
            this.btn_CancleAppointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CancleAppointment.Name = "btn_CancleAppointment";
            this.btn_CancleAppointment.Size = new System.Drawing.Size(146, 32);
            this.btn_CancleAppointment.TabIndex = 3;
            this.btn_CancleAppointment.Text = "Cancle Appointment";
            this.btn_CancleAppointment.UseVisualStyleBackColor = false;
            this.btn_CancleAppointment.Click += new System.EventHandler(this.btn_CancleAppointment_Click);
            // 
            // dgv_AppointmentTable
            // 
            this.dgv_AppointmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AppointmentTable.Location = new System.Drawing.Point(27, 60);
            this.dgv_AppointmentTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_AppointmentTable.Name = "dgv_AppointmentTable";
            this.dgv_AppointmentTable.RowHeadersWidth = 62;
            this.dgv_AppointmentTable.RowTemplate.Height = 28;
            this.dgv_AppointmentTable.Size = new System.Drawing.Size(522, 158);
            this.dgv_AppointmentTable.TabIndex = 2;
            this.dgv_AppointmentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AppointmentTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Real_Estate_App.Properties.Resources.naomi_august_wI55e75C5TY_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClientAppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 383);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientAppointmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientAppointmentPage";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CancleAppointment;
        private System.Windows.Forms.DataGridView dgv_AppointmentTable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}