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
            new InitD.Core().injectData();
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
            new InitD.Core().injectData();
        }

        private void listBoxVFS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveVFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InitD.Core().injectData();
        }
    }
}
