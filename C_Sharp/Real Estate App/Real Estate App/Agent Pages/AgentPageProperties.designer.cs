namespace Real_Estate_App.Agent_pages
{
    partial class AgentPageProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentPageProperties));
            this.displayProperties1 = new Real_Estate_App.User_Control.DisplayProperties();
            this.txt_Search = new Real_Estate_App.User_Control.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // displayProperties1
            // 
            this.displayProperties1.AppointmentID = "0";
            this.displayProperties1.AutoScroll = true;
            this.displayProperties1.BackColor = System.Drawing.Color.Transparent;
            this.displayProperties1.Location = new System.Drawing.Point(12, 38);
            this.displayProperties1.Name = "displayProperties1";
            this.displayProperties1.Properties = null;
            this.displayProperties1.PropertyClicked = null;
            this.displayProperties1.Size = new System.Drawing.Size(645, 263);
            this.displayProperties1.TabIndex = 1;
            this.displayProperties1.UserID = "0";
            this.displayProperties1.UserType = "agent";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            this.txt_Search.ForeColor = System.Drawing.Color.Gray;
            this.txt_Search.Location = new System.Drawing.Point(12, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceHolder = "Search";
            this.txt_Search.Size = new System.Drawing.Size(141, 20);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.Text = "Search";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // AgentPageProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Real_Estate_App.Properties.Resources.istockphoto_1324561334_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.displayProperties1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentPageProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgentPageProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Control.DisplayProperties displayProperties1;
        private User_Control.PlaceHolderTextBox txt_Search;
    }
}