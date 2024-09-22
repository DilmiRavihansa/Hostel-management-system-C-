namespace HostalMngm_System
{
    partial class Home_Page
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
            this.menuStripHomePage = new System.Windows.Forms.MenuStrip();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHostelMgtSystem = new System.Windows.Forms.Label();
            this.pictureBoxHomePage = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label_Exit = new System.Windows.Forms.Label();
            this.menuStripHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripHomePage
            // 
            this.menuStripHomePage.BackColor = System.Drawing.SystemColors.Window;
            this.menuStripHomePage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.UserToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.furnitureToolStripMenuItem});
            this.menuStripHomePage.Location = new System.Drawing.Point(0, 0);
            this.menuStripHomePage.Name = "menuStripHomePage";
            this.menuStripHomePage.Size = new System.Drawing.Size(800, 28);
            this.menuStripHomePage.TabIndex = 0;
            this.menuStripHomePage.Text = "menuStrip1";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.UserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.UserToolStripMenuItem.Text = "Users";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.paymentToolStripMenuItem.Text = "Furniture";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // furnitureToolStripMenuItem
            // 
            this.furnitureToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureToolStripMenuItem.Name = "furnitureToolStripMenuItem";
            this.furnitureToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.furnitureToolStripMenuItem.Text = "Payment";
            this.furnitureToolStripMenuItem.Click += new System.EventHandler(this.furnitureToolStripMenuItem_Click);
            // 
            // labelHostelMgtSystem
            // 
            this.labelHostelMgtSystem.AutoSize = true;
            this.labelHostelMgtSystem.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostelMgtSystem.Location = new System.Drawing.Point(196, 44);
            this.labelHostelMgtSystem.Name = "labelHostelMgtSystem";
            this.labelHostelMgtSystem.Size = new System.Drawing.Size(404, 30);
            this.labelHostelMgtSystem.TabIndex = 2;
            this.labelHostelMgtSystem.Text = "Hostel Management System";
            // 
            // pictureBoxHomePage
            // 
            this.pictureBoxHomePage.BackgroundImage = global::HostalMngm_System.Properties.Resources.d5fd64011;
            this.pictureBoxHomePage.Location = new System.Drawing.Point(0, 86);
            this.pictureBoxHomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHomePage.Name = "pictureBoxHomePage";
            this.pictureBoxHomePage.Size = new System.Drawing.Size(800, 329);
            this.pictureBoxHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomePage.TabIndex = 1;
            this.pictureBoxHomePage.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Window;
            this.panelFooter.Location = new System.Drawing.Point(0, 443);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 32);
            this.panelFooter.TabIndex = 3;
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.GhostWhite;
            this.label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.Red;
            this.label_Exit.Location = new System.Drawing.Point(779, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(21, 20);
            this.label_Exit.TabIndex = 4;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.labelHostelMgtSystem);
            this.Controls.Add(this.pictureBoxHomePage);
            this.Controls.Add(this.menuStripHomePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripHomePage;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home_Page";
            this.Text = " ";
            this.menuStripHomePage.ResumeLayout(false);
            this.menuStripHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHomePage;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnitureToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxHomePage;
        private System.Windows.Forms.Label labelHostelMgtSystem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label_Exit;
    }
}