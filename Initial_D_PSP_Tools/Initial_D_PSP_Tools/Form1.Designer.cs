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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVFSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToModifyAFileInVFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.modHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxPointer = new System.Windows.Forms.CheckBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractVFSRecrusiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIMDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectorBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1,
            this.otherToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(680, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.saveVFSToolStripMenuItem1,
            this.saveVFSToolStripMenuItem});
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.testToolStripMenuItem1.Text = "VFS Options";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.test1ToolStripMenuItem.Text = "Load VFS";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // saveVFSToolStripMenuItem1
            // 
            this.saveVFSToolStripMenuItem1.Name = "saveVFSToolStripMenuItem1";
            this.saveVFSToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveVFSToolStripMenuItem1.Text = "Save VFS";
            this.saveVFSToolStripMenuItem1.Click += new System.EventHandler(this.saveVFSToolStripMenuItem1_Click);
            // 
            // saveVFSToolStripMenuItem
            // 
            this.saveVFSToolStripMenuItem.Name = "saveVFSToolStripMenuItem";
            this.saveVFSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveVFSToolStripMenuItem.Text = "Save VFS as...";
            this.saveVFSToolStripMenuItem.Click += new System.EventHandler(this.saveVFSToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToModifyAFileInVFSToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToModifyAFileInVFSToolStripMenuItem
            // 
            this.howToModifyAFileInVFSToolStripMenuItem.Name = "howToModifyAFileInVFSToolStripMenuItem";
            this.howToModifyAFileInVFSToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.howToModifyAFileInVFSToolStripMenuItem.Text = "How to modify a file in VFS?";
            this.howToModifyAFileInVFSToolStripMenuItem.Click += new System.EventHandler(this.howToModifyAFileInVFSToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRC32FromLookupToolStripMenuItem,
            this.gIMDebugToolStripMenuItem});
            this.debugToolStripMenuItem.Enabled = false;
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
            this.namePointerHeader,
            this.modHeader});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Location = new System.Drawing.Point(0, 24);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(680, 269);
            this.listViewMain.TabIndex = 6;
            this.listViewMain.Tag = "";
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.Visible = false;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
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
            // modHeader
            // 
            this.modHeader.Text = "Modified?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 271);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Ready!";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownOffset.Location = new System.Drawing.Point(474, 272);
            this.numericUpDownOffset.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownOffset.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownOffset.TabIndex = 9;
            this.numericUpDownOffset.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownOffset.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(528, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "End of File - Safe Offset";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(447, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxPointer
            // 
            this.checkBoxPointer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPointer.AutoSize = true;
            this.checkBoxPointer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxPointer.Location = new System.Drawing.Point(495, 5);
            this.checkBoxPointer.Name = "checkBoxPointer";
            this.checkBoxPointer.Size = new System.Drawing.Size(181, 17);
            this.checkBoxPointer.TabIndex = 12;
            this.checkBoxPointer.Text = "Enable Pointer Recalc (unstable)";
            this.checkBoxPointer.UseVisualStyleBackColor = false;
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(185, 129);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(311, 39);
            this.labelMessage.TabIndex = 13;
            this.labelMessage.Text = "Please load a VFS!";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractVFSRecrusiveToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // extractVFSRecrusiveToolStripMenuItem
            // 
            this.extractVFSRecrusiveToolStripMenuItem.Name = "extractVFSRecrusiveToolStripMenuItem";
            this.extractVFSRecrusiveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.extractVFSRecrusiveToolStripMenuItem.Text = "Extract VFS Recrusive";
            this.extractVFSRecrusiveToolStripMenuItem.Click += new System.EventHandler(this.extractVFSRecrusiveToolStripMenuItem_Click);
            // 
            // gIMDebugToolStripMenuItem
            // 
            this.gIMDebugToolStripMenuItem.Name = "gIMDebugToolStripMenuItem";
            this.gIMDebugToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.gIMDebugToolStripMenuItem.Text = "GIM Debug";
            this.gIMDebugToolStripMenuItem.Click += new System.EventHandler(this.gIMDebugToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 293);
            this.Controls.Add(this.checkBoxPointer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownOffset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.labelMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(696, 332);
            this.Name = "MainWindow";
            this.Text = "Initial D - PSP Tools";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectorBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRC32FromLookupToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem saveVFSToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader modHeader;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToModifyAFileInVFSToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown numericUpDownOffset;
        public System.Windows.Forms.CheckBox checkBoxPointer;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractVFSRecrusiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIMDebugToolStripMenuItem;
    }
}

