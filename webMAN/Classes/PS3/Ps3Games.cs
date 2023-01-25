using Guna.UI2.WinForms.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace PSS3.Classes.PS3
{
    public class Ps3Games
    {
        private const string URL_FORMAT = "http://{0}//dev_hdd0/game";
        public static readonly Ps3Games Empty = new Ps3Games(new PS3ParamSfo[1] { PS3ParamSfo.Null });
        public PS3ParamSfo[] TitlesSfo { get; private set; }
        private Ps3Games(PS3ParamSfo[] sfos)
        {
            TitlesSfo = sfos;
        }
        public static Ps3Games FromSystem(PS3System e)
        {
            List<PS3ParamSfo> sfos = new List<PS3ParamSfo>();
            var PATH = e.AccessUrl + "/dev_hdd0/game";
            var contain = Misc.GetDirectories(PATH);
            Thread.Sleep(10);
            int ii = 0;
            foreach (var item in contain)
            {
                if (item.Length > 2 & !Path.HasExtension(item))
                {
                    var perc = ii * 100 / contain.Length;
                    Misc.Log("Loading game: " + item + "... " + perc + "%");
                    sfos.Add(ParseFromGamePath(e, PATH + "/" + item));

                }
                ii++;
            }
            return new Ps3Games(sfos.ToArray());
        }

        private static PS3ParamSfo ParseFromGamePath(in PS3System sys, string path)
        {
            try
            {
                var gm = Path.GetFileName(path);
                var dir = Application.StartupPath + "\\USRDAT\\";
                var usrdir = dir + sys.SystemName + "\\";
                var dpath = usrdir + "game\\" + gm;
                Console.WriteLine("dpath " + dpath);
                Directory.CreateDirectory(dir); Directory.CreateDirectory(usrdir);
                Directory.CreateDirectory(dpath);
                if (Directory.Exists(dpath) & File.Exists(dpath + "\\PARAM.SFO"))
                {
                    var param = PS3ParamSfo.FromLocal(dpath);
                    sys.OnParamReceivedEvent(null, param);
                    return param;
                }
                else return ParseDirectory(sys, path, dpath);


            }
            catch
            { return PS3ParamSfo.Null; }
        }
        private static PS3ParamSfo ParseDirectory(PS3System sys, string dirpath, string localpath)
        {
            var filen = dirpath + "/PARAM.SFO";
            var icon = dirpath + "/ICON0.PNG";
            var pic = dirpath + "/PIC1.PNG";

            if (Misc.UrlFileExists(filen))
            {
                bool hasicon = Misc.UrlFileExists(icon);
                bool haspic = Misc.UrlFileExists(pic);
                var data = Misc.DownloadData(filen);
                var pic_ = haspic ? Misc.DownloadBitmap(pic) : null;
                Thread.Sleep(30);
                var icon_ = hasicon ? Misc.DownloadBitmap(icon) : null;
                Thread.Sleep(30);
                var sfo = PS3ParamSfo.FromData(data, icon_, pic_);
                Thread.Sleep(5);
                File.WriteAllBytes(localpath + "\\PARAM.SFO", data);
                Misc.Log("Writing.. " + localpath + "\\PARAM.SFO" + " - " + Misc.FormatBytes(data.Length));
                sfo.Icon0?.Save(localpath + "\\" + "ICON0.PNG");
                sfo.Pic0?.Save(localpath + "\\" + "PIC0.PNG");
                sys.OnParamReceivedEvent(null, sfo);
                return sfo;
            }
            else
            {
                return PS3ParamSfo.Null;
            }


        }

    }

}
