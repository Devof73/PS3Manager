using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PSS3.Classes
{
    public class MonitoredMapi
    {
        private int _port = 7887;
        private IPAddress _address;
        private PS3MAPI _mapi;
        public event EventHandler<bool> ConnectionStateChanged;
        public event EventHandler<OperationResult> Connected;
        public event EventHandler<OperationResult> Disconnected;
        public event EventHandler<OperationResult> Spawned;
        public event EventHandler<OperationResult> OperationFinished;


        public MonitoredMapi(PS3MAPI manager, IPAddress address, int port)
        {
            _mapi = manager;
            _address = address;
            _port = port;
            InvokeEH(Spawned, new OperationResult("spawn", null));
        }
        public bool Connect(int waittimeout = 1300)
        {
            try
            {
                new Thread(() =>
                {
                    _mapi.ConnectTarget(_address.ToString(), _port); Thread.Sleep(waittimeout);
                }).Start();
                Console.WriteLine("hereee");
                InvokeEH(OperationFinished, new OperationResult("finished", null));
                return _mapi.IsConnected;
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
                InvokeEH(OperationFinished, new OperationResult("NOTconnected", e));
                return false;
            }

        }
        public void Disconnect() { }
        private void InvokeEH<T>(EventHandler<T> e, T value) => e?.Invoke(this, value);

    }
    public class OperationResult : EventArgs
    {
        public OperationResult(string name, Exception error)
        {
            var ea = new OperationResult();
            ea.name = name;
            ea.result = failed == false;
            ea.failed = error != null;
            ea.error = error;
        }
        private OperationResult() { }
        private OperationResult(string name, bool result, Exception error, bool failed)
        {
            var ea = new OperationResult();
            ea.name = name; ea.result = result; ea.error = error; ea.failed = failed;
        }
        public string name;
        public bool result;
        public Exception error;
        public bool failed;
    }
}
