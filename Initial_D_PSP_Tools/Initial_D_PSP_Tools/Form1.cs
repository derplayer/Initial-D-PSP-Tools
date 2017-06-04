using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initial_D_PSP_Tools
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            new InitD.Core().Main();
        }

        private void anaButton_Click(object sender, EventArgs e)
        {
            new InitD.Core().CrcDebug();
        }

        private void fileInjector_Click(object sender, EventArgs e)
        {
            new InitD.Core().saveAs();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InitD.Core().Main();
        }

        private void cRC32FromLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InitD.Core().CrcDebug();
        }

        private void replaceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InitD.Core().saveAs();
        }

        private void listBoxVFS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveVFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InitD.Core().saveAs();
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            listViewMain.AllowDrop = true;
            listViewMain.DragDrop += new DragEventHandler(listViewMain_DragDrop);
            listViewMain.DragEnter += new DragEventHandler(listViewMain_DragEnter);
        }

        void listViewMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void listViewMain_DragDrop(object sender, DragEventArgs e)
        {
            new InitD.Core().injectData(e);
        }

        private void saveVFSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new InitD.Core().save();
        }

        private void howToModifyAFileInVFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simply drag'n drop your modified file into the list in this application! Remember: The filename muss match with the original one, or it will be ignored!");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Value that will be used as an safe space for file pointer address recalculation.\r\nOnly used when size in an modified file changed! (bigger or smaller)\r\n\r\nLeave 128 or add more if you dont know what to pick.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutWindow = new About();
            AboutWindow.ShowDialog();
        }

        private void extractVFSRecrusiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InitD.Core().MainRecrusive();
        }

        private void gIMDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InitD.GIMCore().initGIM();
        }
    }
}
