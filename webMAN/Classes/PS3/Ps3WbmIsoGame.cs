using System;

namespace PSS3.Classes.PS3
{
    public class Ps3WbmIsoGame
    {
        private PS3System _origin = null;
        private string _accessUrl = null;
        private PS3ParamSfo _param = null;
        public PS3System System { get => _origin; }
        public PS3ParamSfo PARAM { get => _param; }
        public string AccessUrl { get => _accessUrl; }
        public Ps3WbmIsoGame(PS3System sys, string url)
        {
            if (sys == null || url == null) throw new ArgumentNullException("url || sys");
            _origin = sys;
            _accessUrl = url;
        }
        public void Mount(PS3System e)
        {

        }
        private Ps3WbmIsoGame() { }
    }
}
