using Misc;
using PSS3.Classes;
using PSS3.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using WinBlur;
using Control = System.Windows.Forms.Control;
using Label = System.Windows.Forms.Label;

namespace PSS3
{
    public partial class Main : Form
    {
        Misc _misc;
        string _oldTextEntry = "";
        FadeForm _fading;
        public Main()
        {

            InitializeComponent();
            RefreshDesign();
            PSS3.Misc.GetThemeColor();
            var ipsave = Application.StartupPath + "\\res\\connstate.log";
            if (File.Exists(ipsave))
            {
                var dat = File.ReadAllText(ipsave).Split(':');
                TextBoxAddress.Text = dat[0];
                TextBoxPort.Text = dat[1];
            }
            _misc = new Misc(this);
            _fading = new FadeForm(this);
            _fading.FadeIn();
            StaticResources.SndCursor.Load();
            StaticResources.SndError.Load();
            StaticResources.SndOption.Load();
            StaticResources.SndCancel.Load();
            StaticResources.SndOk.Load();
        }
        void RefreshDesign()
        {

            foreach (Control c in this.Controls)
            {
                if (c is Label) { c.ForeColor = Color.WhiteSmoke; }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var ip = TextBoxAddress.Text;
            if (PS3System.IsWebMAN(ip))
            {
                FormDoConnection(ip);
            }
            else new MessageForm("PS3 System Error",
                "The PS3 is unreachable because not has WEBMAN installed!", null, "OK");
        }
        private void FormDoConnection(string ip)
        {

            var api = new PS3MAPI();
            var waitform = new WaitingForm();
            Thread.Sleep(100);
            var to = new Random(2000).Next(1000);
            Exception error = null;
            var ipsave = Application.StartupPath + "\\res\\connstate.log";
            waitform.ToDo = () =>
            {
                var mm = new MonitoredMapi(api, IPAddress.Parse(ip), int.Parse(TextBoxPort.Text));
                mm.Connected += (s, or) =>
                {
                    Thread.Sleep(400);
                    waitform.SendClose(null, or.name, or.error);
                    error = or.error;

                };
                mm.OperationFinished += (ss, or) => waitform.SendClose(null, or.name, or.error);
                mm.Connect(to);
            };
            waitform.ShowDialog(true);
            if (api.IsConnected)
            {
                new FadeForm(this).FadeOut((s, f) =>
                {

                    var form = new DashboardForm(IPAddress.Parse(ip), int.Parse(TextBoxPort.Text), new NetworkCredential(TXT_USNM.Text, TXT_PWD.Text));
                    form.FormClosed += (ss, ff) => this.Close();
                    File.WriteAllText(ipsave, $"{ip}:{TextBoxPort.Text}");
                    form.ShowDialog();
                }, this, 0);

            }
            else
            {
                if (error != null) MessageBox.Show("Error while trying to connect to " + ip + "...\r" + error.Message + "\r-" + error.Source, error.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            StaticResources.SndOption.Play();
            var textbox = ((Guna.UI2.WinForms.Guna2TextBox)sender);
            var newtext = textbox.Text;
            var lastchar = newtext.ToCharArray().LastOrDefault();
            if (char.IsLetter(lastchar))
            {
                textbox.Text = _oldTextEntry;
            }
            else if (lastchar != '.')
            {
                if (char.IsLetter(lastchar))
                {
                    textbox.Text.Remove(textbox.Text.Length - 1);
                }
            }
            else _oldTextEntry = textbox.Text;
        }

        private void MainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxPort_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPort.Text == "") return;
            if (TextBoxPort.Text.Length <= 1)
            {

            }
            if (!char.IsNumber(TextBoxPort.Text.Last()))
            {
                if (TextBoxPort.Text.Length <= 1)
                {
                    TextBoxPort.Text = "";
                    TextBoxPort.SelectionStart = TextBoxPort.Text.Length - 1;
                    TextBoxPort.SelectionLength = 0;
                }
                else
                {
                    TextBoxPort.Text = TextBoxPort.Text.Substring(0, TextBoxPort.Text.Length - 1);
                    TextBoxPort.SelectionStart = TextBoxPort.Text.Length - 1;
                    TextBoxPort.SelectionLength = 0;
                    TextBoxPort.ScrollToCaret();
                }
            }
        }

        private void ButtonIp_Click(object sender, EventArgs e) => throw new NotImplementedException("Not implemented");

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            var K = (Keys)e.KeyChar;
            if (K == Keys.Tab) StaticResources.SndCancel.Play();
            else if (K == Keys.Enter) StaticResources.SndOption.Play();
            ProcessSecretCode(e);
            Console.WriteLine(e);
        }
        int _codeInteg = 0;
        Keys _lastK;
        private void ProcessSecretCode(KeyPressEventArgs e)
        {
            var k = (Keys)e.KeyChar;

            if (k == Keys.D)
            {
                _codeInteg++;
                _lastK = k;
                return;
            }
            else if (_lastK == Keys.D & k == Keys.S)
            {
                _codeInteg++;
                _lastK = k;
                return;
            }
            else if (_lastK == Keys.S & k == Keys.J)
            {
                _codeInteg++;
                _lastK = k;
                return;
            }

            if (_codeInteg >= 3)
            {

                new debug().ShowDialog();
                _codeInteg = 0;
            }
            Console.WriteLine(_codeInteg);
        }

        private void MainContainer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void TextBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProcessSecretCode(e);

        }
    }
}