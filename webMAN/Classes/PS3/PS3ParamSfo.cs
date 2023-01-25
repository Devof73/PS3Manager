
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace PSS3.Classes.PS3
{
    public class PS3ParamSfo
    {
        protected PS3TitleId ID;
        protected Bitmap ICON0 = null;
        protected Bitmap PIC1 = null;

        public static readonly PS3ParamSfo Null = new PS3ParamSfo();
        protected PS3TitleId Id { get { return ID; } }
        public Bitmap Icon0 { get { return ICON0; } }
        public Bitmap Pic0 { get { return PIC1; } }
        public byte[] AccountId { get; protected set; }
        public string Title { get => (ID ?? PS3TitleId.None).Name ?? "_null"; }
        public UInt32? Attributte { get; protected set; }
        public UInt32? Bootable { get; protected set; }
        public string ContentId { get; protected set; }
        public string TitleId { get; protected set; }
        public Dictionary<string, object> Values { get; protected set; }


        private string[] _invalid = new string[] {
            "\0","\u0000","\u0001","\u0002","\u0003","\u0004","\u0005","\u0006","\u0007","\u0008", "\u0009","\u0010",
            "\u0011","\u0012","\u0013","\u0014","\u0015","\u0016","\u0017","\u0018","\u0019","\u0020",
            "\u0021",
        };

        public static PS3ParamSfo FromFile(Ps3File e)
        {

            return ParseByPath(e.AccessUrl);
        }
        public static PS3ParamSfo FromData(byte[] e, Bitmap icon0 = null, Bitmap pic0 = null, Dictionary<string, object> ParsedValues = null)
        {
            if (e == null) return new PS3ParamSfo() { ICON0 = icon0, PIC1 = pic0, Values = ParsedValues };
            return ParseFromData(e, icon0, pic0);
        }
        public static PS3ParamSfo FromLocal(string path)
        {
            return ParseByPath(path);
        }
        protected PS3ParamSfo()
        {
            ID = null;
            ICON0 = null;
            PIC1 = null;
            TitleId = null;

        }
        protected PS3ParamSfo(PS3TitleId ID, Bitmap Icon0, Bitmap Pic0, byte[] AccountId, UInt32 attributte, UInt32 bootable, string contentId, string titleid, Dictionary<string, object> values)
        {
            this.ID = ID;
            ICON0 = Icon0;
            PIC1 = Pic0;
            this.AccountId = AccountId;
            Attributte = attributte;
            Bootable = bootable;
            ContentId = contentId;
            TitleId = titleid;
            Values = values;
        }

        protected static PS3ParamSfo ParseOnlineParamSfo(string ftpfilename, byte[] paramdata = null, Bitmap icon0 = null, Bitmap pic0 = null)
        {
            var root = ftpfilename.Substring(0, ftpfilename.LastIndexOf('/'));
            Misc.Log(root);
            var ICON0 = icon0 ?? Misc.DownloadBitmap(root + "/ICON0.PNG");
            var PIC0 = pic0 ?? Misc.DownloadBitmap(root + "/PIC1.PNG");
            var tid = PS3TitleId.None;
            var data = paramdata ?? new WebClient().DownloadData(root + "/PARAM.SFO");
            var datadic = PS3SFO.ReadSfo(data);
            var TitleId = (string)datadic["TITLE_ID"];
            var AccountId = (byte[])datadic["ACCOUNT_ID"];
            var Title = (string)datadic["TITLE"];
            var Attribute = (int)datadic["ATTRIBUTE"];
            var bootable = (int)datadic["BOOTABLE"];
            var contentid = (string)datadic["CONTENT_ID"];
            tid.Name = Title;
            tid.Region = TitleId;
            tid.RegionCode = TitleId.Substring(4);
            var r = new PS3ParamSfo(tid, ICON0, PIC0, AccountId, (UInt32)Attribute, (UInt32)bootable, contentid, TitleId, datadic) { };
            r.Values = datadic;
            return r;
        }
        private static PS3ParamSfo ParseFromData(byte[] paramdata = null, Bitmap icon0 = null, Bitmap pic0 = null)
        {

            var ICON0 = icon0;
            var PIC0 = pic0;
            var tid = PS3TitleId.None;
            var data = paramdata;
            var datadic = PS3SFO.ReadSfo(data);
            if (datadic == null) return Null;
            datadic.TryGetValue("TITLE_ID", out object TitleId);
            datadic.TryGetValue("ACCOUNT_ID", out object AccountId);
            datadic.TryGetValue("TITLE", out object Title);
            datadic.TryGetValue("ATTRIBUTE", out object Attribute);
            datadic.TryGetValue("BOOTABLE", out object bootable);
            datadic.TryGetValue("CONTENT_ID", out object contentid);
            tid.Name = (string)Title;
            tid.Region = (string)TitleId;
            tid.RegionCode = ((string)TitleId)?.Substring(4);
            var at = Attribute ?? 0;
            var boot = bootable ?? 0;
            var cid = contentid ?? "unkwnown";
            var ttid = TitleId ?? "unkwnown";
            var acid = AccountId ?? new byte[] { 0, 0 };

            uint.TryParse(at.ToString(), out uint _at);
            uint.TryParse(boot.ToString(), out uint _boot);
            try
            {
                return new PS3ParamSfo(tid, ICON0, PIC0, acid as byte[], _at, _boot, (string)cid, (string)ttid, datadic);
            }
            catch
            {
                return new PS3ParamSfo()
                {
                    AccountId = acid as byte[],
                    Bootable = _boot,
                    ContentId = (string)cid,
                    TitleId = (string)ttid,
                    Attributte = _at,
                    ID = new PS3TitleId(int.Parse(TitleId.ToString().Substring(4)), TitleId.ToString().Substring(0, 4), (string)Title, "GAME", "", ""),
                    ICON0 = ICON0,
                    PIC1 = PIC0,
                    Values = datadic,
                };
            }
        }
        private static void CwObject(object obj)
        {
            if (obj == null) return;
            Console.WriteLine(obj?.GetType().Name);
        }
        private static PS3ParamSfo ParseByPath(string path)
        {
            var icop = path + "\\ICON0.PNG";
            var pic1p = path + "\\PIC1.PNG";
            if (File.Exists(path + "\\PARAM.SFO"))
            {
                var ICON0 = File.Exists(icop) ? (Bitmap)Bitmap.FromFile(icop) : Properties.Resources.ps;
                var PIC0 = File.Exists(pic1p) ? (Bitmap)Bitmap.FromFile(icop) : Properties.Resources.ps;
                var tid = PS3TitleId.None;
                var data = File.ReadAllBytes(path + "\\PARAM.SFO");
                var datadic = PS3SFO.ReadSfo(data);
                object TitleId; datadic.TryGetValue("TITLE_ID", out TitleId);
                object AccountId; datadic.TryGetValue("ACCOUNT_ID", out AccountId);
                object Title; datadic.TryGetValue("TITLE", out Title);
                object Attribute; datadic.TryGetValue("ATTRIBUTE", out Attribute);
                object bootable; datadic.TryGetValue("BOOTABLE", out bootable);
                datadic.TryGetValue("CONTENT_ID", out object contentid);
                tid.Name = (string)Title;
                tid.Region = (string)TitleId;
                tid.RegionCode = ((string)TitleId).Substring(4);
                var at = Attribute ?? UInt32.MinValue;
                var boot = bootable ?? UInt32.MinValue;
                var cid = contentid ?? "unkwnown";
                var ttid = TitleId ?? "unkwnown";
                var acid = AccountId ?? new byte[] { 0, 0 };

                return new PS3ParamSfo(tid, ICON0, PIC0, acid as byte[], (UInt32)at, (UInt32)boot, (string)cid, (string)ttid, datadic);
            }
            else return PS3ParamSfo.Null;
        }

        private string RangeFrom(string value, in int count) => value.Substring(0, count);
    }
}
