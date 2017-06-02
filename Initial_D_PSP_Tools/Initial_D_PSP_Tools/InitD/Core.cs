using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Initial_D_PSP_Tools.InitD
{
    class Core
    {
        public static string loadedVFS { get; set; }


        public void Main()
        {

            System.Diagnostics.Debug.WriteLine("Initial D PSP Tools - Core Module");
            string directory = null, file = null;

            OpenFileDialog newPathDlg = new OpenFileDialog();
            newPathDlg.Filter = "Initial D - Street Stage - VFS Binary|*.bin";

            if (newPathDlg.ShowDialog() == DialogResult.OK)
            {
                file = newPathDlg.FileName;
                directory = Path.GetDirectoryName(file);
                loadedVFS = file;

                List<DataEntry> readedFiles = new Data().LoadVFS(file, directory);

                directory += "\\_Extracted\\";
                Directory.CreateDirectory(directory);

                try
                {
                    foreach (var actualFile in readedFiles)
                    {
                        using (StreamWriter writer = new StreamWriter(new FileStream(directory + "\\" + actualFile.file_name, FileMode.Create)))
                        {
                            writer.BaseStream.Write(actualFile.file_data, 0, actualFile.file_data.Length);
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("Something blew up...");
                }

                Program.MainWindowCore.toolStripStatusLabel1.Text = "Loading finished! (" + newPathDlg.FileName + ")";
            }

        }

        public void injectData(DragEventArgs droppedFile)
        {
            string[] FileList = (string[])droppedFile.Data.GetData(DataFormats.FileDrop, false);

            foreach (var filePath in FileList)
            {
                string checkfileName = Path.GetFileName(filePath);

                foreach (var savedFile in DataCollector.Files)
                {
                    if (checkfileName == savedFile.file_name)
                    {
                        byte[] newFile = File.ReadAllBytes(filePath);
                        savedFile.file_data = newFile;
                        savedFile.file_modified = true;
                        Program.MainWindowCore.toolStripStatusLabel1.Text = "Drag'Drop File modified! (" + checkfileName + ")";
                    }
                }

                Data.UpdateGUI();
            }
        }

        public void save()
        {
            if (loadedVFS != null)
            {
                new Data().SaveVFS(loadedVFS);
                Program.MainWindowCore.toolStripStatusLabel1.Text = "VFS saved!";
            }
            else
            {
                Program.MainWindowCore.toolStripStatusLabel1.Text = "Please load first an file!";
            }
}

        public void saveAs()
        {
            if (loadedVFS != null) {
                SaveFileDialog newSavePathDlg = new SaveFileDialog();
                newSavePathDlg.Filter = "Initial D - Street Stage - VFS Binary|*.bin";

                if (newSavePathDlg.ShowDialog() == DialogResult.OK)
                {
                    new Data().SaveVFS(newSavePathDlg.FileName);
                    Program.MainWindowCore.toolStripStatusLabel1.Text = "VFS saved!";
                }
            }
            else
            {
                Program.MainWindowCore.toolStripStatusLabel1.Text = "Please load first an file!";
            }
        }

        public void CrcDebug()
        {
            List<string> gimfiles = new List<string>();

            OpenFileDialog newPathCRCDlg = new OpenFileDialog();
            newPathCRCDlg.Filter = "CRC TEST|*.*";

            if (newPathCRCDlg.ShowDialog() == DialogResult.OK)
            {
                byte[] fileArray = File.ReadAllBytes(newPathCRCDlg.FileName);
                List<byte[]> crcVariations = CRC.CRC32(fileArray);
                string crcList = String.Empty; int i = 0;

                foreach (var crcItem in crcVariations)
                {
                    crcList += "Hash" + i + " | " + BitConverter.ToString(crcItem) + Environment.NewLine;
                    i++;
                }
                Program.MainWindowCore.toolStripStatusLabel1.Text = "CRC Debug finnished...";
                MessageBox.Show(crcList);  
            }
        }
}
}
