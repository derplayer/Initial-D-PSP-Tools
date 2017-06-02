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
    }
}
