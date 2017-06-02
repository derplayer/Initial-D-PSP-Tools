namespace Initial_D_PSP_Tools
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC32FromLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCollectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewMain = new System.Windows.Forms.ListView();
            this.indexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beginHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unknownHashHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namePointerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1,
            this.debugToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(699, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.replaceFileToolStripMenuItem,
            this.saveVFSToolStripMenuItem});
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.testToolStripMenuItem1.Text = "VFS Options";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.test1ToolStripMenuItem.Text = "Load VFS";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // replaceFileToolStripMenuItem
            // 
            this.replaceFileToolStripMenuItem.Name = "replaceFileToolStripMenuItem";
            this.replaceFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.replaceFileToolStripMenuItem.Text = "Replace File";
            this.replaceFileToolStripMenuItem.Click += new System.EventHandler(this.replaceFileToolStripMenuItem_Click);
            // 
            // saveVFSToolStripMenuItem
            // 
            this.saveVFSToolStripMenuItem.Name = "saveVFSToolStripMenuItem";
            this.saveVFSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveVFSToolStripMenuItem.Text = "Save VFS";
            this.saveVFSToolStripMenuItem.Click += new System.EventHandler(this.saveVFSToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRC32FromLookupToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // cRC32FromLookupToolStripMenuItem
            // 
            this.cRC32FromLookupToolStripMenuItem.Name = "cRC32FromLookupToolStripMenuItem";
            this.cRC32FromLookupToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cRC32FromLookupToolStripMenuItem.Text = "CRC32 From Lookup Tables";
            this.cRC32FromLookupToolStripMenuItem.Click += new System.EventHandler(this.cRC32FromLookupToolStripMenuItem_Click);
            // 
            // dataCollectorBindingSource
            // 
            this.dataCollectorBindingSource.DataSource = typeof(Initial_D_PSP_Tools.InitD.DataCollector);
            // 
            // listViewMain
            // 
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexHeader,
            this.beginHeader,
            this.sizeHeader,
            this.endHeader,
            this.unknownHashHeader,
            this.dataHeader,
            this.nameHeader,
            this.namePointerHeader});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Location = new System.Drawing.Point(0, 24);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(699, 307);
            this.listViewMain.TabIndex = 6;
            this.listViewMain.Tag = "";
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // indexHeader
            // 
            this.indexHeader.Tag = "";
            this.indexHeader.Text = "Index";
            // 
            // beginHeader
            // 
            this.beginHeader.Text = "Begin (*)";
            // 
            // sizeHeader
            // 
            this.sizeHeader.Text = "File Size";
            // 
            // endHeader
            // 
            this.endHeader.Text = "End (*)";
            // 
            // unknownHashHeader
            // 
            this.unknownHashHeader.Text = "Unknown Hash";
            // 
            // dataHeader
            // 
            this.dataHeader.Text = "Data";
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Filename";
            // 
            // namePointerHeader
            // 
            this.namePointerHeader.Text = "Filename (*)";
            this.namePointerHeader.Width = 87;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 331);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Initial D - PSP Tools";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRC32FromLookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceFileToolStripMenuItem;
        private System.Windows.Forms.BindingSource dataCollectorBindingSource;
        public System.Windows.Forms.ListView listViewMain;
        public System.Windows.Forms.ColumnHeader indexHeader;
        public System.Windows.Forms.ColumnHeader beginHeader;
        public System.Windows.Forms.ColumnHeader sizeHeader;
        public System.Windows.Forms.ColumnHeader endHeader;
        public System.Windows.Forms.ColumnHeader unknownHashHeader;
        public System.Windows.Forms.ColumnHeader dataHeader;
        public System.Windows.Forms.ColumnHeader nameHeader;
        public System.Windows.Forms.ColumnHeader namePointerHeader;
    }
}

