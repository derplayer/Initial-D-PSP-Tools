using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initial_D_PSP_Tools
{
    static class Program
    {
        public static MainWindow MainWindowCore = new MainWindow();

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            if (System.Diagnostics.Debugger.IsAttached)
            {
                MainWindowCore.debugToolStripMenuItem.Enabled = true;
            }
            Run();
        }

        public static void Run()
        {
            Application.Run(MainWindowCore);
        }
    }
}
