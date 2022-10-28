namespace Real_Estate_App.Agent_pages
{
    partial class ClientsLinkedtoAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsLinkedtoAgent));
            this.dgvAgentClientShower = new System.Windows.Forms.DataGridView();
            this.lbldisplaymyclient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentClientShower)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgentClientShower
            // 
            this.dgvAgentClientShower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgentClientShower.Location = new System.Drawing.Point(36, 81);
            this.dgvAgentClientShower.Name = "dgvAgentClientShower";
            this.dgvAgentClientShower.Size = new System.Drawing.Size(599, 247);
            this.dgvAgentClientShower.TabIndex = 0;
            // 
            // lbldisplaymyclient
            // 
            this.lbldisplaymyclient.AutoSize = true;
            this.lbldisplaymyclient.BackColor = System.Drawing.Color.Transparent;
            this.lbldisplaymyclient.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplaymyclient.Location = new System.Drawing.Point(267, 44);
            this.lbldisplaymyclient.Name = "lbldisplaymyclient";
            this.lbldisplaymyclient.Size = new System.Drawing.Size(157, 34);
            this.lbldisplaymyclient.TabIndex = 1;
            this.lbldisplaymyclient.Text = "My Clients ";
            // 
            // ClientsLinkedtoAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 352);
            this.Controls.Add(this.lbldisplaymyclient);
            this.Controls.Add(this.dgvAgentClientShower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsLinkedtoAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsLinkedtoAgent";
            this.Load += new System.EventHandler(this.ClientsLinkedtoAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentClientShower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgentClientShower;
        private System.Windows.Forms.Label lbldisplaymyclient;
    }
}