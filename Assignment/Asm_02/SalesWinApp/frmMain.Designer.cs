namespace SalesWinApp
{
    partial class frmMain
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
            mainMenuStrip = new MenuStrip();
            membersToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            viewOrdersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            gbContent = new GroupBox();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { membersToolStripMenuItem, ordersToolStripMenuItem, productsToolStripMenuItem, logOutToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1902, 28);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Size = new Size(85, 24);
            membersToolStripMenuItem.Text = "Members";
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewOrdersToolStripMenuItem });
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(67, 24);
            ordersToolStripMenuItem.Text = "Orders";
            // 
            // viewOrdersToolStripMenuItem
            // 
            viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            viewOrdersToolStripMenuItem.Size = new Size(172, 26);
            viewOrdersToolStripMenuItem.Text = "View Orders";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.ForeColor = Color.Black;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(76, 24);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // gbContent
            // 
            gbContent.Location = new Point(0, 31);
            gbContent.Name = "gbContent";
            gbContent.Size = new Size(1163, 442);
            gbContent.TabIndex = 5;
            gbContent.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(gbContent);
            Controls.Add(mainMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = mainMenuStrip;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private GroupBox gbContent;
        private ToolStripMenuItem viewOrdersToolStripMenuItem;
    }
}