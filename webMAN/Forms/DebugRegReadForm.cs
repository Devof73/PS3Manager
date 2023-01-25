using PSS3.Classes;
using PSS3.Classes.PS3;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PSS3.Forms
{
    public partial class DebugRegReadForm : Form
    {
        public DebugRegReadForm(PS3System sys)
        {
            InitializeComponent();
            _Reader = new PS3RegRead();
            var fn = $"http://{sys.IP}//dev_flash2/etc/xRegistry.sys";
            var fndat = Misc.DownloadData(fn);
            var lfn = Application.StartupPath + "\\res\\reg.sys";
            File.WriteAllBytes(lfn, fndat);
            if (File.Exists(lfn))
            {
                _Reader = new PS3RegRead();
                _Reader.Load(lfn);
                Thread.Sleep(300);
                Console.WriteLine("DataEntries : " + _Reader.DataEntries.Count);
                Console.WriteLine("SettingEntries : " + _Reader.SettingEntries.Count);
            }
        }
        private PS3RegRead _Reader;

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            foreach (var entry in _Reader.DataEntries)
            {
                if (entry.FileNameEntry != null)

                {
                    listBox1.Items.Add($"{entry.FileNameEntry.Setting} | {entry.Value} : {entry.ValueString}");
                }
            }
        }
    }
}
