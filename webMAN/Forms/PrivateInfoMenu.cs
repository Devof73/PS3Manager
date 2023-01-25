using Misc;
using PSS3.Classes;
using PSS3.Classes.PS3;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PSS3.Forms
{
    public partial class PrivateInfoMenu : Form
    {
        private PS3RegRead _Reader;

        public PrivateInfoMenu(PS3System sys)
        {
            InitializeComponent();
            this.Activated += (s, e) => new FadeForm(this).FadeIn();
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
            foreach (var entry in _Reader.DataEntries)
            {
                if (entry.FileNameEntry != null)

                {
                    ListBoxPrivate.Items.Add(new MaterialSkin.MaterialListBoxItem(entry.FileNameEntry.Setting, entry.ValueString));
                }
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            var ind = ListBoxPrivate.SelectedIndex;
            if (ind != -1)
            {
                if (ListBoxPrivate.Items.Count > ind)
                {
                    Clipboard.SetText(ListBoxPrivate.SelectedItem.Text + " : " + ListBoxPrivate.SelectedItem.SecondaryText);
                }
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
