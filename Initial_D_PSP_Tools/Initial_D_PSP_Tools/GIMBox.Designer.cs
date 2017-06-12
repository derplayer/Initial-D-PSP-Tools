namespace Initial_D_PSP_Tools
{
    partial class GIMBox
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
            this.gimPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gimPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gimPicture
            // 
            this.gimPicture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gimPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gimPicture.Location = new System.Drawing.Point(0, 0);
            this.gimPicture.Name = "gimPicture";
            this.gimPicture.Size = new System.Drawing.Size(375, 239);
            this.gimPicture.TabIndex = 0;
            this.gimPicture.TabStop = false;
            this.gimPicture.Click += new System.EventHandler(this.gimPicture_Click);
            // 
            // GIMBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 239);
            this.Controls.Add(this.gimPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GIMBox";
            this.Text = "Show GIM File";
            ((System.ComponentModel.ISupportInitialize)(this.gimPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox gimPicture;
    }
}