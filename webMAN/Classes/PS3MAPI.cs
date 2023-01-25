// Decompiled with JetBrains decompiler
// Type: PS3ManagerAPI.PS3MAPI
// Assembly: HEN RTM Tool by zFxbixn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C687F458-A7E2-4DD3-B516-C68C6A7F95BF
// Assembly location: C:\Users\Kelly\Desktop\Nouveau dossier (2)\AcuraRTM_HEN_Version old.exe

using PSS3.Forms;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace PSS3
{
    public class PS3MAPI
    {
        public int PS3M_API_PC_LIB_VERSION = 288;
        public CORE_CMD Core = new CORE_CMD();
        public SERVER_CMD Server = new SERVER_CMD();
        public PS3_CMD PS3 = new PS3_CMD();
        public PROCESS_CMD Process = new PROCESS_CMD();
        public VSH_PLUGINS_CMD VSH_Plugin = new VSH_PLUGINS_CMD();

        public PS3MAPI()
        {
            Core = new CORE_CMD();
            Server = new SERVER_CMD();
            PS3 = new PS3_CMD();
            Process = new PROCESS_CMD();
        }

        public string GetLibVersion_Str()
        {
            string str = PS3M_API_PC_LIB_VERSION.ToString("X4");
            return str.Substring(1, 1) + "." + str.Substring(2, 1) + "." + str.Substring(3, 1);
        }

        public bool IsConnected => PS3MAPI_Client_Server.IsConnected;

        public bool IsAttached => PS3MAPI_Client_Server.IsAttached;

        public bool ConnectTarget(string ip, int port = 7887)
        {
            bool flag;
            try
            {
                PS3MAPI_Client_Server.Connect(ip, port);
                flag = true;
            }
            catch (Exception ex)
            {
                new MessageForm(
                $"Exception caught: {ex.GetType().FullName}", "msg: " + ex.Message + "\rSource: " + ex.Source, null, "OK");
                flag = false;
            }
            return flag;
        }
        public bool ConnectTarget(string ip, out Exception error, int port = 7887)
        {
            bool flag = false;
            try
            {
                PS3MAPI_Client_Server.Connect(ip, port);
                flag = true;
                error = null;
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return flag;
        }
        public bool AttachProcess(uint pid)
        {
            bool flag;
            try
            {
                Process.Process_Pid = pid;
                flag = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return flag;
        }
        public void DisconnectTarget()
        {
            try
            {
                PS3MAPI_Client_Server.Disconnect();
            }
            catch
            {
            }
        }
        public string Log => PS3MAPI_Client_Server.Log;

        public class SERVER_CMD
        {
            public int Timeout
            {
                get => PS3MAPI_Client_Server.Timeout;
                set => PS3MAPI_Client_Server.Timeout = value;
            }

            public uint GetVersion()
            {
                uint version;
                try
                {
                    version = PS3MAPI_Client_Server.Server_Get_Version();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return version;
            }

            public string GetVersion_Str()
            {
                string str = PS3MAPI_Client_Server.Server_Get_Version().ToString("X4");
                return str.Substring(1, 1) + "." + str.Substring(2, 1) + "." + str.Substring(3, 1);
            }
        }

        public class CORE_CMD
        {
            public uint GetVersion()
            {
                uint version;
                try
                {
                    version = PS3MAPI_Client_Server.Core_Get_Version();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return version;
            }

            public string GetVersion_Str()
            {
                string str = PS3MAPI_Client_Server.Core_Get_Version().ToString("X4");
                return str.Substring(1, 1) + "." + str.Substring(2, 1) + "." + str.Substring(3, 1);
            }
        }

        public class PS3_CMD
        {
            public uint GetFirmwareVersion()
            {
                uint fwVersion;
                try
                {
                    fwVersion = PS3MAPI_Client_Server.PS3_GetFwVersion();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return fwVersion;
            }
            public string GetFirmwareVersion_Str()
            {
                string str = PS3MAPI_Client_Server.PS3_GetFwVersion().ToString("X4");
                return str.Substring(1, 1) + "." + str.Substring(2, 1) + str.Substring(3, 1);
            }
            public string GetFirmwareType()
            {
                string firmwareType;
                try
                {
                    firmwareType = PS3MAPI_Client_Server.PS3_GetFirmwareType();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return firmwareType;
            }
            public void Power(PowerFlags flag)
            {
                try
                {
                    switch (flag)
                    {
                        case PowerFlags.ShutDown:
                            PS3MAPI_Client_Server.PS3_Shutdown();
                            break;
                        case PowerFlags.QuickReboot:
                            PS3MAPI_Client_Server.PS3_Reboot();
                            break;
                        case PowerFlags.SoftReboot:
                            PS3MAPI_Client_Server.PS3_SoftReboot();
                            break;
                        case PowerFlags.HardReboot:
                            PS3MAPI_Client_Server.PS3_HardReboot();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public void Notify(string msg)
            {
                try
                {
                    PS3MAPI_Client_Server.PS3_Notify(msg);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public void RingBuzzer(BuzzerMode mode)
            {
                try
                {
                    switch (mode)
                    {
                        case BuzzerMode.Single:
                            PS3MAPI_Client_Server.PS3_Buzzer(1);
                            break;
                        case BuzzerMode.Double:
                            PS3MAPI_Client_Server.PS3_Buzzer(2);
                            break;
                        case BuzzerMode.Triple:
                            PS3MAPI_Client_Server.PS3_Buzzer(3);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public void Led(LedColor color, LedMode mode)
            {
                try
                {
                    PS3MAPI_Client_Server.PS3_Led(Convert.ToInt32(color), Convert.ToInt32(mode));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public void GetTemperature(out uint cpu, out uint rsx)
            {
                cpu = 0U;
                rsx = 0U;
                try
                {
                    PS3MAPI_Client_Server.PS3_GetTemp(out cpu, out rsx);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public void DisableSyscall(int num)
            {
                try
                {
                    PS3MAPI_Client_Server.PS3_DisableSyscall(num);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public bool CheckSyscall(int num)
            {
                bool flag;
                try
                {
                    flag = PS3MAPI_Client_Server.PS3_CheckSyscall(num);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return flag;
            }
            public void PartialDisableSyscall8(Syscall8Mode mode)
            {
                try
                {
                    switch (mode)
                    {
                        case Syscall8Mode.Enabled:
                            PS3MAPI_Client_Server.PS3_PartialDisableSyscall8(0);
                            break;
                        case Syscall8Mode.Only_CobraMambaAndPS3MAPI_Enabled:
                            PS3MAPI_Client_Server.PS3_PartialDisableSyscall8(1);
                            break;
                        case Syscall8Mode.Only_PS3MAPI_Enabled:
                            PS3MAPI_Client_Server.PS3_PartialDisableSyscall8(2);
                            break;
                        case Syscall8Mode.FakeDisabled:
                            PS3MAPI_Client_Server.PS3_PartialDisableSyscall8(3);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public Syscall8Mode PartialCheckSyscall8()
            {
                Syscall8Mode syscall8Mode;
                try
                {
                    syscall8Mode = PS3MAPI_Client_Server.PS3_PartialCheckSyscall8() != 0 ? PS3MAPI_Client_Server.PS3_PartialCheckSyscall8() != 1 ? PS3MAPI_Client_Server.PS3_PartialCheckSyscall8() != 2 ? Syscall8Mode.FakeDisabled : Syscall8Mode.Only_PS3MAPI_Enabled : Syscall8Mode.Only_CobraMambaAndPS3MAPI_Enabled : Syscall8Mode.Enabled;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return syscall8Mode;
            }
            public void RemoveHook()
            {
                try
                {
                    PS3MAPI_Client_Server.PS3_RemoveHook();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public void ClearHistory(bool include_directory = true)
            {
                try
                {
                    PS3MAPI_Client_Server.PS3_ClearHistory(include_directory);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public string GetPSID()
            {
                string psid;
                try
                {
                    psid = PS3MAPI_Client_Server.PS3_GetPSID();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return psid;
            }
            public void SetPSID(string PSID)
            {
                try
                {
                    PS3MAPI_Client_Server.PS3_SetPSID(PSID);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public string GetIDPS()
            {
                string idps;
                try
                {
                    idps = PS3MAPI_Client_Server.PS3_GetIDPS();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return idps;
            }
            public void SetIDPS(string IDPS)
            {
                try
                {
                    PS3MAPI_Client_Server.PS3_SetIDPS(IDPS);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            public enum PowerFlags
            {
                ShutDown,
                QuickReboot,
                SoftReboot,
                HardReboot,
            }

            public enum BuzzerMode
            {
                Single,
                Double,
                Triple,
            }

            public enum LedColor
            {
                Red,
                Green,
                Yellow,
            }

            public enum LedMode
            {
                Off,
                On,
                BlinkFast,
                BlinkSlow,
            }

            public enum Syscall8Mode
            {
                Enabled,
                Only_CobraMambaAndPS3MAPI_Enabled,
                Only_PS3MAPI_Enabled,
                FakeDisabled,
                Disabled,
            }
        }

        public class PROCESS_CMD
        {
            public MEMORY_CMD Memory = new MEMORY_CMD();
            public MODULES_CMD Modules = new MODULES_CMD();
            public PROCESS_CMD()
            {
                Memory = new MEMORY_CMD();
                Modules = new MODULES_CMD();
            }
            public uint[] Processes_Pid => PS3MAPI_Client_Server.Processes_Pid;
            public uint Process_Pid
            {
                get => PS3MAPI_Client_Server.Process_Pid;
                set => PS3MAPI_Client_Server.Process_Pid = value;
            }
            public uint[] GetPidProcesses()
            {
                uint[] pidList;
                try
                {
                    pidList = PS3MAPI_Client_Server.Process_GetPidList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return pidList;
            }

            public string GetName(uint pid)
            {
                string name;
                try
                {
                    name = PS3MAPI_Client_Server.Process_GetName(pid);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                return name;
            }
            public class MEMORY_CMD
            {
                public void Set(uint Pid, ulong Address, byte[] Bytes)
                {
                    try
                    {
                        PS3MAPI_Client_Server.Memory_Set(Pid, Address, Bytes);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                }

                public void Get(uint Pid, ulong Address, byte[] Bytes)
                {
                    try
                    {
                        PS3MAPI_Client_Server.Memory_Get(Pid, Address, Bytes);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                }

                public byte[] Get(uint Pid, ulong Address, uint Length)
                {
                    byte[] numArray;
                    try
                    {
                        byte[] Bytes = new byte[(int)Length];
                        PS3MAPI_Client_Server.Memory_Get(Pid, Address, Bytes);
                        numArray = Bytes;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                    return numArray;
                }
            }
            public class MODULES_CMD
            {
                public int[] Modules_Prx_Id => PS3MAPI_Client_Server.Modules_Prx_Id;

                public int[] GetPrxIdModules(uint pid)
                {
                    int[] prxIdList;
                    try
                    {
                        prxIdList = PS3MAPI_Client_Server.Module_GetPrxIdList(pid);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                    return prxIdList;
                }

                public string GetName(uint pid, int prxid)
                {
                    string name;
                    try
                    {
                        name = PS3MAPI_Client_Server.Module_GetName(pid, prxid);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                    return name;
                }

                public string GetFilename(uint pid, int prxid)
                {
                    string filename;
                    try
                    {
                        filename = PS3MAPI_Client_Server.Module_GetFilename(pid, prxid);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                    return filename;
                }

                public void Load(uint pid, string path)
                {
                    try
                    {
                        PS3MAPI_Client_Server.Module_Load(pid, path);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                }

                public void Unload(uint pid, int prxid)
                {
                    try
                    {
                        PS3MAPI_Client_Server.Module_Unload(pid, prxid);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }
                }
            }
        }

        public class VSH_PLUGINS_CMD
        {
            public void Load(uint slot, string path)
            {
                try
                {
                    PS3MAPI_Client_Server.VSHPlugins_Load(slot, path);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            public void Unload(uint slot)
            {
                try
                {
                    PS3MAPI_Client_Server.VSHPlugins_Unload(slot);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            public void GetInfoBySlot(uint slot, out string name, out string path)
            {
                try
                {
                    PS3MAPI_Client_Server.VSHPlugins_GetInfoBySlot(slot, out name, out path);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }

        internal class PS3MAPI_Client_Web
        {
        }

        internal class PS3MAPI_Client_Server
        {
            private static readonly int ps3m_api_server_minversion = 288;
            private static string sMessages = "";
            private static string sServerIP = "";
            private static int iPort = 7887;
            private static string sBucket = "";
            private static PS3MAPI_ResponseCode eResponseCode;
            private static string sResponse;
            internal static Socket main_sock;
            internal static Socket listening_sock;
            internal static Socket data_sock;
            internal static IPEndPoint main_ipEndPoint;
            internal static IPEndPoint data_ipEndPoint;

            public static string Log { get; private set; } = "";

            public static uint[] Processes_Pid { get; private set; } = new uint[16];

            public static uint Process_Pid { get; set; } = 0;

            public static int[] Modules_Prx_Id { get; private set; } = new int[64];

            public static int Timeout { get; set; } = 5000;

            public static bool IsConnected => main_sock != null && main_sock.Connected;

            public static bool IsAttached => Process_Pid > 0U;

            internal static void Connect()
            {
                Connect(sServerIP, iPort);
            }

            internal static void Connect(string sServer, int Port)
            {
                sServerIP = sServer;
                iPort = Port;
                if (Port.ToString().Length == 0)
                {
                    throw new Exception("Unable to Connect - No Port Specified.");
                }

                if (sServerIP.Length == 0)
                {
                    throw new Exception("Unable to Connect - No Server Specified.");
                }

                if (main_sock != null && main_sock.Connected)
                {
                    return;
                }

                main_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                main_ipEndPoint = new IPEndPoint(Dns.GetHostByName(sServerIP).AddressList[0], Port);
                try
                {
                    main_sock.Connect(main_ipEndPoint);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
                ReadResponse();
                if (eResponseCode != PS3MAPI_ResponseCode.PS3MAPIConnected)
                {
                    Fail();
                }

                ReadResponse();
                if (eResponseCode != PS3MAPI_ResponseCode.PS3MAPIConnectedOK)
                {
                    Fail();
                }

                if (Server_GetMinVersion() < (ulong)ps3m_api_server_minversion)
                {
                    Disconnect();
                    throw new Exception("PS3M_API SERVER (webMAN-MOD) OUTDATED! PLEASE UPDATE.");
                }
                if (Server_GetMinVersion() > (ulong)ps3m_api_server_minversion)
                {
                    Disconnect();
                    throw new Exception("PS3M_API PC_LIB (PS3ManagerAPI.dll) OUTDATED! PLEASE UPDATE.");
                }
            }

            internal static void Disconnect()
            {
                CloseDataSocket();
                if (main_sock != null)
                {
                    if (main_sock.Connected)
                    {
                        SendCommand("DISCONNECT");
                        Process_Pid = 0U;
                        main_sock.Close();
                    }
                    main_sock = null;
                }
                main_ipEndPoint = null;
            }

            internal static uint Server_Get_Version()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("SERVER GETVERSION");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return Convert.ToUInt32(sResponse);
            }

            internal static uint Server_GetMinVersion()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("SERVER GETMINVERSION");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return Convert.ToUInt32(sResponse);
            }

            internal static uint Core_Get_Version()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("CORE GETVERSION");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return Convert.ToUInt32(sResponse);
            }

            internal static uint Core_GetMinVersion()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("CORE GETMINVERSION");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return Convert.ToUInt32(sResponse);
            }

            internal static uint PS3_GetFwVersion()
            {
                if (!IsConnected)
                {
                    Debug.WriteLine("PS3MAPI not connected!");
                    return 0;
                }

                SendCommand("PS3 GETFWVERSION");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return Convert.ToUInt32(sResponse);
            }

            internal static string PS3_GetFirmwareType()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 GETFWTYPE");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return sResponse;
            }

            internal static void PS3_Shutdown()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 SHUTDOWN");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Disconnect();
                }
                else
                {
                    Fail();
                }
            }

            internal static void PS3_Reboot()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 REBOOT");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Disconnect();
                }
                else
                {
                    Fail();
                }
            }

            internal static void PS3_SoftReboot()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 SOFTREBOOT");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Disconnect();
                }
                else
                {
                    Fail();
                }
            }

            internal static void PS3_HardReboot()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 HARDREBOOT");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Disconnect();
                }
                else
                {
                    Fail();
                }
            }

            internal static void PS3_Notify(string msg)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 NOTIFY  " + msg);
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void PS3_Buzzer(int mode)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 BUZZER" + mode.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void PS3_Led(int color, int mode)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 LED " + color.ToString() + " " + mode.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void PS3_GetTemp(out uint cpu, out uint rsx)
            {
                cpu = 0U;
                rsx = 0U;
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 GETTEMP");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                string[] strArray = sResponse.Split('|');
                cpu = Convert.ToUInt32(strArray[0], 10);
                rsx = Convert.ToUInt32(strArray[1], 10);
            }

            internal static void PS3_DisableSyscall(int num)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 DISABLESYSCALL " + num.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void PS3_ClearHistory(bool include_directory)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                if (include_directory)
                {
                    SendCommand("PS3 DELHISTORY+D");
                }
                else
                {
                    SendCommand("PS3 DELHISTORY");
                }

                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static bool PS3_CheckSyscall(int num)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 CHECKSYSCALL " + num.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return Convert.ToInt32(sResponse) == 0;
            }

            internal static void PS3_PartialDisableSyscall8(int mode)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 PDISABLESYSCALL8 " + mode.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static int PS3_PartialCheckSyscall8()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 PCHECKSYSCALL8");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return Convert.ToInt32(sResponse);
            }

            internal static void PS3_RemoveHook()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 REMOVEHOOK");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static string PS3_GetIDPS()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 GETIDPS");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return sResponse;
            }

            internal static void PS3_SetIDPS(string IDPS)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 SETIDPS " + IDPS.Substring(0, 16) + " " + IDPS.Substring(16, 16));
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static string PS3_GetPSID()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 GETPSID");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return sResponse;
            }

            internal static void PS3_SetPSID(string PSID)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PS3 SETPSID " + PSID.Substring(0, 16) + " " + PSID.Substring(16, 16));
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static string Process_GetName(uint pid)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PROCESS GETNAME " + string.Format("{0}", pid));
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return sResponse;
            }

            internal static uint[] Process_GetPidList()
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("PROCESS GETALLPID");
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                int index = 0;
                Processes_Pid = new uint[16];
                string sResponse = PS3MAPI_Client_Server.sResponse;
                char[] chArray = new char[1] { '|' };
                foreach (string str in sResponse.Split(chArray))
                {
                    if (str.Length != 0 && str != null && str != "" && str != " " && str != "0")
                    {
                        Processes_Pid[index] = Convert.ToUInt32(str, 10);
                        ++index;
                    }
                }
                return Processes_Pid;
            }

            [Obsolete]
            internal static void Memory_Get(uint Pid, ulong Address, byte[] Bytes)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SetBinaryMode(true);
                int length = Bytes.Length;
                long num1 = 0;
                bool flag = false;
                OpenDataSocket();
                SendCommand("MEMORY GET " + string.Format("{0}", Pid) + " " + string.Format("{0:X16}", Address) + " " + string.Format("{0}", Bytes.Length));
                PS3MAPI_ResponseCode eResponseCode1 = eResponseCode;
                if (eResponseCode1 != PS3MAPI_ResponseCode.DataConnectionAlreadyOpen && eResponseCode1 != PS3MAPI_ResponseCode.MemoryStatusOK)
                {
                    throw new Exception(sResponse);
                }

                ConnectDataSocket();
                byte[] buffer = new byte[Bytes.Length];
                while (!flag)
                {
                    try
                    {
                        long num2 = data_sock.Receive(buffer, length, SocketFlags.None);
                        if (num2 > 0L)
                        {
                            Buffer.BlockCopy(buffer, 0, Bytes, (int)num1, (int)num2);
                            num1 += num2;
                            if ((int)(num1 * 100L / length) >= 100)
                            {
                                flag = true;
                            }
                        }
                        else
                        {
                            flag = true;
                        }

                        if (flag)
                        {
                            CloseDataSocket();
                            ReadResponse();
                            PS3MAPI_ResponseCode eResponseCode2 = eResponseCode;
                            if (eResponseCode2 != PS3MAPI_ResponseCode.RequestSuccessful && eResponseCode2 != PS3MAPI_ResponseCode.MemoryActionCompleted)
                            {
                                throw new Exception(sResponse);
                            }

                            SetBinaryMode(false);
                        }
                    }
                    catch (Exception ex)
                    {
                        CloseDataSocket();
                        ReadResponse();
                        SetBinaryMode(false);
                        throw ex;
                    }
                }
            }

            [Obsolete]
            internal static void Memory_Set(uint Pid, ulong Address, byte[] Bytes)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SetBinaryMode(true);
                int length = Bytes.Length;
                long num1 = 0;
                long num2 = 0;
                bool flag = false;
                OpenDataSocket();
                SendCommand("MEMORY SET " + string.Format("{0}", Pid) + " " + string.Format("{0:X16}", Address));
                PS3MAPI_ResponseCode eResponseCode1 = eResponseCode;
                if (eResponseCode1 != PS3MAPI_ResponseCode.DataConnectionAlreadyOpen && eResponseCode1 != PS3MAPI_ResponseCode.MemoryStatusOK)
                {
                    throw new Exception(sResponse);
                }

                ConnectDataSocket();
                while (!flag)
                {
                    try
                    {
                        byte[] buffer = new byte[length - (int)num1];
                        Buffer.BlockCopy(Bytes, (int)num2, buffer, 0, length - (int)num1);
                        num2 = data_sock.Send(buffer, Bytes.Length - (int)num1, SocketFlags.None);
                        flag = false;
                        if (num2 > 0L)
                        {
                            num1 += num2;
                            if ((int)(num1 * 100L / length) >= 100)
                            {
                                flag = true;
                            }
                        }
                        else
                        {
                            flag = true;
                        }

                        if (flag)
                        {
                            CloseDataSocket();
                            ReadResponse();
                            PS3MAPI_ResponseCode eResponseCode2 = eResponseCode;
                            if (eResponseCode2 != PS3MAPI_ResponseCode.RequestSuccessful && eResponseCode2 != PS3MAPI_ResponseCode.MemoryActionCompleted)
                            {
                                throw new Exception(sResponse);
                            }

                            SetBinaryMode(false);
                        }
                    }
                    catch (Exception ex)
                    {
                        CloseDataSocket();
                        ReadResponse();
                        SetBinaryMode(false);
                        throw ex;
                    }
                }
            }

            internal static int[] Module_GetPrxIdList(uint pid)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE GETALLPRXID " + string.Format("{0}", pid));
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                int index = 0;
                Modules_Prx_Id = new int[128];
                string sResponse = PS3MAPI_Client_Server.sResponse;
                char[] chArray = new char[1] { '|' };
                foreach (string str in sResponse.Split(chArray))
                {
                    if (str.Length != 0 && str != null && str != "" && str != " " && str != "0")
                    {
                        Modules_Prx_Id[index] = Convert.ToInt32(str, 10);
                        ++index;
                    }
                }
                return Modules_Prx_Id;
            }

            internal static string Module_GetName(uint pid, int prxid)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE GETNAME " + string.Format("{0}", pid) + " " + prxid.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return sResponse;
            }

            internal static string Module_GetFilename(uint pid, int prxid)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE GETFILENAME " + string.Format("{0}", pid) + " " + prxid.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                return sResponse;
            }

            internal static void Module_Load(uint pid, string path)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE LOAD " + string.Format("{0}", pid) + " " + path);
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void Module_Unload(uint pid, int prx_id)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE UNLOAD " + string.Format("{0}", pid) + " " + prx_id.ToString());
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void VSHPlugins_GetInfoBySlot(uint slot, out string name, out string path)
            {
                name = "";
                path = "";
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE GETVSHPLUGINFO " + string.Format("{0}", slot));
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode != PS3MAPI_ResponseCode.CommandOK && eResponseCode != PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    Fail();
                }

                string[] strArray = sResponse.Split('|');
                name = strArray[0];
                path = strArray[1];
            }

            internal static void VSHPlugins_Load(uint slot, string path)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE LOADVSHPLUG " + string.Format("{0}", slot) + " " + path);
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void VSHPlugins_Unload(uint slot)
            {
                if (!IsConnected)
                {
                    throw new Exception("PS3MAPI not connected!");
                }

                SendCommand("MODULE UNLOADVSHPLUGS " + string.Format("{0}", slot));
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            internal static void Fail()
            {
                Fail(new Exception("[" + eResponseCode.ToString() + "] " + sResponse));
            }

            internal static void Fail(Exception e)
            {
                Disconnect();
                throw e;
            }

            internal static void SetBinaryMode(bool bMode)
            {
                SendCommand("TYPE" + (bMode ? " I" : " A"));
                PS3MAPI_ResponseCode eResponseCode = PS3MAPI_Client_Server.eResponseCode;
                if (eResponseCode == PS3MAPI_ResponseCode.CommandOK || eResponseCode == PS3MAPI_ResponseCode.RequestSuccessful)
                {
                    return;
                }

                Fail();
            }

            [Obsolete]
            internal static void OpenDataSocket()
            {
                Connect();
                SendCommand("PASV");
                if (eResponseCode != PS3MAPI_ResponseCode.EnteringPassiveMode)
                {
                    Fail();
                }

                string[] strArray;
                try
                {
                    int startIndex = sResponse.IndexOf('(') + 1;
                    int length = sResponse.IndexOf(')') - startIndex;
                    strArray = sResponse.Substring(startIndex, length).Split(',');
                }
                catch
                {
                    Fail(new Exception("Malformed PASV response: " + sResponse));
                    throw new Exception("Malformed PASV response: " + sResponse);
                }
                if (strArray.Length < 6)
                {
                    Fail(new Exception("Malformed PASV response: " + sResponse));
                }

                _ = string.Format("{0}.{1}.{2}.{3}", strArray[0], strArray[1], strArray[2], strArray[3]);
                int port = (int.Parse(strArray[4]) << 8) + int.Parse(strArray[5]);
                try
                {
                    CloseDataSocket();
                    data_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    data_ipEndPoint = new IPEndPoint(Dns.GetHostByName(sServerIP).AddressList[0], port);
                    data_sock.Connect(data_ipEndPoint);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to connect for data transfer: " + ex.Message);
                }
            }

            internal static void ConnectDataSocket()
            {
                if (data_sock != null)
                {
                    return;
                }

                try
                {
                    data_sock = listening_sock.Accept();
                    listening_sock.Close();
                    listening_sock = null;
                    if (data_sock == null)
                    {
                        throw new Exception("Winsock error: " + Convert.ToString(Marshal.GetLastWin32Error()));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to connect for data transfer: " + ex.Message);
                }
            }

            internal static void CloseDataSocket()
            {
                if (data_sock != null)
                {
                    if (data_sock.Connected)
                    {
                        data_sock.Close();
                    }

                    data_sock = null;
                }
                data_ipEndPoint = null;
            }

            internal static void ReadResponse()
            {
                sMessages = "";
                string lineFromBucket;
                while (true)
                {
                    lineFromBucket = GetLineFromBucket();
                    if (!Regex.Match(lineFromBucket, "^[0-9]+ ").Success)
                    {
                        sMessages = sMessages + Regex.Replace(lineFromBucket, "^[0-9]+-", "") + "\n";
                    }
                    else
                    {
                        break;
                    }
                }
                sResponse = lineFromBucket.Substring(4).Replace("\r", "").Replace("\n", "");
                eResponseCode = (PS3MAPI_ResponseCode)int.Parse(lineFromBucket.Substring(0, 3));
                Log = Log + "RESPONSE CODE: " + eResponseCode.ToString() + Environment.NewLine;
                Log = Log + "RESPONSE MSG: " + sResponse + Environment.NewLine + Environment.NewLine;
            }

            internal static void SendCommand(string sCommand)
            {
                Log = Log + "COMMAND: " + sCommand + Environment.NewLine;
                Connect();
                byte[] bytes = Encoding.ASCII.GetBytes((sCommand + "\r\n").ToCharArray());
                _ = main_sock.Send(bytes, bytes.Length, SocketFlags.None);
                ReadResponse();
            }

            internal static void FillBucket()
            {
                byte[] numArray = new byte[512];
                int num1 = 0;
                while (main_sock.Available < 1)
                {
                    Thread.Sleep(50);
                    num1 += 50;
                    if (num1 > Timeout)
                    {
                        Fail(new Exception("Timed out waiting on server to respond."));
                    }
                }
                if (main_sock != null)
                {
                    while (main_sock.Available > 0)
                    {
                        long num2 = main_sock.Receive(numArray, 512, SocketFlags.None);
                        sBucket += Encoding.ASCII.GetString(numArray, 0, (int)num2);
                        Thread.Sleep(50);
                    }
                }

            }

            internal static string GetLineFromBucket()
            {
                int length;
                for (length = sBucket.IndexOf('\n'); length < 0; length = sBucket.IndexOf('\n'))
                {
                    FillBucket();
                }

                string str = sBucket.Substring(0, length);
                sBucket = sBucket.Substring(length + 1);
                return str;
            }

            internal enum PS3MAPI_ResponseCode
            {
                DataConnectionAlreadyOpen = 125, // 0x0000007D
                MemoryStatusOK = 150, // 0x00000096
                CommandOK = 200, // 0x000000C8
                PS3MAPIConnected = 220, // 0x000000DC
                RequestSuccessful = 226, // 0x000000E2
                EnteringPassiveMode = 227, // 0x000000E3
                PS3MAPIConnectedOK = 230, // 0x000000E6
                MemoryActionCompleted = 250, // 0x000000FA
                MemoryActionPended = 350, // 0x0000015E
            }
        }
    }
}
