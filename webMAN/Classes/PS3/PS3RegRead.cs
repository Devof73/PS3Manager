using PSS3.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xRegistryEditor.IO;

namespace PSS3.Classes.PS3
{
    public class PS3RegRead
    {
        public List<SettingEntry> SettingEntries { get; private set; }
        public List<SettingDataEntry> DataEntries { get; private set; }

        public SettingEntry ByName(string name)
        {
            return SettingEntries.TakeWhile((s, e) => s.Setting == name).FirstOrDefault();
        }

        X360IO IO;
        public PS3RegRead() { }
        public void Load(string filename)
        {
            IO = new X360IO(filename, FileMode.Open, true);
            uint magic = IO.Reader.ReadUInt32();
            if (magic != 0xBCADADBC)
                return;
            IO.Stream.Position = 0x10;
            SettingEntries = new List<SettingEntry>();
            DataEntries = new List<SettingDataEntry>();
            while (true)
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
                    if (!(entry.Flags == 0xAABB && entry.FileNameOffset == 0xCCDD && entry.Checksum == 0xEE00))
                        DataEntries.Add(entry);
                    else
                        break;
                }
            }
            foreach (SettingDataEntry entry in DataEntries)
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
                switch (Type)
                {
                    case 0:
                        return xRegistryEditor.Main.BytesToHex((byte[])Value);
                    case 1:
                        return ((int)Value).ToString("X" + (Length * 2).ToString());
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
            switch (Type)
            {
                case 1:
                    switch (Length)
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
}


