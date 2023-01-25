using Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS3.Forms.Options
{
    public partial class GeneralOptions : Form
    {
        public GeneralOptions()
        {
            InitializeComponent();
            Refresh();
            this.Activated += (s, e) => new FadeForm(this).FadeIn();
        }
        public void Refresh()
        {
            this.TS1.Checked = Properties.Settings.Default.s1_hideUserComment;
            this.TS2.Checked = Properties.Settings.Default.s2_disablePsMapi;
            this.TS3.Checked = Properties.Settings.Default.s3_hidePowerMenu;
            this.TS4.Checked = Properties.Settings.Default.s4_ForceLocalUsername;
        }
        public void Save()
        {
            Properties.Settings.Default.s1_hideUserComment = this.TS1.Checked;
            Properties.Settings.Default.s2_disablePsMapi = this.TS2.Checked;
            Properties.Settings.Default.s3_hidePowerMenu = TS3.Checked;
            Properties.Settings.Default.s4_ForceLocalUsername = TS4.Checked;
        }
        private void ButtonYoutOp_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Save();

            this.Close();
        }

        private void ButtonDisop_Click(object sender, EventArgs e)
        {
            new DiscordConfigForm().ShowDialog();

        }
    }
}
