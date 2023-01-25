using Misc;
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
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace PSS3.Forms
{
    public partial class WaitingForm : Form
    {
        public Action ToDo { get; set; }
        public Exception Error { get; set; }
        public event EventHandler<bool> Finished;
        public bool Sucess { get; set; }
        public WaitingForm(Action doAndClose)
        {
            InitializeComponent();
            ToDo = doAndClose;
        }
        public WaitingForm()
        {
            InitializeComponent();
            SuspendLayout();
            PerformLayout();
            ResumeLayout();
        }
        public void SetState(string title, string message)
        {
            this.Text = title;
            this.StateLabel.Text = message;
        }
        public new void Show()
        {
            ToDo();
            base.Show();
        }
        /// <summary>
        /// Muestra el dialogo de espera.
        /// </summary>
        /// <param name="doing">Bool determinante de si se debe ejecutar el Action.</param>
        /// <returns></returns>
        public DialogResult ShowDialog(bool doing)
        {
            if (doing)
            {
                base.Show();
                ToDo();
                var end = new Random().Next(5000);
                var tm = new System.Windows.Forms.Timer();
                tm.Interval = end;
                tm.Tick += (s, e) =>
                {

                    Finished?.Invoke(this, true);
                    tm.Stop();
                    SendClose();

                };
                tm.Start();
                return DialogResult.OK;
            }
            else { base.ShowDialog(); return DialogResult.None; };
        }

        public void SendClose(Action OnClosing = null, string Message = null, Exception error = null)
        {
            if (Message != null) this.StateLabel.Text = Message;

            Thread.Sleep(500);
            OnClosing?.Invoke();
            Error = error;
            this.Close();

            return;
        }
        private void WaitingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
