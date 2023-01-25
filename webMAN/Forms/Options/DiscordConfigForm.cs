using Guna.UI2.WinForms;
using PSS3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS3.Forms
{
    public partial class DiscordConfigForm : Form
    {
        public DiscordConfigForm()
        {
            InitializeComponent();
            ContextRpcAddFormatItem.ItemClicked += ContextRpcAddFormatItem_ItemClicked;
            Init();
        }
        public void Init()
        {
            var rs = StaticResources.Resources;
            var file = rs + "\\dsIds.lst";
            if (File.Exists(file))
            {
                var f = File.ReadAllLines(file);
                foreach (var line in f)
                {
                    this.listBox1.Items.Add(long.Parse(line));
                }
            }
            TBX_DETAILSRPC.Text = Properties.Settings.Default.DiscordRpcDetailsFormat;
            TBX_STATE_RPC.Text = Properties.Settings.Default.DiscordRpcStateFormat;
            TS1.Checked = Properties.Settings.Default.usingDiscord;
            TS2.Checked = Properties.Settings.Default.usingNotifier;
        }
        private void ContextRpcAddFormatItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Sender.Text += $"{{{e.ClickedItem.Text}}}";
        }

        private void buttonadddetailsformat(object sender, EventArgs e)
        {
            Sender = TBX_DETAILSRPC as Guna2TextBox;
            ContextRpcAddFormatItem.Show(sender as Control, new Point((sender as Control).Size));
        }
        Guna2TextBox Sender = null;
        private void button_addstateformat(object sender, EventArgs e)
        {
            Sender = TBX_STATE_RPC as Guna2TextBox;
            ContextRpcAddFormatItem.Show(sender as Control, new Point((sender as Control).Size));

        }

        private void TBX_STATE_RPC_TEXTCHANGED(object sender, EventArgs e)
        {

        }

        private void TBX_DETAILSRPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void gAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.usingRpc = TS1.Checked;
            Properties.Settings.Default.usingNotifier = TS2.Checked;
            Properties.Settings.Default.DiscordRpcDetailsFormat = this.TBX_DETAILSRPC.Text;
            Properties.Settings.Default.DiscordRpcStateFormat = this.TBX_STATE_RPC.Text;
            var rs = StaticResources.Resources;
            Properties.Settings.Default.Save();
            var file = rs + "\\dsIds.lst";
            SaveIds(file);
            this.Dispose();
        }
        public void SaveIds(string path)
        {
            string value = "";
            foreach (string c in this.listBox1.Items)
            {
                value += ulong.Parse(c);
            }
            File.WriteAllText(path, value);
        }
        private void ButtonCancel_Click(object sender, EventArgs e) => this.Close();

        private void ButtonDsServIdAdd_Click(object sender, EventArgs e)
        {
            try
            { listBox1.Items.Add(long.Parse(TXT_SERVID.Text)); }
            catch
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
