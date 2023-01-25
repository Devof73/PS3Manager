using DiscordRPC;
using PSS3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS3.Forms
{
    public partial class debug : Form
    {
        public debug()
        {
            InitializeComponent();
        }
        PSS3.Classes.Discord.PS3DiscordClient _PSCli;
        public void InitRpc()
        {

            _PSCli = new Classes.Discord.PS3DiscordClient();
            _PSCli.InitRpc(Properties.Resources.DEVP_APPID);
            new Thread(() => _PSCli.SetRpc(_PSCli.CreateRPC
            ("Debugging state.", "Owner troubleshooting..."))).Start();
        }
        public void UpdateRpc(RichPresence rpc)
        {
            if (Properties.Settings.Default.usingRpc & _PSCli != null)
            {
                _PSCli.SetRpc(rpc);
            }
        }
        public void UpdateRpc(string details, string state)
        {
            if (Properties.Settings.Default.usingRpc & _PSCli != null)
            {
                _PSCli.SetRpc(_PSCli.CreateRPC(state, details));
            }
        }
        public void StopRpc()
        {
            if (Properties.Settings.Default.usingRpc & _PSCli != null)
            {
                _PSCli.Stop();
            }
        }
        public void ClearRpc()
        {
            if (Properties.Settings.Default.usingRpc)
            {
                _PSCli.ClearPresence();
            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            StopRpc();
        }

        private void D3_Click(object sender, EventArgs e)
        {
            ClearRpc();
        }

        private void D1_Click(object sender, EventArgs e)
        {
            InitRpc();
        }
    }


}
