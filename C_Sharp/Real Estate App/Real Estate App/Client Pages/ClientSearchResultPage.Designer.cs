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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rb_Descending = new System.Windows.Forms.RadioButton();
            this.rb_Asscending = new System.Windows.Forms.RadioButton();
            this.cmbx_SortBy = new System.Windows.Forms.ComboBox();
            this.lbl_SortBy = new System.Windows.Forms.Label();
            this.pnl_TopPanel.SuspendLayout();
            this.pnl_LeftPanel.SuspendLayout();
            this.groupBox.SuspendLayout();
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
            this.pnl_TopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_TopPanel.Name = "pnl_TopPanel";
            this.pnl_TopPanel.Size = new System.Drawing.Size(779, 98);
            this.pnl_TopPanel.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Back.BackgroundImage = global::Real_Estate_App.Properties.Resources.blue_chart_icon;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(718, 28);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(42, 43);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_SearchResult
            // 
            this.lbl_SearchResult.AutoSize = true;
            this.lbl_SearchResult.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchResult.Location = new System.Drawing.Point(262, 28);
            this.lbl_SearchResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SearchResult.Name = "lbl_SearchResult";
            this.lbl_SearchResult.Size = new System.Drawing.Size(273, 44);
            this.lbl_SearchResult.TabIndex = 0;
            this.lbl_SearchResult.Text = "Search Results";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(213, 116);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(547, 334);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // pnl_LeftPanel
            // 
            this.pnl_LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pnl_LeftPanel.Controls.Add(this.groupBox);
            this.pnl_LeftPanel.Controls.Add(this.cmbx_SortBy);
            this.pnl_LeftPanel.Controls.Add(this.lbl_SortBy);
            this.pnl_LeftPanel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_LeftPanel.ForeColor = System.Drawing.Color.Black;
            this.pnl_LeftPanel.Location = new System.Drawing.Point(0, 97);
            this.pnl_LeftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_LeftPanel.Name = "pnl_LeftPanel";
            this.pnl_LeftPanel.Size = new System.Drawing.Size(192, 374);
            this.pnl_LeftPanel.TabIndex = 2;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rb_Descending);
            this.groupBox.Controls.Add(this.rb_Asscending);
            this.groupBox.Location = new System.Drawing.Point(19, 282);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Size = new System.Drawing.Size(156, 80);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            // 
            // rb_Descending
            // 
            this.rb_Descending.AutoSize = true;
            this.rb_Descending.Location = new System.Drawing.Point(5, 42);
            this.rb_Descending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Descending.Name = "rb_Descending";
            this.rb_Descending.Size = new System.Drawing.Size(112, 23);
            this.rb_Descending.TabIndex = 1;
            this.rb_Descending.TabStop = true;
            this.rb_Descending.Text = "Descending";
            this.rb_Descending.UseVisualStyleBackColor = true;
            // 
            // rb_Asscending
            // 
            this.rb_Asscending.AutoSize = true;
            this.rb_Asscending.Location = new System.Drawing.Point(5, 17);
            this.rb_Asscending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Asscending.Name = "rb_Asscending";
            this.rb_Asscending.Size = new System.Drawing.Size(107, 23);
            this.rb_Asscending.TabIndex = 0;
            this.rb_Asscending.TabStop = true;
            this.rb_Asscending.Text = "Asscending";
            this.rb_Asscending.UseVisualStyleBackColor = true;
            // 
            // cmbx_SortBy
            // 
            this.cmbx_SortBy.BackColor = System.Drawing.Color.Black;
            this.cmbx_SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_SortBy.ForeColor = System.Drawing.Color.White;
            this.cmbx_SortBy.FormattingEnabled = true;
            this.cmbx_SortBy.Items.AddRange(new object[] {
            "Date",
            "Type",
            "Price"});
            this.cmbx_SortBy.Location = new System.Drawing.Point(19, 243);
            this.cmbx_SortBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbx_SortBy.Name = "cmbx_SortBy";
            this.cmbx_SortBy.Size = new System.Drawing.Size(155, 25);
            this.cmbx_SortBy.TabIndex = 5;
            // 
            // lbl_SortBy
            // 
            this.lbl_SortBy.AutoSize = true;
            this.lbl_SortBy.Location = new System.Drawing.Point(16, 224);
            this.lbl_SortBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SortBy.Name = "lbl_SortBy";
            this.lbl_SortBy.Size = new System.Drawing.Size(54, 19);
            this.lbl_SortBy.TabIndex = 4;
            this.lbl_SortBy.Text = "Sort By";
            // 
            // ClientSearchResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 471);
            this.Controls.Add(this.pnl_LeftPanel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pnl_TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientSearchResultPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientSearchResultPage";
            this.pnl_TopPanel.ResumeLayout(false);
            this.pnl_TopPanel.PerformLayout();
            this.pnl_LeftPanel.ResumeLayout(false);
            this.pnl_LeftPanel.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TopPanel;
        private System.Windows.Forms.Label lbl_SearchResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_LeftPanel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rb_Descending;
        private System.Windows.Forms.RadioButton rb_Asscending;
        private System.Windows.Forms.ComboBox cmbx_SortBy;
        private System.Windows.Forms.Label lbl_SortBy;
    }
}