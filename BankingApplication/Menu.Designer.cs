namespace BankingApplication
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSearchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem1,
            this.updateSearchAccountToolStripMenuItem,
            this.allCustomersToolStripMenuItem,
            this.toolStripSeparator1});
            this.newAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.newAccountToolStripMenuItem.Text = "Account";
            this.newAccountToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // newAccountToolStripMenuItem1
            // 
            this.newAccountToolStripMenuItem1.Name = "newAccountToolStripMenuItem1";
            this.newAccountToolStripMenuItem1.Size = new System.Drawing.Size(235, 24);
            this.newAccountToolStripMenuItem1.Text = "New Account";
            this.newAccountToolStripMenuItem1.Click += new System.EventHandler(this.newAccountToolStripMenuItem1_Click);
            // 
            // updateSearchAccountToolStripMenuItem
            // 
            this.updateSearchAccountToolStripMenuItem.Name = "updateSearchAccountToolStripMenuItem";
            this.updateSearchAccountToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.updateSearchAccountToolStripMenuItem.Text = "Update/Search Account";
            this.updateSearchAccountToolStripMenuItem.Click += new System.EventHandler(this.updateSearchAccountToolStripMenuItem_Click);
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.allCustomersToolStripMenuItem.Text = "All Customers";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.widthdrawToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.fDFormToolStripMenuItem,
            this.toolStripSeparator2});
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // widthdrawToolStripMenuItem
            // 
            this.widthdrawToolStripMenuItem.Name = "widthdrawToolStripMenuItem";
            this.widthdrawToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.widthdrawToolStripMenuItem.Text = "Widthdraw";
            this.widthdrawToolStripMenuItem.Click += new System.EventHandler(this.widthdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // fDFormToolStripMenuItem
            // 
            this.fDFormToolStripMenuItem.Name = "fDFormToolStripMenuItem";
            this.fDFormToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.fDFormToolStripMenuItem.Text = "FD Form";
            this.fDFormToolStripMenuItem.Click += new System.EventHandler(this.fDFormToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceSheetToolStripMenuItem,
            this.viewFDToolStripMenuItem,
            this.toolStripSeparator3});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // balanceSheetToolStripMenuItem
            // 
            this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.balanceSheetToolStripMenuItem.Text = "Balance Sheet";
            this.balanceSheetToolStripMenuItem.Click += new System.EventHandler(this.balanceSheetToolStripMenuItem_Click);
            // 
            // viewFDToolStripMenuItem
            // 
            this.viewFDToolStripMenuItem.Name = "viewFDToolStripMenuItem";
            this.viewFDToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.viewFDToolStripMenuItem.Text = "View FD";
            this.viewFDToolStripMenuItem.Click += new System.EventHandler(this.viewFDToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripSeparator4});
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.othersToolStripMenuItem.Text = "Others";
            this.othersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1215, 781);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateSearchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
    }
}