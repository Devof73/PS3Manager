using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Logging.Abstractions;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace PSS3.Classes.PS3
{
    public class Ps3SaveData : PS3ParamSfo
    {
        public string Url { get; private set; }
        public PS3ParamSfo Param { get; private set; }
        public static readonly Ps3SaveData None = new Ps3SaveData();
        public PS3System Owner { get; private set; }
        protected Ps3SaveData(string senderUrl, PS3ParamSfo Param, Bitmap Icon0)
        {
            this.ICON0 = Icon0;
            this.PIC1 = null;
            this.Url = senderUrl;
            this.Param = Param;

        }
        /// <summary>
        /// Spawns a new PS3PARAMSFO with not implemented values.
        /// </summary>
        protected Ps3SaveData() : base()
        {
            this.PIC1 = null;
            Param = Null;
            Values = null;
            Url = null;
            this.AccountId = null;
            this.ICON0 = null;
            this.ContentId = null;
            this.Attributte = null;
            this.TitleId = null;
            this.Bootable = null;


        }
        public static Ps3SaveData[] FromSystem(PS3System sys, int userid, EventHandler<Ps3SaveData> OnSaveAdded)
        {
            var lst = new List<Ps3SaveData>();
            var URI = $"ftp://{sys.IP}/dev_hdd0/home/{PS3System.FormatUserId(userid)}/savedata/";
            var containers = Misc.GetDirectories(URI
                );
            if (containers.Length > 0)
            {
                int i = 0;
                foreach (var folder in containers)
                {
                    if (folder.Length > 4)
                    {
                        var perc = (i * 100) / containers.Length;
                        lst.Add(FromSavePath(sys, URI + folder, OnSaveAdded));
                        Misc.Log($"Parsing savedata... {perc}%");
                    }
                    i++;
                }
            }
            else throw new InvalidDataException("No data in directory.");
            return lst.ToArray();
        }

        public static Ps3SaveData FromSavePath(PS3System e, string url, EventHandler<Ps3SaveData> onSucess)
        {
            var icon = url + "/ICON0.PNG";
            var param = url + "/PARAM.SFO";
            var flag = Misc.UrlFileExists(param);
            var icond = Misc.UrlFileExists(icon) ? Misc.DownloadBitmap(icon) : null;
            var data = Misc.UrlFileExists(param) ? Misc.DownloadData(param.Replace("ftp", "http")) : null;


            var basee = FromData(data, icond, null);
            if (basee != PS3ParamSfo.Null)
            {
                var f = new Ps3SaveData(url, basee, icond) { Values = basee.Values, Owner = e };
                Console.WriteLine(f.ToString());
                onSucess?.Invoke(null, f);
                return f;
            }
            else
            {
                return Ps3SaveData.None;
            }
        }
        public override string ToString()
        {
            return $"ID = {this.Id?.ToString()} CID : {this.ContentId ?? "NO"} VALUES: {this.Values?.Count}";
        }

    }
}
