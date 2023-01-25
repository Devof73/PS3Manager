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
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace PSS3.Forms
{
    public partial class YTForm : Form
    {
        public bool Sucess { get; private set; }
        public Video ResultVideo { get; private set; }
        public int IntervalMins { get; private set; }
        public event EventHandler<object[]> OnSucess;
        public YTForm()
        {
            InitializeComponent();
        }

        private void ButtonEnable_Click(object sender, EventArgs e)
        {
            try
            {
                YoutubeClient cli = new YoutubeClient();
                Video vid = null; vid = cli.Videos.GetAsync(VideoId.Parse(TXTURL.Text)).Result;
                Thread.Sleep(900);
                if (vid != null)
                {
                    ResultVideo = vid;
                    IntervalMins = (int)NUMINT.Value;
                    OnSucess?.Invoke(null, new object[] { vid, IntervalMins });
                }
                Sucess = true;

            }
            catch
            {
                Sucess = false;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
