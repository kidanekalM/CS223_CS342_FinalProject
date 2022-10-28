namespace Real_Estate_App.Agent_pages
{
    partial class AgentAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentAppointment));
            this.dgvAgentAppointment = new System.Windows.Forms.DataGridView();
            this.titleAppointment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgentAppointment
            // 
            this.dgvAgentAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgentAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgentAppointment.Location = new System.Drawing.Point(30, 55);
            this.dgvAgentAppointment.Name = "dgvAgentAppointment";
            this.dgvAgentAppointment.Size = new System.Drawing.Size(612, 237);
            this.dgvAgentAppointment.TabIndex = 0;
            // 
            // titleAppointment
            // 
            this.titleAppointment.AutoSize = true;
            this.titleAppointment.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAppointment.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleAppointment.Location = new System.Drawing.Point(215, 9);
            this.titleAppointment.Name = "titleAppointment";
            this.titleAppointment.Size = new System.Drawing.Size(211, 36);
            this.titleAppointment.TabIndex = 1;
            this.titleAppointment.Text = "Appointments";
            // 
            // AgentAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.titleAppointment);
            this.Controls.Add(this.dgvAgentAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgentAppointment";
            this.Load += new System.EventHandler(this.AgentAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgentAppointment;
        private System.Windows.Forms.Label titleAppointment;
    }
}