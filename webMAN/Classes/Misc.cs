
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web.Caching;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace PSS3
{
    internal class Misc
    {
        System.Windows.Forms.Form SForm = null;
        System.Windows.Forms.Timer AnimController = new System.Windows.Forms.Timer();
        static bool is64BitProcess = (IntPtr.Size == 8);
        static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );
        public static bool FtpDirExists(string dirPath)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dirPath);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
        public static string[] GetDirectories(string path)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(path);
            ftpRequest.UseBinary = true;
            ftpRequest.Credentials = new NetworkCredential("", "") { Domain = new Uri(path).Host };
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            List<string> directories = new List<string>();

            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                directories.Add(line);
                line = streamReader.ReadLine();
            }

            streamReader.Close();
            response.Close();


            return directories.ToArray();
        }
        public static bool UploadText(string filename, string text)
        {
            try
            {
                new WebClient().UploadString(filename, text);
                return true;
            }
            catch
            (Exception)
            {
                return false;
            }
        }

        public static string DownloadText(string url) => new WebClient().DownloadString(url);
        public static Bitmap DownloadBitmap(string url)
        {
            try
            {
                var r = WebRequest.Create(url.Replace("ftp://", "http://")).GetResponse().GetResponseStream();
                var ms = new MemoryStream();
                r.CopyTo(ms);
                r.Close();
                var op = new Bitmap(ms);
                ms.Close();
                return op;
            }
            catch
            {
                return Properties.Resources.tex_broken_icon;
            }
        }
        public static Byte[] DownloadData(string url) { try { return new WebClient().DownloadData(url); } catch { return new byte[1]; } }
        public static bool InternalCheckIsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool UrlFileExists(string url)
        {
            var request = (FtpWebRequest)WebRequest.Create
    (url.Replace("http", "ftp"));
            request.Credentials = new NetworkCredential("user", "pass");
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode ==
                    FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    response.Close();
                    return false;
                }
            }
            return false;
        }
        public Misc(System.Windows.Forms.Form Form)
        {
            SForm = Form;
        }
        public void AnimationStart(int interval = 5)
        {
            AnimController = new System.Windows.Forms.Timer();
            AnimController.Interval = interval;
            AnimController.Tick += AnimController_Tick;
            AnimController.Start();
        }
        private void AnimController_Tick(object sender, EventArgs e)
        {
            if (SForm.Opacity == 1.0)
            {
                AnimController.Stop();
                return;
            }
            SForm.Opacity += 0.070;

        }
        [DllImport("uxtheme.dll", EntryPoint = "#95")]
        public static extern uint GetImmersiveColorFromColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType, bool bIgnoreHighContrast, uint dwHighContrastCacheMode);
        [DllImport("uxtheme.dll", EntryPoint = "#96")]
        public static extern uint GetImmersiveColorTypeFromName(IntPtr pName);
        [DllImport("uxtheme.dll", EntryPoint = "#98")]
        public static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);
        public static Color GetThemeColor()
        {
            var colorSetEx = GetImmersiveColorFromColorSetEx(
                (uint)GetImmersiveUserColorSetPreference(false, false),
                GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground")),
                false, 0);

            var colour = Color.FromArgb((byte)((0xFF000000 & colorSetEx) >> 24), (byte)(0x000000FF & colorSetEx),
                (byte)((0x0000FF00 & colorSetEx) >> 8), (byte)((0x00FF0000 & colorSetEx) >> 16));

            return colour;
        }
        public Bitmap UpscaleBitmap(Bitmap input, int more = 2, bool log = true)
        {

            Bitmap img = input;
            Bitmap uimg = new Bitmap((img.Width * more) + (more * 5), (img.Height * more) + (more * 5));
            var h = img.Height;
            var w = img.Width;
            if (log)
            {
                {

                    for (int x = 0; x < w; x++)
                    {

                        for (int y = 0; y < h; y++)
                        {

                            {

                                int FinalValueX = x * more;
                                int FinalValueY = y * more;


                                Console.WriteLine("xx:{0}/{1}yy:{2}/{3}",
                                  FinalValueX, uimg.Width, FinalValueY, uimg.Height);

                                if (FinalValueX > uimg.Width)
                                {
                                    FinalValueX = uimg.Width - 2;
                                }
                                if (FinalValueY > uimg.Height)
                                {
                                    FinalValueY = uimg.Height - 2;
                                }
                                for (int o = 0; o < more; o++)
                                {
                                    for (int op = 0; op < more; op++)
                                    {
                                        var sx = FinalValueX + o;
                                        var sy = FinalValueY + o;
                                        if (sy == uimg.Width - 2)
                                        {
                                            Console.WriteLine(sy);
                                            BigPixel(uimg, sx, uimg.Width - 2, img.GetPixel(x, y), more);

                                        }
                                        BigPixel(uimg, sx, sy, img.GetPixel(x, y), more);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int x = 0; x < w; x++)
                {
                    for (int y = 0; y < h; y++)
                    {
                        int FinalValueX = x * more;
                        int FinalValueY = y * more;
                        if (FinalValueX > uimg.Width)
                        {
                            FinalValueX = uimg.Width - 4;
                        }
                        if (FinalValueY > uimg.Height)
                        {
                            FinalValueY = uimg.Height - 4;
                        }
                        for (int o = 0; o < more; o++)
                        {
                            for (int op = 0; op < more; op++)
                            {
                                var sx = FinalValueX + o;
                                var sy = FinalValueY + o;
                                if (sy == uimg.Width - 2)
                                {
                                    BigPixel(uimg, sx, uimg.Width - 4, img.GetPixel(x, y), more);
                                }
                                BigPixel(uimg, sx, sy, img.GetPixel(x, y), more);
                            }
                        }
                    }
                }
            }


            return uimg;
        }
        public static bool IsVsDebugging()
        {
            List<string> names = new List<string>();
            Process[] processes = Process.GetProcesses();
            {
                for (int i = 0; i < processes.Length; i++)
                {
                    if (processes[i].MainWindowTitle != string.Empty)
                    {
                        names.Add(processes[i].ProcessName);
                    }
                }
            }
            Console.ReadLine();
            return names.Contains("Microsoft Visual Studio");
        }
        internal void BigPixel(in Bitmap input, int x, int y, Color px, int dim = 2)
        {
            if (x == input.Width)
            {
                x -= dim;
            }
            if (y == input.Height)
            {
                y -= dim;
            }
            for (var i = 0; i < dim; i++)
            {
                input.SetPixel(x + i, y, px);
            }
            for (var i = 0; i < dim; i++)
            {
                input.SetPixel(x, y + i, px);
            }
        }
        public double InternetSpeed()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Reset();
            stopwatch.Start();

            WebClient webClient = new WebClient();
            byte[] bytes = webClient.DownloadData("http://www.codeproject.com");

            stopwatch.Stop();

            double seconds = stopwatch.Elapsed.TotalSeconds;

            double speed = bytes.Count() / seconds;

            return speed;
        }
        internal double GetSysRamUsage()
        {
            var memory = 0.0;
            using (Process proc = Process.GetCurrentProcess())
            {
                // The proc.PrivateMemorySize64 will returns the private memory usage in byte.
                // Would like to Convert it to Megabyte? divide it by 2^20
                memory = proc.PrivateMemorySize64 / (1024 * 1024);
            }
            return memory;
        }

        public List<double> Temp
        {
            get
            {
                var result = new List<double>();
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
                foreach (ManagementObject obj in searcher.Get())
                {
                    Double temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                    temperature = (temperature - 2732) / 10.0;
                    result.Add(temperature);
                }
                return result;
            }
        }
        internal int _NotRespondingProcessesCount = 0;
        Stopwatch s;
        public int CountNotRespondingProcesses()
        {
            s = new Stopwatch();
            s.Restart();
            s.Start();
            var bgw = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            bgw.DoWork += Bgw_DoWork;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;
            bgw.RunWorkerAsync();
            return _NotRespondingProcessesCount;
        }
        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            s.Stop();
            Console.WriteLine("Refresh Information Operation Completed in " + s.ElapsedMilliseconds + "ms");
        }
        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            var i = 0;
            for (int ii = 0; ii < Process.GetProcesses().Length; ii++)
            {
                if (Process.GetProcesses()[ii].Responding == false)
                {
                    i++;
                }
            }
            _NotRespondingProcessesCount = i;
        }

        [return: MarshalAs(UnmanagedType.Bool)]

        double cff_fade = 1.0;
        public void CloseFormFade(int interval)
        {
            var t = new Timer();
            t.Tick += T_Tick;
            t.Interval = interval;
            SForm.Opacity = 1.0;
            t.Start();
            if (cff_fade == 0.00)
            {
                t.Stop();
                SForm.Close();
            }
            Environment.Exit(0x1);
        }
        private void T_Tick(object sender, EventArgs e)
        {
            if (cff_fade != 0.0)
            {
                cff_fade -= 0.05;
                SForm.Opacity = cff_fade;

            }
            else
            {
                SForm.Opacity = cff_fade;
            }
        }
        private static void TreeViewListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();

            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                    currentNode.Nodes.Add(childDirectoryNode);
                    stack.Push(childDirectoryNode);
                }
                foreach (var file in directoryInfo.GetFiles())
                    currentNode.Nodes.Add(new TreeNode(file.Name));
            }

            treeView.Nodes.Add(node);
        }
        public static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public static Image CreateThumbnail(Image original, Size size)
        {
            int w = size.Width;
            int h = size.Height;

            Bitmap canvas = new Bitmap(w, h);

            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(new SolidBrush(Color.FromArgb(24, 24, 24)), 0, 0, w, h);

            float fw = (float)w / (float)original.Width;
            float fh = (float)h / (float)original.Height;

            float scale = Math.Min(fw, fh);
            fw = original.Width * scale;
            fh = original.Height * scale;

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            g.DrawImage(original,
                new RectangleF((w - fw) / 2, (h - fh) / 2, fw, fh),
                new RectangleF(0, 0, original.Width, original.Height), GraphicsUnit.Pixel);
            g.Dispose();

            return canvas;
        }
        internal enum MediaType
        {
            Video, Audio, Image, Unknown
        }
        public static class MediaFormats
        {
            public static string[] Video = { ".mp4", ".m4a", ".m4p", ".m4b", ".m4r", ".m4v"
        ,"·.WEBM", "·.MPG", ".MP2", ".MPEG", ".MPE", ".MPV",".OGG" ,".MP4", ".M4P", ".M4V" ,".AVI", "·.WMV",".MOV", ".QT",".FLV", ".SWF"};
            public static string[] Image =
                {
            ".JPEG",
            ".JPG",
            ".GIF",
            ".PNG",
            ".TIFF",
            ".RAW",
            ".PSD" };
            public static string[] Audio =
            {
            ".mp3",
            ".m4a",
            ".flac",
            ".mp3",
            ".wav",
            ".wma",
            ".aac",

        };
            static string[][] _Types = { Video, Image, Audio };
            public new static MediaType GetType(string filename)
            {
                var ext = Path.GetExtension(filename);
                Console.WriteLine(Video.Contains(ext));
                if (Video.Contains(ext))
                {
                    return MediaType.Video;
                }

                else if (Audio.Contains(ext))
                {
                    return MediaType.Audio;
                }
                else if (Image.Contains(ext))
                {
                    return MediaType.Image;
                }
                return MediaType.Unknown;

            }

        }
        public static event EventHandler<string> NewLog;
        public static void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss")}] {message}");
            NewLog?.Invoke(null, message);

        }

    }


}
