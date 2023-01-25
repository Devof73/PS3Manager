
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Crypto;
using PSS3.Classes.PS3;
using System;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS3.Classes
{
    public class PS3System
    {
        private Ps3SystemUser[] _users;
        private Ps3Directory _rootFolder;
        private PS3MAPI _manager;
        private Ps3Directory _packages;
        private Ps3Games _games;
        private Command _commander;
        private PS3WebMan _webMAN;
        public event EventHandler<Exception> Error;
        public string WM_VERSION { get; private set; }
        public string SYS_VER { get; private set; }
        public int FAN_SPEED { get; private set; }
        public string TEMPERATURE { get; private set; }
        public TimeSpan? STARTUP_TIME { get; private set; }
        public TimeSpan? GAME_TIME { get; private set; }
        public string CURRENT_GAMENAME { get; private set; }
        public Bitmap GAME_COVER { get; private set; }
        public Ps3SaveData[] SaveDatasCurrentUser { get; private set; }
        public object[] Values { get; private set; }
        public Ps3SystemUser CurrentUser { get; private set; }
        public string SystemName { get; private set; }
        public Ps3FileTransferProtocol Ps3Ftp { get => _ps3ftp; }
        public event EventHandler<ReceivedParamEventArgs> OnParamReceived;
        public event EventHandler<DataUpdatedEventArgs> OnValuesUpdated;
        public event EventHandler<object[]> OnNewFriendDetected;
        public event EventHandler<Ps3SystemUser> OnUserChanged;
        public static PS3System FromIpAddress(IPAddress address) => new PS3System(address.ToString());
        private string _url;
        private Ps3FileTransferProtocol _ps3ftp = null;
        public string AccessUrl { get => _url; }
        public string IP { get; set; }
        public int PORT { get; set; }
        public bool IsInitialized { get; private set; }
        public bool IsBusy { get; private set; }
        public NetworkCredential Credentials { get; set; }
        public PS3System()
        {
            IsInitialized = false;
        }
        public PS3System(string ip, int? port = null,
            NetworkCredential credentials = null,
            EventHandler OnInit = null,
            EventHandler OnInitFinish = null,
            EventHandler<int> onInitProgress = null,
            EventHandler<ReceivedParamEventArgs> OnParamReceived = null,
              EventHandler<object[]> OnNewFriend = null, EventHandler<DataUpdatedEventArgs> OnValuesUpdated = null, EventHandler<Ps3SaveData> OnSaveDataDetected = null)
        {
            try
            {
                this.OnParamReceived = OnParamReceived;
                this.OnNewFriendDetected = OnNewFriend;
                this.OnValuesUpdated = OnValuesUpdated;
                Init(ip, port, credentials, OnInit, OnInitFinish, onInitProgress, OnSaveDataDetected);
            }
            catch (Exception ee)
            {
                Error?.Invoke(this, ee);
                throw new InvalidOperationException("An error ocurred.");
            }

        }
        public void Init(string ip, int? port = null, NetworkCredential credentials = null, EventHandler OnInit = null, EventHandler OnInitFinish = null, EventHandler<int> onInitProgress = null, EventHandler<Ps3SaveData> OnSaveDataDetected = null)
        {
            IPAddress ipa;
            IPAddress.TryParse(ip, out ipa);
            PORT = port ?? 7887;
            Credentials = credentials ?? new NetworkCredential("", "");
            Console.WriteLine("[!] Ps3 Initializing...");
            if (ipa != null)
            {
                OnInit?.Invoke(this, new EventArgs());
                var T1 = new Thread(() =>
                {
                    _url = $"ftp://{ipa}";
                    IP = ip;
                    _webMAN = new PS3WebMan(ip);
                    SystemName = GetPS3Name();
                    _ps3ftp = Ps3FileTransferProtocol.FromSystem(this); onInitProgress?.Invoke(this, 15);
                    _users = Ps3SystemUser.FromSystem(this); onInitProgress?.Invoke(this, 25);
                    Misc.Log("Initialized users and ftp.");
                    _commander = Command.Instance(this);
                    _manager = new PS3MAPI(); onInitProgress?.Invoke(this, 35);
                    Misc.Log("Initialized commands and manager...");
                    _rootFolder = Ps3Directory.FromSystem(this, "/dev_hdd0");
                    _packages = Ps3Directory.FromSystem(this, "/dev_hdd0/packages");
                    _games = Ps3Games.FromSystem(this); onInitProgress?.Invoke(this, 90);
                    UpdateValues(out Exception e, null, OnSaveDataDetected);
                    Thread.Sleep(300);
                    // SaveDatasCurrentUser = Ps3SaveData.FromSystem(this, CurrentUser.USERID, OnSaveDataDetected);
                    Misc.Log("Operation about to finish..."); onInitProgress?.Invoke(this, 70);
                    Misc.Log("Operation finished..."); onInitProgress.Invoke(this, 100);
                    OnInitFinish?.Invoke(this, new EventArgs());
                    IsInitialized = true;
                });
                T1.Start();
            }
            else throw new ArgumentException("Invalid IP.");
        }
        public void FetchPrxCollection(EventHandler<object[]> onReceived)
        {

            new Thread(() =>
            {
                for (int i = 0; i < 6; i++)
                {
                    _manager.VSH_Plugin.GetInfoBySlot((uint)i, out string name, out string path);
                    onReceived?.Invoke(this, new object[] { name, path });
                }
            }).Start();
        }

        public void RefreshUser(Ps3SystemUser old, Ps3SystemUser @new, EventHandler OnFinished, EventHandler<Ps3SaveData> OnSaveDataDetected = null)
        {
            var t1 = new Thread(() =>
            {
                if (old != null)
                {
                    Misc.Log($"User {old.LocalUserName} logged out. Current user now is {@new.LocalUserName}");
                }
                else
                {
                    Misc.Log($"Current user now is {@new.LocalUserName}");
                }
                SaveDatasCurrentUser = Ps3SaveData.FromSystem(this, CurrentUser.USERID, OnSaveDataDetected);
                OnUserChanged?.Invoke(this, @new);
            });
            t1.Start();
            var t2 = new Thread(() =>
            {
                while (t1.IsAlive)
                {
                    Thread.Sleep(5);
                }
                OnFinished?.Invoke(null, null);
            });
            t2.Start();
        }
        public void SendCommand(string command) => _commander.Do(command);
        internal void OnParamReceivedEvent(object sender, in PS3ParamSfo e)
        {
            Misc.Log("Param received with title: " + e.Title);
            OnParamReceived?.Invoke(sender, new ReceivedParamEventArgs(e));
        }
        internal void OnValuesUpdatedEvent(object sender, Ps3SystemUser user, object[] values)
        {
            OnValuesUpdated?.Invoke(sender, new DataUpdatedEventArgs(user, values));
        }
        internal void OnFriendDetected(object sender, string name, Bitmap Icon)
        {
            if (CurrentUser == null)
            {
                OnNewFriendDetected?.Invoke(sender ?? this, new object[] { name, Icon });
                return;
            }
            else if (!CurrentUser.FriendNames.Contains(new Ps3Property("text", "friend", Icon)))
            {
                OnNewFriendDetected?.Invoke(sender ?? this, new object[] { name, Icon });
            }
        }
        public Ps3SystemUser[] Users { get => _users; }

        public Ps3Directory RootFolder { get => _rootFolder; }
        /// <summary>
        /// WebMan client of this system.
        /// </summary>
        public PS3WebMan webMAN { get => _webMAN; }
        /// <summary>
        /// WEBMANs Manager API Client of this system.
        /// </summary>
        public PS3MAPI Manager { get => _manager; }
        /// <summary>
        /// List of dev_hdd0 games on this system.
        /// </summary>
        public Ps3Games PsnGames { get => _games; }
        /// <summary>
        /// List of packages 
        /// </summary>
        public Ps3Directory Packages { get => _packages; }
        public static bool IsTitleId(in string titleId)
        {
            var flag1 = titleId.Length == 8;
            if (!flag1) return false;
            bool flag2 = true;

            foreach (char c in titleId.Substring(4))
            {
                if (char.IsNumber(c)) return false;
            }
            return flag1 & flag2;
        }
        internal bool _firstUpdate = true;
        public object[] UpdateValues(out Exception error, EventHandler UserRefreshingFinished, EventHandler<Ps3SaveData> OnSaveDataDetected = null)
        {
            IsBusy = true;
            try
            {

                var Values = webMAN.GetServerInfoValues(out error, null);
                Thread.Sleep(300);
                if (error != null)
                {
                    Console.WriteLine(error);
                    Console.WriteLine(error.Message);
                    Console.WriteLine(error.Source);
                    return null;
                }

                WM_VERSION = (string)Values[0];
                SYS_VER = (string)Values[1];
                STARTUP_TIME = (TimeSpan)Values[12];
                GAME_COVER = (Bitmap)Values[11];
                FAN_SPEED = int.Parse(((string)Values[6]).Replace("%", ""));
                CURRENT_GAMENAME = Values[5] as string;
                GAME_TIME = (TimeSpan)Values[14];
                var newuser = Ps3SystemUser.ParseFromDirectory(((string)Values[2]).Replace("ftp://", "http:"), this);
                var olduser = CurrentUser;
                CurrentUser = newuser;
                TEMPERATURE = Values[7] as string;
                var id = (CurrentUser?.USERID) ?? 0;
                this.Values = Values;

                if (newuser != null & newuser.USERID != id & olduser != null)
                {
                    this.OnUserChanged?.Invoke(webMAN, newuser);
                    RefreshUser(olduser, newuser, UserRefreshingFinished, OnSaveDataDetected);
                }
                else if (olduser == null & _firstUpdate)
                {
                    RefreshUser(olduser, newuser, UserRefreshingFinished, OnSaveDataDetected);
                }
                OnValuesUpdatedEvent(this, CurrentUser, Values);
                _firstUpdate = false;
                IsBusy = false;
                return Values;

            }
            catch (Exception ee)
            {
                Error?.Invoke(this, ee);
                error = null;
                IsBusy = false;
                return null;
            }
        }
        public class ReceivedParamEventArgs : EventArgs
        {
            public PS3ParamSfo SFO { get; private set; }
            public ReceivedParamEventArgs(PS3ParamSfo sfo)
            {
                SFO = sfo;
            }
        }
        public class DataUpdatedEventArgs : EventArgs
        {
            public object[] values;
            public Ps3SystemUser _user;
            public DataUpdatedEventArgs(Ps3SystemUser user, object[] values)
            {
                _user = user;
                this.values = values;
            }
        }
        private string GetPS3Name()
        {
            try
            {
                var key = "/setting/system/nickname";
                var location = "/dev_flash2/etc/xRegistry.sys";
                byte[] xreg = Misc.DownloadData($"http://{IP}{location}");
                var dir = Environment.GetEnvironmentVariable("TEMP");
                var local = dir + "\\p3manager.sys";
                File.WriteAllBytes(local, xreg);

                var regr = new PS3RegRead();
                regr.Load(local);
                Thread.Sleep(400);
                foreach (var entry in regr.DataEntries)
                {
                    if (entry.FileNameEntry != null)
                    {
                        if (entry.FileNameEntry.Setting == key)
                        {
                            return entry.ValueString;
                        }
                    }
                }
                return null;
            }
            catch
            {
                return $"UNK_PS3{new Random().Next(10000000)}";
            }

        }
        public static string FormatUserId(int userid)
        {
            var s = "00000000";
            var usts = userid.ToString();
            s = s.Substring(0, s.Length - usts.Length);
            return s + usts;
        }
        public static bool IsWebMAN(string ip)
        {
            string url = $"ftp://{ip}/dev_hdd0/tmp/wmtmp";
            return Misc.FtpDirExists(url);
        }
    }
}