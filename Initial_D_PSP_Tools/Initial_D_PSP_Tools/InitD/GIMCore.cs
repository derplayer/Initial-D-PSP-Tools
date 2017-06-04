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

namespace Initial_D_PSP_Tools.InitD
{
    class GIMCore
    {

        public void initGIM()
        {
            OpenFileDialog newPathDlg = new OpenFileDialog();
            newPathDlg.Filter = "Initial D - Image File|*.gim";

            if (newPathDlg.ShowDialog() == DialogResult.OK)
            {
                GIM GIMInstance = new GIM(newPathDlg.FileName);

                

                //GIMInstance.Serialize

                System.Diagnostics.Debug.WriteLine("GIM Experimental Core");

            }

                
        }

    }
}
