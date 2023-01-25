
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.FtpClient;

namespace PSS3.Classes.PS3
{
    public class Ps3FileTransferProtocol
    {
        private FtpClient _client = null;
        private PS3System _fromSystem = null;
        public static Ps3FileTransferProtocol FromSystem(PS3System sys)
        {
            var ps3ftp = new Ps3FileTransferProtocol();
            ps3ftp._fromSystem = sys;

            ps3ftp._client = new FtpClient() { Host = sys.IP, Credentials = sys.Credentials ?? new System.Net.NetworkCredential("", "") };
            return ps3ftp;
        }
        Ps3FileTransferProtocol(PS3System sys) { _fromSystem = sys; Initialize(); }
        private Ps3FileTransferProtocol() { }
        private void Initialize()
        {
            var uri = new Uri(_fromSystem.AccessUrl);
            _client = new FtpClient() { Host = uri.Host, Port = _fromSystem.PORT, Credentials = _fromSystem.Credentials };
            _client.GetListing();
        }
        public FtpListItem[] GetFiles(string path)
        {
            var output = new List<FtpListItem>();
            var bl = _client.GetListing(path);
            foreach (var file in bl)
            {
                if (file.Type == FtpFileSystemObjectType.File)
                {
                    output.Add(file);
                }
            }
            return output.ToArray();
        }
        public FtpListItem[] GetDirectories(string path)
        {
            var output = new List<FtpListItem>();
            var bl = _client.GetListing(path);
            Console.WriteLine(bl.Length);
            foreach (var file in bl)
            {
                if (file.Type == FtpFileSystemObjectType.Directory) output.Add(file);
            }
            return output.ToArray();
        }
        public FtpListItem[] GetListing(string path) => _client.GetListing(path);

    }
}
