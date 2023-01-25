using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Net;

namespace PSS3.Classes.PS3
{
    public class Command
    {
        string _url = null;
        WebClient _client = null;
        long _totalbytes = 0;
        public event EventHandler CommandSended;
        public string Url { get => _url; }
        public long TotalClientMemory { get => _totalbytes; }
        private Command(PS3System sys)
        {
            var uri = new Uri(sys.AccessUrl);
            _url = $"ftp://{uri.Host}";
            uri = null;
            _client = new WebClient();
        }
        public static Command Instance(in PS3System sys) => new Command(sys);
        public void Do(string command)
        {
            Misc.Log("CMD " + command);
            _totalbytes += _client.DownloadData(Url.Replace("ftp:", "http:") + command).Length;
            _client.DownloadDataCompleted += (o, e) => CommandSended?.Invoke(o, e);
        }
        internal class Commands
        {
            private Commands() { }
            public const string unmount = "/mount.ps3/unmount/";
            public const string unmountps2 = "/mount.ps2/unmount";
            public const string play = "/play.ps3";
            public const string mountPath = "/play.ps3/";
            public const string playscriptPath = "/play.ps3/";
            public const string mountnpdrmTitleId = "/play.ps3?";
            public const string playrcoSnd = "/play.ps3?snd_";
            public const string eject = "/eject.ps3";
            public const string insert = "/insert.ps3";
            public const string ejectXmb = "/xmb.ps3$eject";
            public const string insertXmb = "/xmb.ps3$insert";
            public const string exitxmb = "/xmb.ps3$exit";
            public const string reloadgame = "/xmb.ps3$reloadgame";
            public const string apphomesetPath = "/app_home.ps3?";
            public const string statPath = "/stat.ps3/";
            public const string unlockhdd = "/unlockhdd.ps3";
            public const string downloadUrl = "/download.ps3?url=";
            public const string downloadUrlToPath = "/download.ps3?to=<path>&url=<url>";
            public const string popupMessage = "/popup.ps3/";
            public const string popup = "/popup.ps3";
            public const string showadmin = "/admin.ps3?";
            public const string waitSecs = "/wait.ps3?";
            public const string loadprx = "/loadprx.ps3/";









        }
    }
}
