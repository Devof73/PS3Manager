using Org.BouncyCastle.Asn1.Mozilla;
using PSS3.Classes.PS3;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;

namespace PSS3.Classes
{
    public class Ps3SystemUser
    {
        public readonly string _urlFormat = "ftp://{0}/dev_hdd0";
        public readonly string _username;
        public readonly string _psnid;
        public readonly int _id;
        public Ps3Property[] _friends;
        public Bitmap AVATAR { get; private set; }
        public string LocalUserName => _username;
        public string PSNId => _psnid;
        public int USERID => _id;
        public Ps3Property[] FriendNames => _friends;
        public string Comment { get; private set; }
        public PS3System OriginSys { get; private set; }
        private Ps3SystemUser() { }
        private Ps3SystemUser(in PS3System FromSys, string url, string username, int id, string psnid, Ps3Property[] friends, string comment, Bitmap avatar)
        {
            _urlFormat = url;
            _username = username;
            _id = id;
            _psnid = psnid;
            _friends = friends;
            Comment = comment;
            AVATAR = avatar;
            OriginSys = FromSys;
        }
        public static Ps3SystemUser[] FromSystem(PS3System sys)
        {
            List<Ps3SystemUser> users = new List<Ps3SystemUser>();
            string usdir = $"ftp://{sys.IP}/dev_hdd0/home/";
            FtpListItem[] dirs = sys.Ps3Ftp.GetDirectories(usdir);
            foreach (FtpListItem dir in dirs)
            {
                users.Add(ParseFromDirectory(dir.FullName, sys));
            }
            return users.ToArray();
        }
        public static Ps3SystemUser ParseFromDirectory(string ftppath, PS3System owner)
        {
            string id = ftppath.Split('/').Last();
            List<Ps3Property> frndl = new List<Ps3Property>();
            string[] frnd = GetFriends(owner.IP, int.Parse(id));
            string username = Misc.DownloadText(ftppath + "/localusername");
            string psnid = GetPSNUsername(owner.IP, int.Parse(id));
            Bitmap avatar = Misc.DownloadBitmap(ftppath + "/friendim/avatar/me.png");
            foreach (string s in frnd)
            {
                frndl.Add(new Ps3Property("text", "friend", s));
                owner.OnFriendDetected(owner, s, Misc.DownloadBitmap(ftppath + "/friendim/avatar/" + s + ".png"));

                Misc.Log("Friend : " + s);
            }
            return new Ps3SystemUser(owner, ftppath, username, int.Parse(id), psnid, frndl.ToArray(), GetComment(ftppath), avatar);
        }
        public void SetComment(string comment)
        {
            if (comment.Length >= 30) throw new System.Exception("Error: Data reached max system length.");
            var old = Comment.Clone() as string;
            try
            {
                var url = $"http://{OriginSys.IP}/home/{PS3System.FormatUserId(_id)}/friendim/mecomment.dat";
                var flag = Misc.UrlFileExists(url);
                if (!flag) return;
                else Misc.UploadText(url, comment); Comment = comment;
            }
            catch
            {
                Comment = old;
            }
        }
        private static string GetComment(string userPath)
        {
            try
            {
                return new WebClient().DownloadString(userPath + "/friendim/mecomment.dat");
            }
            catch
            {
                return "";
            }
        }
        private static string GetPSNUsername(string ip, int userid)
        {
            string url = $"http://{ip}//dev_hdd0//home//000000{userid}//np_cache.dat";
            string value = new WebClient().DownloadString(url);
            value = value.Replace("?", "");
            value = value.Replace("b2pyps3", "[!END]");
            value = value.Normalize();
            value = value.Trim(new char[] { '{', '}', '?' });
            int indkey = value.IndexOf("\0\0\0\0\0");
            if (indkey == -1)
            {
                return "unknown";
            }

            value = value.Substring(indkey + "\0\0\0\0\0".Length);
            value = value.Substring(0, value.IndexOf("\0\0\0\0\0"));
            return value;
        }

        private static string[] GetFriends(string ip, int id)
        {

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{ip}/dev_hdd0/home/000000{id}/friendim/avatar");
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("", "");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string r = reader.ReadToEnd();
            response.Dispose();
            reader.Dispose();
            responseStream.Close();
            List<string> con = new List<string>();
            string[] lines = r.Split(new char[] { '\r', '\n' });
            foreach (string line in lines)
            {
                if (line != " " & line.Length > 2)
                {
                    string filename = line.Substring(line.LastIndexOf(" ")).Trim();
                    if (filename == "." || filename == "..")
                    {
                        continue;
                    }
                    else
                    {
                        string name = filename.Substring(0, filename.LastIndexOf('.'));
                        if (name != "me")
                        {
                            con.Add(name);
                        }
                    }
                }
            }
            return con.ToArray();
        }
    }
    public class Ps3Property
    {
        public readonly string Name;
        public readonly object Value;
        public readonly string Type;
        public Ps3Property(string type, string name, object value)
        {
            Type = type;
            Name = name;
            Value = value;
        }
    }
}
