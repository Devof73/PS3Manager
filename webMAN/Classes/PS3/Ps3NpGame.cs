using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Net.FtpClient;
using System.Resources;

namespace PSS3.Classes.PS3
{
    public class Ps3NpGame
    {
        public Ps3Directory USRDIR { get; private set; }
        public Ps3Directory TROPDIR { get; private set; }
        public Ps3Directory C00 { get; private set; }
        public PS3ParamSfo PARAMSFO { get; private set; }
        private Ps3NpGame(Ps3Directory Usrdir, Ps3Directory Tropdir, Ps3Directory C00, PS3ParamSfo Paramsfo)
        {
            USRDIR = Usrdir;
            TROPDIR = Tropdir;
            this.C00 = C00;
            PARAMSFO = Paramsfo;
        }
        private Ps3NpGame() { }
        public Ps3NpGame FromSystem(PS3System sys, string path)
        {
            if (sys == null) throw new ArgumentNullException("sys");
            else if (path == null) throw new ArgumentNullException("path");
            else
            {
                var gm = new Ps3NpGame();
                var paths = sys.Ps3Ftp.GetDirectories(path);
                if (path.EndsWith("/")) path = path.Substring(0, path.Length - 2);
                if (paths != null & paths.Length > 0)
                {
                    foreach (var dir in paths)
                    {
                        gm.USRDIR = dir.Name == "USRDIR" ? Ps3Directory.FromSystem(sys, dir.FullName) : null;
                        gm.C00 = dir.Name == "C00" ? Ps3Directory.FromSystem(sys, dir.FullName) : null;
                        gm.TROPDIR = dir.Name == "TROPDIR" ? Ps3Directory.FromSystem(sys, dir.FullName) : null;
                        gm.PARAMSFO = PS3ParamSfo.FromFile(Ps3File.FromSystem(sys, path));
                    }
                    return gm;
                }
                else throw new Exception("Invalid directory.");
            }
        }
    }
}
