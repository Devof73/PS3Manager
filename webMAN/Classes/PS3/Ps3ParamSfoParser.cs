
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BasicDataTypes;

// A Sfo Parser Written by SilicaAndPina
// Because all the others are overly-complicated for no reason!
// MIT Licensed.

namespace PSS3
{

    class PS3SFO
    {
        const int PSF_TYPE_BIN = 0;
        const int PSF_TYPE_STR = 2;
        const int PSF_TYPE_VAL = 4;
        public static Dictionary<String, Object> ReadSfo(Stream Sfo)
        {
            Dictionary<String, Object> SfoValues = new Dictionary<String, Object>();

            // Read Sfo Header
            UInt32 Magic = DataUtils.ReadUInt32(Sfo);
            UInt32 Version = DataUtils.ReadUInt32(Sfo);
            UInt32 KeyOffset = DataUtils.ReadUInt32(Sfo);
            UInt32 ValueOffset = DataUtils.ReadUInt32(Sfo);
            UInt32 Count = DataUtils.ReadUInt32(Sfo);

            if (Magic == 0x46535000) //\x00PSF
            {
                for (int i = 0; i < Count; i++)
                {
                    UInt16 NameOffset = DataUtils.ReadUInt16(Sfo);
                    Byte Alignment = (Byte)Sfo.ReadByte();
                    Byte Type = (Byte)Sfo.ReadByte();
                    UInt32 ValueSize = DataUtils.ReadUInt32(Sfo);
                    UInt32 TotalSize = DataUtils.ReadUInt32(Sfo);
                    UInt32 DataOffset = DataUtils.ReadUInt32(Sfo);

                    int KeyLocation = Convert.ToInt32(KeyOffset + NameOffset);
                    string KeyName = DataUtils.ReadStringAt(Sfo, KeyLocation);
                    int ValueLocation = Convert.ToInt32(ValueOffset + DataOffset);
                    object Value = "Unknown Type";


                    switch (Type)
                    {
                        case PSF_TYPE_STR:
                            Value = DataUtils.ReadStringAt(Sfo, ValueLocation);
                            break;

                        case PSF_TYPE_VAL:
                            Value = DataUtils.ReadUint32At(Sfo, ValueLocation + i);
                            break;

                        case PSF_TYPE_BIN:
                            Value = DataUtils.ReadBytesAt(Sfo, ValueLocation + i, Convert.ToInt32(ValueSize));
                            break;
                    }

                    SfoValues[KeyName] = Value;
                }

            }
            else
            {
                return null;
            }

            return SfoValues;
        }
        public static Dictionary<String, Object> ReadSfo(byte[] Sfo)
        {
            MemoryStream SfoStream = new MemoryStream(Sfo);
            return ReadSfo(SfoStream);
        }
    }
}


namespace BasicDataTypes
{
    class DataUtils
    {
        public static void CopyString(byte[] str, String Text, int Index)
        {
            byte[] TextBytes = Encoding.UTF8.GetBytes(Text);
            Array.ConstrainedCopy(TextBytes, 0, str, Index, TextBytes.Length);
        }

        public static void CopyInt32(byte[] str, Int32 Value, int Index)
        {
            byte[] ValueBytes = BitConverter.GetBytes(Value);
            Array.ConstrainedCopy(ValueBytes, 0, str, Index, ValueBytes.Length);
        }
        public static void CopyInt32BE(byte[] str, Int32 Value, int Index)
        {
            byte[] ValueBytes = BitConverter.GetBytes(Value);
            byte[] ValueBytesBE = ValueBytes.Reverse().ToArray();
            Array.ConstrainedCopy(ValueBytesBE, 0, str, Index, ValueBytesBE.Length);
        }

        // Read From Streams
        public static UInt32 ReadUInt32(Stream Str)
        {
            byte[] IntBytes = new byte[0x4];
            Str.Read(IntBytes, 0x00, IntBytes.Length);
            return BitConverter.ToUInt32(IntBytes, 0x00);
        }
        public static UInt32 ReadInt32(Stream Str)
        {
            byte[] IntBytes = new byte[0x4];
            Str.Read(IntBytes, 0x00, IntBytes.Length);
            return BitConverter.ToUInt32(IntBytes, 0x00);
        }
        public static UInt64 ReadUInt64(Stream Str)
        {
            byte[] IntBytes = new byte[0x8];
            Str.Read(IntBytes, 0x00, IntBytes.Length);
            return BitConverter.ToUInt64(IntBytes, 0x00);
        }
        public static Int64 ReadInt64(Stream Str)
        {
            byte[] IntBytes = new byte[0x8];
            Str.Read(IntBytes, 0x00, IntBytes.Length);
            return BitConverter.ToInt64(IntBytes, 0x00);
        }
        public static UInt16 ReadUInt16(Stream Str)
        {
            byte[] IntBytes = new byte[0x2];
            Str.Read(IntBytes, 0x00, IntBytes.Length);
            return BitConverter.ToUInt16(IntBytes, 0x00);
        }
        public static Int16 ReadInt16(Stream Str)
        {
            byte[] IntBytes = new byte[0x2];
            Str.Read(IntBytes, 0x00, IntBytes.Length);
            return BitConverter.ToInt16(IntBytes, 0x00);
        }

        public static UInt32 ReadUint32At(Stream Str, int location)
        {
            long oldPos = Str.Position;
            Str.Seek(location, SeekOrigin.Begin);
            UInt32 outp = ReadUInt32(Str);
            Str.Seek(oldPos, SeekOrigin.Begin);
            return outp;
        }

        public static byte[] ReadBytesAt(Stream Str, int location, int length)
        {
            long oldPos = Str.Position;
            Str.Seek(location, SeekOrigin.Begin);
            byte[] work_buf = new byte[length];
            Str.Read(work_buf, 0x0, work_buf.Length);
            Str.Seek(oldPos, SeekOrigin.Begin);
            return work_buf;
        }

        public static string ReadStringAt(Stream Str, int location)
        {
            long oldPos = Str.Position;
            Str.Seek(location, SeekOrigin.Begin);
            string outp = ReadString(Str);
            Str.Seek(oldPos, SeekOrigin.Begin);
            return outp;
        }
        public static string ReadString(Stream Str)
        {
            MemoryStream ms = new MemoryStream();

            while (true)
            {
                byte c = (byte)Str.ReadByte();
                if (c == 0)
                    break;
                ms.WriteByte(c);
            }
            ms.Seek(0x00, SeekOrigin.Begin);
            string outp = Encoding.UTF8.GetString(ms.ToArray());
            ms.Dispose();
            return outp;
        }

        // Write To Streams

        public static void WriteUInt32(Stream Str, UInt32 Numb)
        {
            byte[] IntBytes = BitConverter.GetBytes(Numb);
            Str.Write(IntBytes, 0x00, IntBytes.Length);
        }
        public static void WriteInt32(Stream Str, Int32 Numb)
        {
            byte[] IntBytes = BitConverter.GetBytes(Numb);
            Str.Write(IntBytes, 0x00, IntBytes.Length);
        }
        public static void WriteUInt64(Stream dst, UInt64 value)
        {
            byte[] ValueBytes = BitConverter.GetBytes(value);
            dst.Write(ValueBytes, 0x00, 0x8);
        }
        public static void WriteInt64(Stream dst, Int64 value)
        {
            byte[] ValueBytes = BitConverter.GetBytes(value);
            dst.Write(ValueBytes, 0x00, 0x8);
        }
        public static void WriteUInt16(Stream dst, UInt16 value)
        {
            byte[] ValueBytes = BitConverter.GetBytes(value);
            dst.Write(ValueBytes, 0x00, 0x2);
        }
        public static void WriteInt16(Stream dst, Int16 value)
        {
            byte[] ValueBytes = BitConverter.GetBytes(value);
            dst.Write(ValueBytes, 0x00, 0x2);
        }

        public static void WriteInt32BE(Stream Str, Int32 Numb)
        {
            byte[] IntBytes = BitConverter.GetBytes(Numb);
            byte[] IntBytesBE = IntBytes.Reverse().ToArray();
            Str.Write(IntBytesBE, 0x00, IntBytesBE.Length);
        }
        public static void WriteString(Stream Str, String Text, int len = -1)
        {
            if (len < 0)
            {
                len = Text.Length;
            }

            byte[] TextBytes = Encoding.UTF8.GetBytes(Text);
            Str.Write(TextBytes, 0x00, TextBytes.Length);
        }

    }
}