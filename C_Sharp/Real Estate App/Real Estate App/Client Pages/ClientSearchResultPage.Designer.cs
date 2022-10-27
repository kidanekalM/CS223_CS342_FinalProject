namespace Real_Estate_App.Client_Pages
{
    partial class ClientSearchResultPage
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
            this.pnl_TopPanel = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_SearchResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_LeftPanel = new System.Windows.Forms.Panel();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.pnl_TopPanel.SuspendLayout();
            this.pnl_LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TopPanel
            // 
            this.pnl_TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_TopPanel.Controls.Add(this.btn_Back);
            this.pnl_TopPanel.Controls.Add(this.lbl_SearchResult);
            this.pnl_TopPanel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_TopPanel.ForeColor = System.Drawing.Color.White;
            this.pnl_TopPanel.Location = new System.Drawing.Point(0, -2);
            this.pnl_TopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_TopPanel.Name = "pnl_TopPanel";
            this.pnl_TopPanel.Size = new System.Drawing.Size(1002, 122);
            this.pnl_TopPanel.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Back.BackgroundImage = global::Real_Estate_App.Properties.Resources.blue_chart_icon;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(923, 35);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(54, 54);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_SearchResult
            // 
            this.lbl_SearchResult.AutoSize = true;
            this.lbl_SearchResult.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchResult.Location = new System.Drawing.Point(337, 35);
            this.lbl_SearchResult.Name = "lbl_SearchResult";
            this.lbl_SearchResult.Size = new System.Drawing.Size(324, 51);
            this.lbl_SearchResult.TabIndex = 0;
            this.lbl_SearchResult.Text = "Search Results";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(274, 145);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(703, 418);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // pnl_LeftPanel
            // 
            this.pnl_LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pnl_LeftPanel.Controls.Add(this.lbl_Result);
            this.pnl_LeftPanel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_LeftPanel.ForeColor = System.Drawing.Color.Black;
            this.pnl_LeftPanel.Location = new System.Drawing.Point(0, 121);
            this.pnl_LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_LeftPanel.Name = "pnl_LeftPanel";
            this.pnl_LeftPanel.Size = new System.Drawing.Size(247, 468);
            this.pnl_LeftPanel.TabIndex = 2;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(66, 383);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(91, 23);
            this.lbl_Result.TabIndex = 0;
            this.lbl_Result.Text = "Result = ";
            // 
            // ClientSearchResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 589);
            this.Controls.Add(this.pnl_LeftPanel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pnl_TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientSearchResultPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientSearchResultPage";
            this.Load += new System.EventHandler(this.ClientSearchResultPage_Load);
            this.pnl_TopPanel.ResumeLayout(false);
            this.pnl_TopPanel.PerformLayout();
            this.pnl_LeftPanel.ResumeLayout(false);
            this.pnl_LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TopPanel;
        private System.Windows.Forms.Label lbl_SearchResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_LeftPanel;
        private System.Windows.Forms.Label lbl_Result;
    }
}