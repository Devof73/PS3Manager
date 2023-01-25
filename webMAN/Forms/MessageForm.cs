using Misc;
using PSS3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;

namespace PSS3.Forms
{
    public partial class MessageForm : Form
    {
        public enum MessageIcons
        {
            Invalid,
            Question,
            Warning,
            Error,

        }
        public MessageForm(string title, string msg, string lbutton = null, string rbutton = null, EventHandler L = null, EventHandler R = null, MessageIcons icon = MessageIcons.Error)
        {
            InitializeComponent();
            new FadeForm(this).FadeIn();
            if (msg == null) throw new ArgumentNullException("msg");
            if ((lbutton == null) & (rbutton == null)) throw new ArgumentNullException("lbutton, rbutton");
            else
            {
                Set(title, msg, lbutton, rbutton, GetIcon(icon), L, R);
                AlertSnd(icon);
                this.ShowDialog();
            }
        }
        public void Set(string title, string msg, string l, string r, Bitmap icon, EventHandler L = null, EventHandler R = null)
        {
            this.PB_Icon.Image = icon;
            Button1.Visible = l != null;
            Button2.Visible = r != null;
            Button1.Text = l ?? "";
            Button2.Text = r ?? "OK";
            var lb = L ?? (L = (s, e) => Close());
            var rb = R ?? (R = (s, e) => Close());
            Button1.Click += (s, e) => L?.Invoke(s, e);
            Button2.Click += (s, e) => R?.Invoke(s, e);

            this.Text = title;
            this.LBL_MSG.Text = msg;
        }
        private void AlertSnd(MessageIcons e)
        {
            if (e == MessageIcons.Question) StaticResources.SndOk.Play();
            else if (e == MessageIcons.Error) StaticResources.SndError.Play();
            else if (e == MessageIcons.Warning) StaticResources.SndOk.Play();
            else if (e == MessageIcons.Invalid) StaticResources.SndOk.Play();
            else StaticResources.SndError.Play();

        }
        private Bitmap GetIcon(MessageIcons e)
        {
            if (e == MessageIcons.Question) return Properties.Resources.icon_info;
            else if (e == MessageIcons.Error) return Properties.Resources.icon_error;
            else if (e == MessageIcons.Warning) return Properties.Resources.icon_warn;
            else if (e == MessageIcons.Invalid) return Properties.Resources.icon_noentry1;
            else return Properties.Resources.icon_error;

        }
        public static void ShowException(Exception e)
        {
            if (e == null) return;
            else
            {
                string title = $"Error: {e.GetType().Name}";
                string message = e.Message + "\r\r" + e.Source;
                new MessageForm(title, message).ShowDialog();
            }
        }
    }
}
