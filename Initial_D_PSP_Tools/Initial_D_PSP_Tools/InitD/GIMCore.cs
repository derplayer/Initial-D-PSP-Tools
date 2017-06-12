using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyoutaTools.Other.PSP.GIM;
using HyoutaTools.Other.PSP.GIM.HomogenizePalette;
using HyoutaTools.Other.PSP.GIM.LayerSplitter;
using System.Windows.Forms;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Initial_D_PSP_Tools.InitD
{
    class GIMCore
    {

        public void showGIM()
        {
            OpenFileDialog newPathDlg = new OpenFileDialog();
            newPathDlg.Filter = "Initial D - Image File|*.gim";

            if (newPathDlg.ShowDialog() == DialogResult.OK)
            {
                GIM GIMInstance = new GIM(newPathDlg.FileName);

                string newFileName = Path.GetFileNameWithoutExtension(newPathDlg.FileName) + ".png";
                string pngTemp = Path.GetTempPath() + newFileName;

                String command = String.Format("/C gimconv \"{0}\" -o \"{1}\"", newPathDlg.FileName, pngTemp);

                ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
                cmdsi.Arguments = command;
                cmdsi.WindowStyle = ProcessWindowStyle.Hidden;
                Process cmd = Process.Start(cmdsi);
                cmd.WaitForExit();

                Image image = Image.FromFile(pngTemp);

                GIMBox GIMImage = new GIMBox(image);
                GIMImage.ShowDialog();

                Debug.WriteLine("Initial D - GIM Experimental Core - showGIM() finnished!");
            }
        }

        }
}
