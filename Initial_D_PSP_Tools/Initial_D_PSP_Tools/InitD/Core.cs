using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.IO.Compression;

namespace Initial_D_PSP_Tools.InitD
{
    class Core
    {
        public static string loadedVFS { get; set; }


        public void Main()
        {
            try
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

                    directory += "\\_" + Path.GetFileName(newPathDlg.FileName) + "_\\";
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
                    Program.MainWindowCore.listViewMain.Visible = true;
                }
            }
            catch (IOException e)
            {
                Program.MainWindowCore.toolStripStatusLabel1.Text = "Error at loadData: " + e.TargetSite;
            }
        }

        //TODO: Merge MainRecrusive() with Main() to drop the ugly redundance
        public void MainRecrusive()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Initial D PSP Tools - Core Module");
                string directory = null, file = null;

                FolderBrowserDialog newFolderDlg = new FolderBrowserDialog();

                if (newFolderDlg.ShowDialog() == DialogResult.OK)
                {

                    foreach (var fileXY in GetFiles(newFolderDlg.SelectedPath))
                    {
                        file = Path.GetFileName(fileXY);
                        string tempFileExt = Path.GetExtension(fileXY);

                        if (tempFileExt == ".bin" || tempFileExt == ".gz")
                        {
                            directory = Path.GetDirectoryName(fileXY);

                            loadedVFS = fileXY;
                            List<DataEntry> readedFiles = new Data().LoadVFS(fileXY, directory);

                            if (readedFiles != null)
                            {
                                directory += "\\_" + Path.GetFileName(file) + "_\\";
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

                                Program.MainWindowCore.toolStripStatusLabel1.Text = "Loading finished! (" + file + ")";
                                Program.MainWindowCore.listViewMain.Visible = true;
                            }
                        }

                    }
                }
            }
            catch (IOException e)
            {
                Program.MainWindowCore.toolStripStatusLabel1.Text = "Error at loadData: " + e.TargetSite;
            }

        }


        public void injectData(DragEventArgs droppedFile)
        {
            try
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
            catch (IOException e)
            {
                Program.MainWindowCore.toolStripStatusLabel1.Text = "Error at injectData: " + e.TargetSite;
            }
        }

        public void save()
        {
            try
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
            catch (IOException e)
            {
                Program.MainWindowCore.toolStripStatusLabel1.Text = "Error at saveAs: " + e.TargetSite;
            }
        }

        public void saveAs()
        {
            try
            {
                if (loadedVFS != null)
                {
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
            catch (IOException e)
            {
                Program.MainWindowCore.toolStripStatusLabel1.Text = "Error at saveAs: " + e.TargetSite;
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
                crcList += Environment.NewLine + "(Last one is Adler32 with base settings)" + Environment.NewLine;

                Program.MainWindowCore.toolStripStatusLabel1.Text = "CRC Debug finnished...";
                MessageBox.Show(crcList);
            }
        }

        static IEnumerable<string> GetFiles(string path)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }
    }
}
