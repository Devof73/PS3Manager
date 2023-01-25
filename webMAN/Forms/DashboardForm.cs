using DiscordRPC;
using Guna.UI2.WinForms;
using Misc;
using PSS3.Classes;
using PSS3.Classes.Discord;
using PSS3.Classes.PS3;
using PSS3.Forms.Options;
using PSS3.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos;
using static PSS3.PS3MAPI.PS3_CMD;
using Timer = System.Windows.Forms.Timer;

namespace PSS3.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly Timer _updater = new Timer() { Interval = 30000 };
        private PS3System _system = null;

        private PS3MAPI Manager => _system.Manager;
        public string Url => _system.AccessUrl;
        private event EventHandler Initialized;
        private ImageList _gameImages = null;
        private ImageList _friendimImages = null;
        private ImageList _savedatImages = null;
        private int _gameImageIndex = 0;
        private int _friendimImageIndex = 0;
        private int _saveDatImageIndex = 0;
        private bool _ytNotEnabled = false;
        private Video _ytTargetVideo = null;
        private Exception _UpdateError;
        private Thread _UpdateThread;
        private Ps3SystemUser _userData;
        private object[] _values = null;
        private TimeSpan _elapsed = TimeSpan.Zero;
        private TimeSpan _gmelapsed = TimeSpan.Zero;
        private Thread _InitThread;
        private PS3DiscordClient _PSCli = null;
        private int _ytNotElapsed = 0;
        private int _ytNotInterval = 0;

        public DashboardForm(IPAddress ip, int port = 7887, NetworkCredential cred = null)
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += (s, e) => MessageForm.ShowException(e.ExceptionObject as Exception);
            Ps3Database.Initialize(Application.StartupPath + "\\res\\dat.trim");
            Thread.Sleep(200);
            Initialized += (s, e) => ControlDelegates.Invoke(this, () => UpdateStates());
            Begin(ip, port, cred);
            Cursor cur = new Cursor(Properties.Resources.tex_pointer_arrow.GetHicon());
            Cursor = cur;
            Misc.NewLog += (s, e) => ControlDelegates.Invoke(this, () => LabelLogMessage.Text = e);
            Thread.Sleep(100);
            Activated += (s, e) => AnimToogle(true);
            Deactivate += (s, e) => AnimToogle(false);
            SetSndHandlers();

        }

        internal void SetSndHandlers()
        {
            foreach (Control c in Controls)
            {
                c.Click += (s, e) => StaticResources.SndCursor.Play();
            }

        }
        internal byte[] BmpArray(Bitmap bmp)
        {
            MemoryStream ms = null;
            bmp.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        internal void AnimToogle(bool t)
        {
            try
            {
                Opacity = t ? 1 : 0.3;
            }
            catch { }
        }
        internal void Logout()
        {
            _PSCli?.Stop();
            new FadeForm(this).FadeOut((s, e) => Close(), this);

        }
        public bool CheckConnection(string url)
        {
            bool error = false;
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadStringCompleted += (s, e) => error = e.Error != null;
                _ = wc.DownloadString(url);
                wc.Dispose();
                return error == false;
            }
            catch
            {
                return false | error;
            }
        }
        public void Begin(IPAddress ip, int port = 7887, NetworkCredential credential = null)
        {
            _system = null;
            Thread t1 = new Thread(() =>
            {
                _system = new PS3System(ip.ToString(), port, credential ?? new NetworkCredential("", ""),
            (s, e) => ControlDelegates.Invoke(this, () => { ToogleSpinner(true); }),
            (s, e) => ControlDelegates.Invoke(this, () => { ToogleSpinner(false, 0); Initialized?.Invoke(this, null); _updater.Start(); }),
            (s, e) => ControlDelegates.Invoke(this, () => ToogleSpinner(true, e)),
            (s, e) => ControlDelegates.Invoke(this, () => DisplayNewGame(e)),
            (s, e) => ControlDelegates.Invoke(this, () => DisplayNewFriend(e[0] as string, e[1] as Image)),
            (s, e) => ControlDelegates.Invoke(this, () => { _userData = e._user; UpdateGui(e._user); _values = e.values; }),
            (s, e) => ControlDelegates.Invoke(this, () => DisplayNewSaveData(e)));

                Thread.Sleep(50);
            });

            _friendimImages = new ImageList
            {
                ColorDepth = ColorDepth.Depth32Bit,
                ImageSize = new Size(64, 64)
            };
            _InitThread = t1;
            t1.Start();
            if (Properties.Settings.Default.usingRpc)
            {
                InitRpc();
            }
            Thread.Sleep(150);

            //_system.Error += (s, e) => MessageBox.Show("Error " + ip + "...\r" + e + "\r-" + e, e.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            _updater.Tick += (o, e) =>
            {
                Properties.Settings df = Properties.Settings.Default;

                if (_system != null)
                {
                    ControlDelegates.Invoke(this, () => UpdateStates());

                }
                if (_ytNotElapsed >= (_ytNotInterval * 60000))
                {
                    YtNotify();
                    _ytNotElapsed = 0;
                }
                if (_ytNotInterval != (decimal)0.0 & _ytNotEnabled)
                {
                    _ytNotElapsed += _updater.Interval;
                }
            };
        }
        public void InitRpc()
        {
            if (Properties.Settings.Default.usingRpc)
            {
                _PSCli = new Classes.Discord.PS3DiscordClient();
                _PSCli.InitRpc(Properties.Resources.DEVP_APPID);
                new Thread(() => _PSCli.SetRpc(_PSCli.CreateRPC(RpcKeywords.GetMessage(_system, Properties.Settings.Default.DiscordRpcStateFormat),
                    RpcKeywords.GetMessage(_system, Properties.Settings.Default.DiscordRpcDetailsFormat), _PSCli.CreateRpcAssets("http://192.168.0.6/dev_hdd0/game/NPUB31419/ICON0.PNG", "", "lol", "")
                     ))).Start();
            }

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
        public void YtNotify()
        {

            if (_ytTargetVideo != null & _ytNotEnabled)
            {
                new Thread(() =>
                {
                    try
                    {
                        Video value = new YoutubeClient().Videos.GetAsync(VideoId.Parse(_ytTargetVideo.Id)).Result;
                        string s1 = value.Title;
                        string s2 = $"Views: {value.Engagement.ViewCount}";
                        string s3 = $"Likes: {value.Engagement.LikeCount}";
                        string s4 = $"Rating: {value.Engagement.AverageRating}";
                        _system.SendCommand("/popup.ps3*" + s1); Thread.Sleep(2000);
                        _system.SendCommand("/popup.ps3*" + s2); Thread.Sleep(2000);
                        _system.SendCommand("/popup.ps3*" + s3); Thread.Sleep(2000);
                        _system.SendCommand("/popup.ps3*" + s4); Thread.Sleep(2000);
                    }
                    catch
                    {
                        _ytNotEnabled = false;

                    }
                }).Start();
            }
        }
        internal void OnUserChanged()
        {
            if (_system._firstUpdate)
            {
                return;
            }

            _savedatImages.Images.Clear();
            _friendimImages.Images.Clear();
            ListViewFriends.Clear();
            ListViewGames.Clear();
            _friendimImageIndex = 0;
            _saveDatImageIndex = 0;

        }
        private void DisplayNewSaveData(Ps3SaveData e)
        {
            if (_savedatImages == null)
            {
                _savedatImages = new ImageList();
            }

            _savedatImages.TransparentColor = ListViewSaves.BackColor;
            _savedatImages.ImageSize = new Size(197, 98);
            _savedatImages.ColorDepth = ColorDepth.Depth32Bit;
            if (e.Values == null)
            {
                return;
            }

            Bitmap ico = e.Icon0 ?? Properties.Resources.item_tex_ps3util;
            _savedatImages.Images.Add(ImageUtils.CreateThumbnail(ico, new Size(197, 98), ListViewSaves.BackColor));
            ListViewItem itm = new ListViewItem();
            _ = e.Values.TryGetValue("SUB_TITLE", out object txt);
            itm.ToolTipText = SfoDictionaryToString(e.Values);
            itm.Text = (txt as string) ?? e.Title ?? "Unkwnown";
            itm.Tag = e;
            itm.ImageIndex = _saveDatImageIndex;
            _ = ListViewSaves.Items.Add(itm);
            ListViewSaves.LargeImageList = _savedatImages;
            ListViewSaves.SmallImageList = _savedatImages;
            _TC_DASHBOARD_SAVEGAMELIST.Text = $"Saves ({_saveDatImageIndex - 1})";
            _saveDatImageIndex++;
        }
        private string SfoDictionaryToString(Dictionary<string, object> e)
        {
            string basee = string.Empty;
            foreach (KeyValuePair<string, object> c in e)
            {
                basee += $"{c.Key.ToUpper()}: {c.Value}\r";
            }
            return basee;
        }
        private void DisplayNewFriend(string name, Image icon)
        {
            if (ListViewFriends.Items.ContainsKey(name) || _friendimImages.Images.ContainsKey(name))
            {
                return;
            }
            else
            {

                _friendimImages.Images.Add(name, ImageUtils.CreateThumbnail(icon, new Size(65, 65), ListViewFriends.BackColor));
                ListViewItem itm = new ListViewItem
                {
                    Text = name,
                    ImageKey = name,
                    Tag = new object[] { name, icon },
                    ImageIndex = _friendimImageIndex
                };
                _ = ListViewFriends.Items.Add(itm);
                ListViewFriends.LargeImageList = _friendimImages;
                ListViewFriends.SmallImageList = _friendimImages;
                _friendimImageIndex++;
                _TC_DASHBOARD_FRIENDLIST.Text = $"Friends ({_friendimImageIndex - 1})";
                //_friendsNames.Add(name);
            }
            TTSL_FriendCount.Text = $"{ListViewFriends.Items.Count} Friends";
        }
        private void DisplayNewGame(PS3System.ReceivedParamEventArgs arg)
        {
            PS3ParamSfo e = arg.SFO;
            ListViewGames.SmallImageList = _gameImages;
            ListViewGames.LargeImageList = _gameImages;
            if (_gameImages == null)
            {
                _gameImages = new ImageList();
            }

            _gameImages.ColorDepth = ColorDepth.Depth32Bit;
            _gameImages.TransparentColor = Color.White;
            _gameImages.ImageSize = new Size(80, 40);
            if (ListViewGames.Items.Count == 0) { _gameImages.Images.Clear(); _gameImageIndex = 0; }
            _gameImages.Images.Add(ImageUtils.CreateThumbnail(e.Icon0, new System.Drawing.Size(80, 40), Color.Gray));

            ListViewItem li = new ListViewItem
            {
                Tag = e,
                Text = e.Title,
                ImageIndex = _gameImageIndex
            };
            _ = ListViewGames.Items.Add(li);
            _gameImageIndex++;
            _TC_DASHBOARD_GAMELIST.Text = $"Games ({_gameImageIndex - 1})";

        }
        public void ToogleSpinner(bool t, int value = 0)
        {
            if (value != 0)
            {
                ProgressBar.Value = value;
            }

            if (value == 100)
            {
                ProgressBar.Visible = false;
            }

            ProgressBar.Visible = t;
            LabelLogMessage.Visible = ProgressBar.Visible;

        }
        public void FailDisconnected()
        {
            new FadeForm(this).FadeOut(
                (s, e) => { new MessageForm("Error", "System connection lost!", null, "OK"); new Main().Show(); }, this);
        }
        public void UpdateStates()
        {
            if (!PS3System.IsWebMAN(_system.IP))
            {

                Logout();

            }
            else if (_UpdateThread == null || !_UpdateThread.IsAlive)
            {
                if (_system == null)
                {
                    return;
                }

                Thread t1 = new Thread(() =>
                {
                    Console.WriteLine("[!] Sys refreshing online values...");
                    _values = _system.UpdateValues(out _UpdateError, (s, e) => ControlDelegates.Invoke(this, () => OnUserChanged()), (s, e) => ControlDelegates.Invoke(this, () => DisplayNewSaveData(e)));
                    Thread.Sleep(50);
                });
                t1.Start();
                _UpdateThread = t1;
                ToogleSpinner(true, 10);
            }
            ToogleSpinner(false);


        }
        /// <summary>
        /// Contacts the server for retrieving client information.
        /// </summary>
        /// <returns>A string[] who contains specific server system values <code> 
        /// [0] swmver
        /// [1] sps3ver 
        /// [2] sps3usdir
        /// [3] sps3mem
        /// [4] sps3hdd
        /// [5] sps3game
        /// [6] sps3fan
        /// [7] sps3temp
        /// [8] sps3userid
        /// [9] sps3useravatar
        /// [10] sps3localusername
        /// [11] sps3gamecover
        /// [12] sps3startuptime
        /// [13] sps3life
        /// [14] sps3gametime
        /// </code></returns>
        public void UpdateGui(Ps3SystemUser User = null)
        {
            ToogleSpinner(false);
            Ps3SystemUser user = User ?? _system.CurrentUser;
            if (user == null)
            {
                return;
            }

            LabelPsnId.Text = user?.PSNId.Replace("\0", "");
            TextBoxComment.Text = user?.Comment;
            IconAvatar.Image = _system.CurrentUser?.AVATAR;
            LabelGameTitle.Text = _system.CURRENT_GAMENAME ?? "UNKWNOWN";
            XmbImage.Image = _system.GAME_COVER ?? Properties.Resources.tex_game;
            _elapsed = _system.STARTUP_TIME ?? TimeSpan.Zero;
            _gmelapsed = _system.GAME_TIME ?? TimeSpan.Zero; LabelSysTime.Text = _elapsed.ToString();
            if (_values != null)
            {
                LabelGameElapsed.Text = _gmelapsed.ToString();
                LabelInfoFan.Text = _values[6] as string;
                LabelInfoFirmware.Text = _system.Manager.PS3.GetFirmwareVersion_Str();
                LabelInfoHdd.Text = _values[4] as string;
                LabelInfoLife.Text = _values[13] as string;
                _system.Manager.PS3.GetTemperature(out uint cpu, out uint rsx);
                LabelInfoTemp.Text = $"CPU: {cpu} RSX: {rsx}";
                LabelInfoMem.Text = _values[3] as string;
                LabelSysName.Text = _system.SystemName;
                LabelInfoFirmType.Text = _system.Manager?.PS3.GetFirmwareType();
            }
            Guna2TextBox[] _prxSlots = new Guna2TextBox[]
            {
                txt_prx_1,
                txt_prx_2,
                txt_prx_3,
                txt_prx_4,
                txt_prx_5,
                txt_prx_6,
            };
            Label[] _prxNames = new Label[]
            {
                LBL_PRX1,
                LBL_PRX2,
                LBL_PRX3,
                LBL_PRX4,
                LBL_PRX5,
                LBL_PRX6,
            };
            int index = 0;
            Console.WriteLine("RPC: " + (Properties.Settings.Default.usingRpc ? "ON" : "OFF"));
            _system.FetchPrxCollection((e, s) => ControlDelegates.Invoke(this, () =>
            {
                _prxSlots[index].Text = s[1].ToString();
                _prxNames[index].Text = s[0].ToString();
                index++;
            }));
            ToogleSpinner(false); Console.WriteLine("[!] Operation Finished.");
            Thread.Sleep(10);
            bool flag1 = Properties.Settings.Default.usingRpc;
            if (_PSCli == null & flag1)
            {
                InitRpc();
            }
            if (flag1 is false)
            {
                if (_PSCli != null)
                {
                    if (_PSCli.RpcInitialized)
                    {
                        _PSCli.Stop();
                    }
                }
            }
            else if (_PSCli != null & flag1)
            {
                if (_PSCli.RpcInitialized)
                {
                    _PSCli.SetRpc(_PSCli.CreateRPC(RpcKeywords.GetMessage(_system, Properties.Settings.Default.DiscordRpcStateFormat),
                    RpcKeywords.GetMessage(_system, Properties.Settings.Default.DiscordRpcDetailsFormat)));
                }
            }
        }
        private void CMB_debug2_Click(object sender, EventArgs e)
        {

        }
        private void CMB_debug1_Click(object sender, EventArgs e)
        {
            if (_UpdateError != null)
            {
                Console.WriteLine(_UpdateError);
                Console.WriteLine(_UpdateError.Message);
                Console.WriteLine(_UpdateError.Source);
            }
        }
        private void CMB_debug3_Click(object sender, EventArgs e)
        {

            UpdateStates();
        }
        private void cWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ListViewFriends.Items.Count);
            Console.WriteLine(ListViewGames.Items.Count);
        }
        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxComment_TextChanged(object sender, EventArgs e)
        {
            _Tooltip.SetToolTip(sender as TextBox, "Press Enter to save commentary.");
        }
        private void TextBoxComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (_system.CurrentUser == null)
                {
                    return;
                }

                if (_system.CurrentUser.Comment == (sender as TextBox).Text)
                {
                    return;
                }

                _system.CurrentUser.SetComment((sender as TextBox).Text);
            }
        }
        private void ButtonOptions_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = new GeneralOptions().ShowDialog();
            }
            else
            {
                ContextStripOptions.Show(ButtonStore, new System.Drawing.Point(ButtonStore.Size));
            }
        }
        private void regToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DebugRegReadForm(_system).Show();
        }

        private void ContextStripOptions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Environment.UserName != "visual")
            {
                debugToolStripMenuItem.Visible = false;
            }
        }

        private void debugToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
        }
        private void privateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrivateInfoMenu(_system).Show();
        }


        private void guna2Separator2_Click(object sender, EventArgs e)
        {

        }

        private void _TC_DASHBOARD_STATUS_Click(object sender, EventArgs e)
        {

        }

        private void powerOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Power(PowerFlags.ShutDown);
        }

        private void Power(PowerFlags e)
        {
            if (_system.Manager != null)
            {
                _system.Manager.PS3.Notify(e.ToString());
                _system.Manager.PS3.Power(e);
                _system.Manager.DisconnectTarget();
                new FadeForm(this).FadeOut((s, h) => Close(), this, 0);
            }
            else
            {
                _ = new MessageForm("Internal error: Manager not initialized.", "PS3 Manager API not initialized yet or returned NULL...", null, "OK");
            }
        }

        private void foutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FadeForm(this).FadeOut((s, h) => Close(), this, 0);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Power(PowerFlags.SoftReboot);
        }

        private void restartFullACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Power(PowerFlags.HardReboot);
        }

        private void ButtonPower_MouseClick(object sender, MouseEventArgs e)
        {
            StaticResources.SndOk.Play();
            ContextStripPower.Show(ButtonPower, new Point(ButtonPower.Size));
        }

        private void tESTMSGFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = new MessageForm("Internal error: Manager not initialized.", "PS3 Manager API not initialized yet or returned NULL...", null, "OK");
        }

        private void ButtonImgSignOut_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaticResources.SndOk.Play();
            Logout();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            StaticResources.SndOk.Play();
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ToogleSpinner(true, 1);
            new Thread(() => _system.UpdateValues(out Exception error, (s, ee) => { ToogleSpinner(false, 0); })).Start();
            UpdateGui();
        }

        private void TTSL_DumpFriendAvatar_Click(object sender, EventArgs e)
        {
            if (ListViewFriends.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem frn = ListViewFriends.SelectedItems[0];
                object[] dat = frn.Tag as object[];
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + $"\\{dat[0]}.png";
                Bitmap av = dat[1] as Bitmap;
                av.Save(path);
                _ = Process.Start(path);
            }
        }

        private void ListViewFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            TTSL_SelDat.Text = "Open...";
            TTSL_SelDat.Click += (s, ee) => Process.Start($"http://{_system.IP}//dev_hdd0/home/{PS3System.FormatUserId(_system.CurrentUser.USERID)}/friendim/avatar");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_prx_1_Click(object sender, EventArgs e)
        {
            _system.Manager.VSH_Plugin.Load(1, txt_prx_1.Text);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _system.Manager.VSH_Plugin.Load(2, txt_prx_2.Text);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _system.Manager.VSH_Plugin.Load(3, txt_prx_3.Text);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            _system.Manager.VSH_Plugin.Load(4, txt_prx_4.Text);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            _system.Manager.VSH_Plugin.Load(5, txt_prx_5.Text);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            _system.Manager.VSH_Plugin.Load(6, txt_prx_6.Text);
        }

        private void ListViewSaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = ListViewSaves.SelectedItems.Count > 0;
            if (flag)
            {
                ListViewItem itm = ListViewSaves.SelectedItems[0];
                if (itm.Tag != null)
                {
                    if (itm.Tag is Ps3SaveData ee)
                    {
                        string txt = ee.Values != null ? SfoDictionaryToString(ee.Values) : ee.ToString();
                        Bitmap ico = ee.Icon0 ?? Properties.Resources.item_tex_ps3util;
                        PB_SAVDATICO.Image = ico;
                        RTB_SAVDATINFO.Text = txt;
                    }
                }
            }
        }

        private void ButtonYt_Click(object sender, EventArgs e)
        {
            YTForm frm = new YTForm();
            frm.OnSucess += (s, ee)
                =>
            {
                _ytTargetVideo = ee[0] as Video;
                _ytNotEnabled = frm.Sucess;
                _ytNotInterval = int.Parse(ee[1].ToString());
                Console.WriteLine("YT " + _ytNotInterval);
            };
            _ = frm.ShowDialog();
        }

        private void YtConfigBtn_Click(object sender, EventArgs e)
        {
            ButtonYt_Click(sender, e);
        }

        private void ListViewGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = ListViewGames.Items.Count > 0;
            if (flag)
            {
                bool flag2 = ListViewGames.SelectedIndices.Count > 0;
                if (flag2)
                {
                    bool flag3 = ListViewGames.SelectedItems[0] != null;
                    if (flag3)
                    {
                        ListViewItem obj = ListViewGames.SelectedItems[0];
                        DisplayGameSelectMenu(obj.Position, obj.Tag as PS3ParamSfo);
                    }
                }
            }
            else
            {
                GameListSelectedContextMenuStrip.Close();
            }
        }

        private void ListViewGames_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void DisplayGameSelectMenu(Point location, PS3ParamSfo e)
        {
            GameListSelectedGameTitleToolStrip.Text = e.Title;
            GameListSelectedContextMenuStrip.Show(ListViewGames, location);
        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void NumericRefreshInterval_ValueChanged(object sender, EventArgs e)
        {
            _updater.Interval = (int)(NumericRefreshInterval.Value * ((decimal)1.000));
        }

        private void ButtonSendNotify_Click(object sender, EventArgs e)
        {
            try
            {
                _system.Manager.PS3.Notify(TXT_MAPI_NOTIFY.Text);
            }
            catch (NullReferenceException)
            {
                new MessageForm("Error", "Manager API not initialized yet!");

            }
            catch (Exception ex)
            {
                MessageForm.ShowException(ex);
            }
        }
    }
}
