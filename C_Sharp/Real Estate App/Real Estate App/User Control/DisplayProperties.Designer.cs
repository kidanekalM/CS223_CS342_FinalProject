namespace Real_Estate_App.User_Control
{
    partial class DisplayProperties
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayProperties));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.displayProperty2 = new Real_Estate_App.User_Control.DisplayProperty();
            this.displayProperty1 = new Real_Estate_App.User_Control.DisplayProperty();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.displayProperty2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.displayProperty1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 629);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // displayProperty2
            // 
            this.displayProperty2.PropertyAddress = null;
            this.displayProperty2.Availablity = null;
            this.displayProperty2.BackColor = System.Drawing.SystemColors.Control;
            this.displayProperty2.PropertyDescription = null;
            this.displayProperty2.ID = null;
            this.displayProperty2.Location = new System.Drawing.Point(6, 315);
            this.displayProperty2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.displayProperty2.Name = "displayProperty2";
            this.displayProperty2.Photo = ((System.Drawing.Image)(resources.GetObject("displayProperty2.Photo")));
            this.displayProperty2.PropertyPrice = null;
            this.displayProperty2.Size = new System.Drawing.Size(891, 306);
            this.displayProperty2.TabIndex = 1;
            // 
            // displayProperty1
            // 
            this.displayProperty1.PropertyAddress = null;
            this.displayProperty1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayProperty1.Availablity = null;
            this.displayProperty1.BackColor = System.Drawing.SystemColors.Control;
            this.displayProperty1.PropertyDescription = null;
            this.displayProperty1.ID = null;
            this.displayProperty1.Location = new System.Drawing.Point(6, 8);
            this.displayProperty1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.displayProperty1.Name = "displayProperty1";
            this.displayProperty1.Photo = ((System.Drawing.Image)(resources.GetObject("displayProperty1.Photo")));
            this.displayProperty1.PropertyPrice = null;
            this.displayProperty1.Size = new System.Drawing.Size(915, 291);
            this.displayProperty1.TabIndex = 0;
            // 
            // DisplayProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayProperties";
            this.Size = new System.Drawing.Size(860, 277);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DisplayProperty displayProperty2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DisplayProperty displayProperty1;
    }
}
