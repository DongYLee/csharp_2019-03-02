namespace AddrBook
{
    partial class FrmMDIMain
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주소록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webCrawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView이용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid이용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.주소록ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(166, 426);
            this.treeView1.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.webCrawlerToolStripMenuItem,
            this.viewLogToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // 주소록ToolStripMenuItem
            // 
            this.주소록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listView이용ToolStripMenuItem,
            this.dataGrid이용ToolStripMenuItem});
            this.주소록ToolStripMenuItem.Name = "주소록ToolStripMenuItem";
            this.주소록ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.주소록ToolStripMenuItem.Text = "주소록";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // webCrawlerToolStripMenuItem
            // 
            this.webCrawlerToolStripMenuItem.Name = "webCrawlerToolStripMenuItem";
            this.webCrawlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.webCrawlerToolStripMenuItem.Text = "Web-Crawler";
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewLogToolStripMenuItem.Text = "View Log";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // listView이용ToolStripMenuItem
            // 
            this.listView이용ToolStripMenuItem.Name = "listView이용ToolStripMenuItem";
            this.listView이용ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listView이용ToolStripMenuItem.Text = "ListView 이용";
            this.listView이용ToolStripMenuItem.Click += new System.EventHandler(this.listView이용ToolStripMenuItem_Click);
            // 
            // dataGrid이용ToolStripMenuItem
            // 
            this.dataGrid이용ToolStripMenuItem.Name = "dataGrid이용ToolStripMenuItem";
            this.dataGrid이용ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataGrid이용ToolStripMenuItem.Text = "DataGrid 이용";
            this.dataGrid이용ToolStripMenuItem.Click += new System.EventHandler(this.dataGrid이용ToolStripMenuItem_Click);
            // 
            // FrmMDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDIMain";
            this.Text = "FrmMDIMain";
            this.Load += new System.EventHandler(this.FrmMDIMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCrawlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주소록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listView이용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGrid이용ToolStripMenuItem;
    }
}