using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Initial_D_PSP_Tools.InitD
{
    public static class DataCollector
    {
        public static List<DataEntry> Files { get; set; } = new List<DataEntry>();
        public static byte[] MetaBlock { get; set; }

        //public static List<DataEntry> Files { get; set; } = new List<DataEntry>();
    }

    public class DataEntry
    {
        public int index_position { get; set; }

        public byte[] file_begin { get; set; }             //Begin Pointer
        public byte[] file_size { get; set; }              //File Size
        public byte[] file_end { get; set; }               //End Pointer (Start + Size = End)
        public byte[] file_unknownhash { get; set; }

        public byte[] file_data { get; set; }
        public string file_name { get; set; }
        public byte[] file_name_pointer { get; set; }
        public bool file_modified { get; set; }
    }

    public class Data
    {

        public List<DataEntry> LoadVFS(string path, string directory)
        {
            clearVFS();

            string tempFileExt = Path.GetExtension(path);
            string finGZPath = null;

            try {
                if(tempFileExt == ".gz")
                {
                    FileInfo fileToDecompress = new FileInfo(path);
                    using (FileStream originalFileStream = fileToDecompress.OpenRead())
                    {
                        string currentFileName = fileToDecompress.FullName;
                        string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                        using (FileStream decompressedFileStream = File.Create(newFileName))
                        {
                            using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                            {
                                decompressionStream.CopyTo(decompressedFileStream);
                                finGZPath = newFileName;
                            }
                        }
                    }
                }
            } catch(Exception e)
            {
                return null;
            }

            using (BinaryReader reader = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                string header = Encoding.ASCII.GetString(reader.ReadBytes(3));
                if (header != "XBB") return null; //Initial D - PSP VFS Identifier

                reader.BaseStream.Seek(1, SeekOrigin.Current); //Skip 01 flag (?)
                int fileCount = reader.ReadInt16(); //Read byte from 4th position
                reader.BaseStream.Seek(32, SeekOrigin.Begin);

                for (int i = 1; i <= fileCount; i++)
                {
                    DataEntry actualFile = new DataEntry();

                    //byte[] fileEntryBytes = new byte[15];
                    //reader.Read(fileEntryBytes, 0, fileEntryBytes.Length);

                    actualFile.index_position = i;
                    actualFile.file_begin = reader.ReadBytes(4);
                    actualFile.file_end = reader.ReadBytes(4);

                    int pointerMergeInt = BitConverter.ToInt32(actualFile.file_begin, 0) + BitConverter.ToInt32(actualFile.file_end, 0);
                    byte[] pointerMerge = BitConverter.GetBytes(pointerMergeInt);

                    actualFile.file_size = pointerMerge;
                    actualFile.file_name_pointer = reader.ReadBytes(4);

                    actualFile.file_unknownhash = reader.ReadBytes(4);
                    actualFile.file_modified = false;

                    DataCollector.Files.Add(actualFile);
                }

                //ignore unknown meta data for first (8 bytes per file)
                //reader.BaseStream.Seek(fileCount * 8 , SeekOrigin.Current); //+8 byte per file
                DataCollector.MetaBlock = reader.ReadBytes(fileCount * 8);

                foreach (var file in DataCollector.Files)
                {
                    string fileName = null;

                    while (true)
                    {
                        byte singleByte = reader.ReadByte();

                        if (singleByte == 0) { break; }
                        fileName += Convert.ToChar(singleByte);
                    }

                    file.file_name = fileName;
                }

                //rape on memory managment / 27.05.2017-28.05.2017
                foreach (var file in DataCollector.Files) //new foreach beacause of stream position (muh performance heh)
                {
                    reader.BaseStream.Seek(BitConverter.ToInt32(file.file_begin, 0), SeekOrigin.Begin);

                    long startPos = BitConverter.ToInt32(file.file_begin, 0);
                    long endPos = BitConverter.ToInt32(file.file_size, 0);

                    byte[] dataArray = new byte[endPos - startPos];
                    reader.Read(dataArray, 0, dataArray.Length);

                    file.file_data = dataArray;
                }
                reader.Close();
            }

            UpdateGUI();
            return DataCollector.Files;
        }

        public void SaveVFS(string path)
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream(path, FileMode.Create)))
            {

                writer.Write(0x01424258); //Initial D - PSP VFS Identifier
                writer.Write(DataCollector.Files.Count);

                while (true) //Fill rest of header with nulls
                {
                    if (writer.BaseStream.Position >= 32) break;
                    writer.BaseStream.WriteByte(0x00);
                }

                //Check if pointer changed (size)
                foreach (var file in DataCollector.Files)
                {
                    int checkLengh = BitConverter.ToInt32(file.file_end, 0);
                    if (checkLengh == file.file_data.Length)
                    {
                        System.Diagnostics.Debug.WriteLine("File " + file.index_position + " matches the start pointer size!");
                    }
                    else
                    {
                        if (Program.MainWindowCore.checkBoxPointer.Checked)
                        {
                            System.Diagnostics.Debug.WriteLine("File " + file.index_position + " DONT MATCHES the start pointer size!");
                            int newPos = 0;

                            if (checkLengh > file.file_data.Length)
                            {
                                newPos = checkLengh - file.file_data.Length;
                            }

                            if (checkLengh < file.file_data.Length)
                            {
                                newPos = file.file_data.Length - checkLengh;
                            }

                            int actInd = 1;
                            foreach (var recalcFile in DataCollector.Files)
                            {
                                if (actInd >= file.index_position)
                                {

                                    int pointerMergeIntX = BitConverter.ToInt32(recalcFile.file_begin, 0) + newPos;
                                    byte[] pointerMergeX = BitConverter.GetBytes(pointerMergeIntX);

                                    int pointerMergeIntY = BitConverter.ToInt32(recalcFile.file_end, 0) + newPos;
                                    byte[] pointerMergeY = BitConverter.GetBytes(pointerMergeIntY);

                                    recalcFile.file_begin = pointerMergeX;
                                    recalcFile.file_end = pointerMergeY;

                                }
                                actInd++;
                            }

                            //TODO: Pointer recalc... kill me

                            /* Recalc logic
                             * 1. Calculate the diffrence between old and new
                             * 2. foreach loop
                             * 3. add pointer diffrence to every datacontainer after the changed file
                             */
                        }
                        else
                        {
                            MessageBox.Show("Warning! Pointer position changed! File will crash the game!\n\r\n\rUse Pointer recalc or dont modify the size!");
                        }

                    }
                }

                foreach (var file in DataCollector.Files)
                {
                    writer.Write(file.file_begin);
                    writer.Write(file.file_end);
                    writer.Write(file.file_name_pointer);
                    writer.Write(file.file_unknownhash);
                }

                writer.Write(DataCollector.MetaBlock);

                foreach (var file in DataCollector.Files)
                {
                    writer.Write(Encoding.ASCII.GetBytes(file.file_name));
                    writer.BaseStream.WriteByte(0x00);
                }

                //Data Stream write process
                foreach (var file in DataCollector.Files)
                {
                    /*
                     * 1. read start pointer
                     * 2. write zeros from actual seek until the pointer position is reached
                     * 3. write data array to file
                     */
                    while (true)
                    {
                        int filePointer = BitConverter.ToInt32(file.file_begin, 0);
                        long actualPosBef = writer.BaseStream.Position;

                        if (actualPosBef == filePointer) break;

                        writer.BaseStream.WriteByte(0x00);
                    }

                    writer.Write(file.file_data);

                }

                int sF = 0;
                //Add savespace
                while (true)
                {
                    if (sF > (int)Program.MainWindowCore.numericUpDownOffset.Value) break;
                    writer.BaseStream.WriteByte(0x00);
                    sF++;
                }

            }
        }

        public static void UpdateGUI()
        {

            foreach (var item in Program.MainWindowCore.listViewMain.Items)
            {
                Program.MainWindowCore.listViewMain.Items.Remove((ListViewItem)item);
            }

            foreach (var item in DataCollector.Files)
            {
                // Add the pet to our listview
                ListViewItem lvi = new ListViewItem();

                lvi.Text = item.index_position.ToString();

                lvi.SubItems.Add("0x" + (BitConverter.ToString(item.file_begin).Replace("-", "")));
                lvi.SubItems.Add("0x" + (BitConverter.ToString(item.file_size).Replace("-", "")));
                lvi.SubItems.Add("0x" + (BitConverter.ToString(item.file_end).Replace("-", "")));
                lvi.SubItems.Add("0x" + (BitConverter.ToString(item.file_unknownhash).Replace("-", "")));

                lvi.SubItems.Add(item.file_data.Length.ToString());
                lvi.SubItems.Add(item.file_name.ToString());
                lvi.SubItems.Add("0x" + (BitConverter.ToString(item.file_name_pointer).Replace("-", "")));
                lvi.SubItems.Add(item.file_modified.ToString());

                Program.MainWindowCore.listViewMain.Items.Add(lvi);

            }

            Program.MainWindowCore.listViewMain.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private static string Reverse(string text)
        {
            if (text == null) return null;

            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        private static void clearVFS()
        {
            DataCollector.Files = new List<DataEntry>();
            DataCollector.MetaBlock = null;
        }

    }
}
