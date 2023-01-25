using System;
using System.IO;
using System.Net;
using System.Net.FtpClient;
using System.Threading;
using System.Threading.Tasks;

namespace PSS3.Classes.PS3
{
    public class Ps3File
    {
        private PS3System _fromsys = null;
        private string _accessUrl = null;
        private FtpListItem _origin = null;
        public PS3System OriginalSystem { get => _fromsys; }
        public long FileSize { get => _origin.Size; }
        public string SafeFileName { get => _origin.Name; }
        public DateTime LastModifiedTime { get => _origin.Modified; }
        public DateTime CreatedTime { get => _origin.Created; }
        public string AccessUrl { get => _accessUrl; }
        public byte[] Data { get; private set; }
        private Ps3File(string Url, PS3System originalSystem)
        {
            _fromsys = originalSystem;
            _accessUrl = Url;
            _origin = Fetch(Url);
            Data = new WebClient().DownloadData(Url);
            Thread.Sleep(5);
        }
        private FtpListItem Fetch(string url)
        {
            var path = Path.GetDirectoryName(url);
            var name = Path.GetFileName(url);
            foreach (FtpListItem i in _fromsys.Ps3Ftp.GetFiles(path))
            {
                if (i.FullName == name)
                {
                    return i;
                }

            }
            return null;
        }
        private Ps3File() { }
        public void Download(string filename) => new WebClient().DownloadFile(_accessUrl, filename);
        public static Ps3File FromSystem(PS3System sys, string url) => new Ps3File(url, sys);
    }
}
