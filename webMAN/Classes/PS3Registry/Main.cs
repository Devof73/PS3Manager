using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xRegistryEditor.IO;

namespace xRegistryEditor
{

    public partial class Main : Form
    {
        public X360IO IO;
        private ListViewColumnSorter lvwColumnSorter;
        private bool FileLoaded;
        public List<SettingDataEntry> DataEntries;
        public List<SettingEntry> SettingEntries;
        public ListViewItem SelectedEntry;
        public static string BytesToHex(byte[] bytes)
        {
            StringBuilder hexString = new StringBuilder(bytes.Length);
            for (int i = 0; i < bytes.Length; i++)
            {
                hexString.Append(bytes[i].ToString("X2"));
            }
            return hexString.ToString();
        }
        public static byte[] HexToBytes(string hex)
        {
            return Enumerable.Range(0, hex.Length).
                   Where(x => 0 == x % 2).
                   Select(x => Convert.ToByte(hex.Substring(x, 2), 16)).
                   ToArray();
        }
        public Main()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            lvEntries.ListViewItemSorter = lvwColumnSorter;
            ClearSelected();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
                                     {
                                         Filter = "PS3 Registry files (*.sys)|*.sys|All Files (*.*)|*.*",
                                         Multiselect = false
                                     };
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Trim().Length > 0)
            {
                closeToolStripMenuItem_Click(null, null);
                IO = new X360IO(ofd.FileName, FileMode.Open, true);
                uint magic = IO.Reader.ReadUInt32();
                if (magic != 0xBCADADBC)
                    return;
                IO.Stream.Position = 0x10;
                SettingEntries = new List<SettingEntry>();
                DataEntries = new List<SettingDataEntry>();
                lvEntries.Items.Clear();
                while(true)
                {
                    SettingEntry entry = new SettingEntry();
                    if (!entry.Load(IO))
                        break;
                    SettingEntries.Add(entry);
                }
                IO.Stream.Position = 0xFFF0;
                uint check = IO.Reader.ReadUInt16();
                if (check == 0x4D26)
                {
                    // data
                    while (true)
                    {
                        SettingDataEntry entry = new SettingDataEntry();
                        entry.Load(IO);
                        if(!(entry.Flags == 0xAABB && entry.FileNameOffset == 0xCCDD && entry.Checksum == 0xEE00))
                            DataEntries.Add(entry);
                        else
                            break;
                    }
                }
                foreach(SettingDataEntry entry in DataEntries)
                {
                    if (entry.Flags != 0x7A)
                    {
                        SettingEntry ent = SettingEntries.Find(sec => sec.IsEntryOffset(entry.FileNameOffset + 0x10));
                        if (ent == null)
                        {
                            MessageBox.Show("failed to load setting");
                            break;
                        }
                        ent.DataExists = true;
                        entry.FileNameEntry = ent;
                    }
                }
                FileLoaded = true;
                LoadEntries();
            }
        }

        public void LoadEntries()
        {
            if (!FileLoaded)
                return;
            ClearSelected();
            lvEntries.Items.Clear();
            foreach (SettingDataEntry entry in DataEntries)
            {
                if (entry.Flags != 0x7A)
                {
                    ListViewItem item = new ListViewItem("0x" + entry.Checksum.ToString("X4"));
                    item.SubItems.Add(entry.FileNameEntry.Setting);
                    item.SubItems.Add(entry.ValueString);
                    item.SubItems.Add(entry.FileNameEntry.Value.ToString());
                    item.SubItems.Add("0x" + entry.Flags.ToString("X4"));
                    item.Tag = entry;
                    //if (entry.FileNameEntry.Setting.Contains("debug") || entry.FileNameEntry.Setting.Contains("qa"))
                    lvEntries.Items.Add(item);
                }
            }
        }
        private void ClearSelected()
        {
            SelectedEntry = null;
            txtID.Text = "";
            txtValue.Text = "";
            txtFlags.Text = "";
            cmdSave.Enabled = false;
            txtSetting.Text = "";
        }
        private void lvEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FileLoaded)
            {
                ClearSelected();
                return;
            }
            if (lvEntries.SelectedItems == null)
            {
                ClearSelected();
                return;
            }
            if (lvEntries.SelectedItems.Count == 0)
            {
                ClearSelected();
                return;
            }
            SelectedEntry = lvEntries.SelectedItems[0];
            SettingDataEntry entry = (SettingDataEntry) SelectedEntry.Tag;
            txtID.Text = entry.Checksum.ToString("X4");
            txtSetting.Text = entry.FileNameEntry.Setting;
            txtFlags.Text = entry.Flags.ToString("X4");
            cmdSave.Enabled = true;
            txtValue.Text = entry.ValueString;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!FileLoaded)
            {
                ClearSelected();
                return;
            }
            if(SelectedEntry == null)
            {
                ClearSelected();
                return;
            }
            SettingDataEntry entry = (SettingDataEntry)SelectedEntry.Tag;
            entry.Checksum = UInt16.Parse(txtID.Text, NumberStyles.HexNumber);
            switch (entry.Type)
            {
                case 1:
                    entry.Value = Int32.Parse(txtValue.Text, NumberStyles.HexNumber);
                    break;
                case 2:
                    entry.Value = Encoding.ASCII.GetBytes(txtValue.Text);
                    break;
                default:
                    entry.Value = HexToBytes(txtValue.Text);
                    break;
            }
            entry.Flags = UInt16.Parse(txtFlags.Text, NumberStyles.HexNumber);
            entry.Modified = true;
            //entry.Save(IO);
            SelectedEntry.Text = "0x" + entry.Checksum.ToString("X4");
            SelectedEntry.SubItems[1].Text = entry.FileNameEntry.Setting;
            SelectedEntry.SubItems[2].Text = txtValue.Text;
            SelectedEntry.SubItems[4].Text = "0x" + txtFlags.Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FileLoaded)
                return;
            IO.Stream.Position = 0xFFF0;
            IO.Writer.Write(new byte[0x30010]);
            IO.Stream.Position = 0xFFF0;
            IO.Writer.Write((ushort)0x4D26);
            foreach(SettingDataEntry entry in DataEntries)
            {
                entry.Save(IO);
            }
            IO.Writer.Write((byte)0xAA);
            IO.Writer.Write((byte)0xBB);
            IO.Writer.Write((byte)0xCC);
            IO.Writer.Write((byte)0xDD);
            IO.Writer.Write((byte)0xEE);
            IO.Stream.Flush();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By stoker25 - http://stoker25.com / http://aversionmedia.org\r\nDeveloped at http://PSX-SCENE.com");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!FileLoaded)
            //    return;
            DataEntries = new List<SettingDataEntry>();
            SettingEntries = new List<SettingEntry>();
            lvEntries.Items.Clear();
            ClearSelected();
            try
            {
                IO.Close();
            } catch
            {
            }
            FileLoaded = false;
        }

        private void addSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FileLoaded)
                return;
            List<SettingEntry> entries = SettingEntries.FindAll(sec => !sec.DataExists && sec.Value != 3);
            SettingDialog dia = new SettingDialog(entries, this);
            dia.ShowDialog();
        }
        private void exportToWikitextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FileLoaded)
                return;
            string text = "{| border=\"1\"\r\n|-\r\n! Setting\r\n! Usage\r\n! Values";
            List<string> usershit = new List<string>();
            foreach (SettingDataEntry entry in DataEntries)
            {
                if (entry.Flags != 0x7A)
                {
                    string name = entry.FileNameEntry.Setting;
                    if (name.Length > 22 && name.Substring(0, 21) == "/setting/user/0000000")
                    {
                        if (entry.Type == 2 && Encoding.ASCII.GetString((byte[])entry.Value).Trim().Length == 0)
                            continue;
                        string shortname = name.Substring(22, name.Length - 22);
                        if (usershit.Find(sec => sec == shortname) == null)
                            usershit.Add(shortname);
                        else
                            continue;
                    }

                    text += "\r\n|-\r\n| " + entry.FileNameEntry.Setting + "\r\n| ?\r\n| ";
                    text += entry.ValueString;
                }
            }
            text += "\r\n|}";
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, text);
        }

        private void exportToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FileLoaded)
                return;
            string text = "xRegistry.sys contents - dumped by xRegistry.sys Editor\r\nBy stoker25 - http://stoker25.com\r\n----------------------\r\n";
            foreach (SettingDataEntry entry in DataEntries)
            {
                if (entry.Flags != 0x7A)
                {
                    text += "\r\nSetting: " + entry.FileNameEntry.Setting;
                    text += "\r\n\tData Checksum: " + entry.Checksum;
                    text += "\r\n\tData Flags: " + entry.Flags;
                    text += "\r\n\tData Offset: " + entry.Offset;
                    text += "\r\n\tData Header Offset: " + entry.FileNameOffset + " (plus 16)";
                    text += "\r\n\tData Type: " + entry.Type;
                    text += "\r\n\tData Terminator: " + entry.Terminator;
                    text += "\r\n\tData Length: " + entry.Length;
                    text += "\r\n\tData Value: " + entry.ValueString;
                    text += "\r\n\tHeader Offset: " + entry.FileNameEntry.Offset;
                    text += "\r\n\tHeader Value: " + entry.FileNameEntry.Value + "\r\n";
                }
            }
            text += "\r\n----------------------\r\nData Entry Count: " + DataEntries.Count + " (minus 1)";
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, text);
        }

        private void halpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Columns can be sorted, just click on one\r\nValues can be made bigger than original size (for strings anyway)\r\nThe value box is in hex for integer and binary entry types\r\nAnyone who wants to add more can feel free, just post the modifications somewhere.");
        }

        private void lvEntries_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvEntries.Sort();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
    public class SettingEntry
    {
        public uint ID;
        public byte Value;
        public string Setting;
        public long Offset;
        public long EndOffset;
        public bool DataExists;

        public bool Load(X360IO io)
        {
            Offset = io.Stream.Position;
            ID = io.Reader.ReadUInt32();
            Value = io.Reader.ReadByte();
            if (Value == 0xEE)// 0xAABBCCDDEE
                return false;
            Setting = io.Reader.ReadNullTerminatedAsciiString();
            EndOffset = io.Stream.Position;
            return true;
        }

        public override string ToString()
        {
            return Setting;
        }

        public bool IsEntryOffset(long offset)
        {
            return Offset <= offset && EndOffset > offset;
        }

        public void Save(X360IO io)
        {
            io.Stream.Position = Offset;
            io.Writer.Write(ID);
            io.Writer.Write(Value);
            io.Writer.WriteNullTerminatedAsciiString(Setting);
        }
    }
    public class SettingDataEntry
    {
        public ushort Checksum;
        public ushort Length;
        public ushort Flags;
        public byte Type; // 1 = integer, 2 = string
        public object Value;
        public byte Terminator;
        public long Offset;
        public ushort FileNameOffset;
        public SettingEntry FileNameEntry;
        public bool Modified;

        public string ValueString
        {
            get
            {
                switch(Type)
                {
                    case 0:
                        return Main.BytesToHex((byte[]) Value);
                    case 1:
                        return ((int) Value).ToString("X" + (Length * 2).ToString());
                    case 2:
                        return Encoding.ASCII.GetString((byte[])Value).Trim('\0');
                    default:
                        return String.Empty;
                }
            }
        }

        public bool Load(X360IO io)
        {
            Offset = io.Stream.Position;
            Flags = io.Reader.ReadUInt16();
            FileNameOffset = io.Reader.ReadUInt16();
            Checksum = io.Reader.ReadUInt16();
            Length = io.Reader.ReadUInt16();
            Type = io.Reader.ReadByte();
            switch(Type)
            {
                case 1:
                    switch(Length)
                    {
                        case 2:
                            Value = io.Reader.ReadInt16();
                            break;
                        case 4:
                            Value = io.Reader.ReadInt32();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    Value = io.Reader.ReadBytes(Length);
                    break;
            }    
            io.Stream.Position = Offset + 9 + Length;
            Terminator = io.Reader.ReadByte();
            return true;
        }
        public bool Save(X360IO io)
        {
            Offset = io.Stream.Position;
            io.Writer.Write(Flags);
            io.Writer.Write(FileNameOffset);
            io.Writer.Write(Checksum);
            if ((Type == 2 || Type == 0) && ((byte[])Value).Length > 0 && (Modified))
            {
                if (((byte[])Value).Length > Length)
                    Length = (ushort)(((byte[])Value).Length);
            }
            io.Writer.Write(Length);
            io.Writer.Write(Type);
            switch (Type)
            {
                case 1:
                    switch (Length)
                    {
                        case 2:
                            io.Writer.Write((short)Value);
                            break;
                        case 4:
                            io.Writer.Write((int)Value);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    io.Writer.Write((byte[])Value);
                    break;
            }
            io.Stream.Position = Offset + 9 + Length;
            io.Writer.Write(Terminator);
            return true;
        }
    }
    /// <summary>
    /// This class is an implementation of the 'IComparer' interface.
    /// </summary>
    public class ListViewColumnSorter : IComparer
    {
        /// <summary>
        /// Specifies the column to be sorted
        /// </summary>
        private int ColumnToSort;
        /// <summary>
        /// Specifies the order in which to sort (i.e. 'Ascending').
        /// </summary>
        private SortOrder OrderOfSort;
        /// <summary>
        /// Case insensitive comparer object
        /// </summary>
        private CaseInsensitiveComparer ObjectCompare;

        /// <summary>
        /// Class constructor.  Initializes various elements
        /// </summary>
        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            ColumnToSort = 0;

            // Initialize the sort order to 'none'
            OrderOfSort = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new CaseInsensitiveComparer();
        }

        /// <summary>
        /// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            // Compare the two items
            compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);

            // Calculate correct return value based on object comparison
            if (OrderOfSort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }

        /// <summary>
        /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        /// </summary>
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }

        /// <summary>
        /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        /// </summary>
        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }

    }
}
