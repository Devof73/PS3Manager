
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.FtpClient;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PSS3.Classes.PS3
{
    public class Ps3Directory
    {
        private List<Ps3Directory> _subDirectories;
        private List<Ps3File> _files;
        private PS3System _origin;
        private string _url = null;
        private string _name = null;
        public string Name { get => _name; }
        public string AccessUrl { get => _url; }
        public Ps3Directory[] Directories { get => _subDirectories.ToArray(); }
        public Ps3File[] Files { get => _files.ToArray(); }
        private Ps3Directory(PS3System sys, string url, bool recursive = false)
        {
            _origin = sys;
            _url = url;
            _name = Path.GetFileName(url);
            Fetch(url, recursive);
        }
        public Ps3Directory(List<Ps3Directory> subDirectories, List<Ps3File> files, PS3System origin, string url, string name)
        {
            _subDirectories = subDirectories;
            _files = files;
            _origin = origin;
            _url = url;
            _name = name;
        }
        public bool ContainsFileName(string name)
        {
            foreach (var f in Files)
            {
                if (f.SafeFileName == name) return true;
            }
            return false;
        }
        private Ps3Directory(PS3System sys, FtpListItem ftpValue)
        {
            _origin = sys;
            _url = ftpValue.FullName;
            _name = ftpValue.Name;
        }
        private List<Ps3Directory> Fetch(string url, bool recursive = false)
        {
            _subDirectories = new List<Ps3Directory>();
            _files = new List<Ps3File>();
            var path = Path.Combine(_origin.AccessUrl, url);
            if (recursive)
            {
                var dirs = _origin.Ps3Ftp.GetDirectories(path);
                var files = _origin.Ps3Ftp.GetFiles(path);
                foreach (var f in files) _files.Add(Ps3File.FromSystem(_origin, f.FullName));
                foreach (var d in dirs) { _subDirectories.Add(new Ps3Directory(_origin, d.FullName, true)); Console.WriteLine("[⬇️] " + d.FullName); }
            }
            else
            {
                var dirs = _origin.Ps3Ftp.GetDirectories(path);
                var files = _origin.Ps3Ftp.GetFiles(path);
                foreach (var f in files) _files.Add(Ps3File.FromSystem(_origin, f.FullName));
                foreach (var d in dirs) _subDirectories.Add(new Ps3Directory(_origin, d));
            }
            return _subDirectories;
        }
        public static Ps3Directory FromSystem(PS3System system, string path = null)
        {
            var url = system.AccessUrl + path;
            Misc.Log("Initializing root from " + url);

            if (system == null) throw new ArgumentNullException("system");
            else if (url == null) return new Ps3Directory(system, system.RootFolder.AccessUrl);
            else return new Ps3Directory(system, url);
        }
        public List<Ps3Directory> RefreshSubDirectories(string path)
        {
            if (_subDirectories == null)
            {
                return Fetch(path, false);
            }
            else
            {
                _subDirectories = new List<Ps3Directory>();
                return Fetch(path, true);
            }

        }
    }
}
