/*
 * PS3 WEBMAN
    by D.s.j. 
    Discord = d.s.j.#0598
    YouTube = destru0036
    Version 2.5
*/

using Org.BouncyCastle.Crmf;
using PSS3.Classes.PS3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace PSS3.Classes
{

    public class PS3WebMan
    {
        private string _address = null;
        public PS3WebMan(string address) { _address = address; }
        private PS3WebMan() { }
        private static string wm_ps3_html;
        private string GetHtml(string systemAddress)
        {
            return GetWebString("http://" + systemAddress + "/cpursx.ps3");
        }
        private string GetLifeTimeString()
        {
            //src='/dev_hdd0/tmp/wm_icons/power.png' style='position:relative;top:8px;'>
            var clave = "src='/dev_hdd0/tmp/wm_icons/power.png' style='position:relative;top:8px;'>";
            var html = wm_ps3_html;
            var indiceClave = html.IndexOf(clave);
            if (indiceClave == -1) return "♾️";
            else
            {
                var valor = html.Substring(indiceClave + clave.Length);
                var clave2 = "</H1><hr><h2><input type=button onclick=";
                var indiceClave2 = valor.IndexOf(clave2);
                if (indiceClave2 == -1) return valor.Substring(0, 20);
                else
                {
                    valor = valor.Substring(0, indiceClave2);
                    return valor;
                }
            }
        }
        private TimeSpan GetGameTime()
        {
            var clave = "<hr><label title=\"Play\">&#9737;</label> ";
            var html = wm_ps3_html;
            var indiceClave = html.IndexOf(clave);
            if (indiceClave == -1) return TimeSpan.Zero;
            else
            {
                var valor = html.Substring(indiceClave + clave.Length);
                valor = valor.Substring(3, 8);
                return TimeSpan.Parse(valor);
            }
        }
        private Bitmap GetPSNAvatar(string ip, int userid)
        {
            try
            {
                var usdirbase = userid == 0 ? "no" : string.Format("http://{0}/dev_hdd0/home/00000000", ip);
                string s_ps3usdir = usdirbase.Substring(0, usdirbase.Length - userid.ToString().Length) + userid;
                return Misc.DownloadBitmap(s_ps3usdir + "/friendim/avatar/me.png");

            }
            catch
            {
                return Properties.Resources.tex_Avatar_Default;
            }

        }
        public static string GetGameUrl()
        {
            /// </a> &nbsp; <a href="/
            var key = " </a> &nbsp; <a href=\"/";
            var ind = wm_ps3_html.IndexOf(key);
            var indd = ind + key.Length - 1;
            if (ind == -1) return "unknown";
            else
            {
                var key2 = "\"><img src=\"";
                var rest = wm_ps3_html.Remove(0, indd);
                var ind2 = rest.IndexOf(key2);
                if (ind2 == -1) return "unknown";
                else
                {
                    return rest.Substring(0, ind2);
                }
            }
        }

        private static string GetWebString(string url)
        {
            string appURL = url;
            HttpWebRequest wrWebRequest = WebRequest.Create(appURL) as HttpWebRequest;
            HttpWebResponse hwrWebResponse = (HttpWebResponse)wrWebRequest.GetResponse();

            StreamReader srResponseReader = new StreamReader(hwrWebResponse.GetResponseStream());
            string strResponseData = srResponseReader.ReadToEnd();
            return strResponseData;
        }

        private string GetLocalUserName(string dirpath) => Encoding.UTF8.GetString(new WebClient().DownloadData($"{dirpath}/localusername"));
        private static string HtmlToText(string Html)
        {
            // Remove new lines since they are not visible in HTML
            Html = Html.Replace("\n", " ");
            // Remove tab spaces
            Html = Html.Replace("\t", "\r");
            // Remove multiple white spaces from HTML
            Html = Regex.Replace(Html, "\\s+", "\r");
            // Remove HEAD tag
            Html = Regex.Replace(Html, "<head.*?</head>", ""
                                , RegexOptions.IgnoreCase | RegexOptions.Singleline);
            // Remove any JavaScript
            Html = Regex.Replace(Html, "<script.*?</script>", ""
              , RegexOptions.IgnoreCase | RegexOptions.Singleline);
            // Replace special characters like &, <, >, " etc.
            StringBuilder sbHTML = new StringBuilder(Html);
            // Note: There are many more special characters, these are just
            // most common. You can add new characters in this arrays if needed
            string[] OldWords = {"&nbsp;", "&amp;", "&quot;", "&lt;",
    "&gt;", "&reg;", "&copy;", "&bull;", "&trade;","&#39;"};
            string[] NewWords = { " ", "&", "\"", "<", ">", "Â®", "Â©", "â€¢", "â„¢", "\'" };
            for (int i = 0; i < OldWords.Length; i++)
            {
                _ = sbHTML.Replace(OldWords[i], NewWords[i]);
            }
            // Check if there are line breaks (<br>) or paragraph (<p>)
            _ = sbHTML.Replace("<br>", "\n<br>");
            _ = sbHTML.Replace("<br ", "\n<br ");
            _ = sbHTML.Replace("<p ", "\n<p ");
            // Finally, remove all HTML tags and return plain text
            return Regex.Replace(
              sbHTML.ToString(), "<[^>]*>", "");
        }
        private string GetInGameName()
        {
            string result;
            try
            {
                string html = wm_ps3_html;
                string codetext = html.Replace("&nbsp;", "[DSJ_INDEX_DETECTOR]");
                int fkeyIndex = codetext.IndexOf("[DSJ_INDEX_DETECTOR]") - 5;
                string trashvalue = "http://google.com/search?q=";
                int trashCountIndex = codetext.IndexOf(trashvalue) + 27;
                codetext = codetext.Remove(0, trashCountIndex);
                codetext = codetext.Remove(fkeyIndex);
                string trashvalue2 = "</a> [DSJ_INDEX_DETECTOR]";
                int tsv2_Index = codetext.IndexOf(trashvalue2);
                codetext = codetext.Remove(tsv2_Index);
                string lastseparator = "\">";
                codetext = codetext.Remove(codetext.IndexOf(lastseparator));
                codetext = codetext.Replace("Â", "");
                result = codetext;
                //MessageBox.Show(codetext);

            }
            catch
            {
                result = "VSH";
            }

            return result;
        }
        private string GetWMVersion()
        {
            //<hr color="blue"/>webMAN
            var html = wm_ps3_html.IndexOf("<hr color=\"blue\"/>" + "<hr color=\"blue\"/>".Length);
            if (html == -1) return "";
            else
            {
                return wm_ps3_html.Substring(html, 10);
            }
        }
        private string GetTempString()
        {
            string HTML = wm_ps3_html;
            try
            {
                int keyIndex_1 = HTML.IndexOf("CPU:");
                int keyIndex_2 = HTML.IndexOf("RSX:");

                string i_cpu = HTML.Substring(keyIndex_1, 10);
                string i_rsx = HTML.Substring(keyIndex_2, 10);
                string str = i_cpu + " " + i_rsx;
                str = str.Replace("Â", "").Replace("^", ""); ;
                return str;
            }
            catch
            {
                return "";
            }


        }
        private string GameRootImageUrl(string ip)
        {
            int keyIndex = wm_ps3_html.IndexOf("<img src=\"/dev_hdd0/game/");
            if (keyIndex == -1)
            {
                return "https://allvectorlogo.com/img/2016/05/xmb-logo.png";
            }

            string keyString = wm_ps3_html.Substring(keyIndex, 44);
            keyString = keyString.Replace("<img src=\"", "");
            return "http://" + ip + keyString;
        }
        private string GetMemoryRest()
        {
            string HTML = wm_ps3_html;
            string key = ">MEM: ";
            int keyIndex = HTML.IndexOf(key);
            string trims = HTML.Remove(0, keyIndex) + 5;
            string trime = trims.Substring(0, trims.IndexOf("</a><br><a href=\"/dev_hdd0\""));
            return trime;
        }
        private string GetHdd0()
        {
            string HTML = wm_ps3_html;
            string key = "/a><br><a href=\"/dev_hdd0\">";
            int keyIndex = HTML.IndexOf(key);
            string value = HTML.Substring(keyIndex + 27, 12);

            return value;
        }
        private int GetCurrentUserId()
        {
            string HTML = wm_ps3_html;
            int id = 0;
            string key = "/dev_hdd0/home/00000";
            int FIndex = HTML.IndexOf(key) + "/dev_hdd0/home/".Length;
            string FValue = HTML.Substring(FIndex, 8);
            Console.WriteLine(FValue);
            int.TryParse(FValue, out id);
            return id;
        }
        private string GetCurrentUserDirectory(string wm_ps3_html_cpursx)
        {

            int index = wm_ps3_html_cpursx.IndexOf("<br><a href=\"/dev_hdd0/home/");
            if (index == -1)
            {
                return "unknown";
            }

            string html = wm_ps3_html_cpursx.Remove(0, index)
            ;
            if (html.Length != 0)
            {
                string value = html.Remove(0, html.IndexOf("<br><a href=\"") + " <br><hr><a href=\"".Length - 5);
                return value.Substring(0, value.IndexOf("\">"));
            }
            else
            {
                return "unknown";
            }
        }
        private string GetCurrentFanSpeed()
        {
            try
            {
                string HTML = wm_ps3_html;
                string keyToSearch = "href=\"/cpursx.ps3?mode\"";
                int FPhraseIndex = HTML.IndexOf(keyToSearch);
                string Fvalue = HTML.Substring(FPhraseIndex + 24, 21);
                return Fvalue.Replace("VEL. FAN: ", "");
            }
            catch
            {
                return "";
            }


        }

        private Bitmap GetCurrentGamePic(string ip)
        {
            try
            {
                string link = "http://" + ip + GetGameUrl() + "//ICON0.PNG";
                WebRequest request =
                WebRequest.Create(link);

                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                Bitmap bmp = (Bitmap)Bitmap.FromStream(responseStream);
                return bmp;

            }
            catch
            {
                return null;
            }

        }
        private Bitmap GetUserAvatar(string ip, long userid)
        {
            try
            {
                string dir = $"ftp://{ip}//dev_hdd0/home/{userid}//";
                string format = "{0}/friendim/avatar/me.png";
                WebRequest request =
                WebRequest.Create(string.Format(format, dir));
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                Bitmap bmp = (Bitmap)(Bitmap.FromStream(responseStream));
                response.Close();
                responseStream.Close();
                return bmp;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(error.Source);
                Console.WriteLine(error.HResult);
                Console.WriteLine(error.HelpLink);
                return SystemIcons.Error.ToBitmap();
            }
        }
        private string GetFirmware()
        {
            try
            {
                int keyIndex = wm_ps3_html.IndexOf("<a class=\"s\" href=\"/setup.ps3\">");
                return wm_ps3_html.Substring(keyIndex + 31, 19).Replace("FIRMWARE : ", "");
            }
            catch
            {
                return "";
            }

        }
        private TimeSpan GetStartupElapsedTime()
        {
            //img src='/dev_hdd0/tmp/wm_icons/time.png' border=0 style='position:relative;top:8px;'></label>
            string HTML = wm_ps3_html;
            var key = "img src='/dev_hdd0/tmp/wm_icons/time.png' border=0 style='position:relative;top:8px;'></label>";
            int keyIndex = HTML.IndexOf(key) + key.Length;
            var trash = HTML.Substring(0, keyIndex);
            var outr = HTML.Replace(trash, "").Substring(5, 7);
            return TimeSpan.Parse(outr);
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
        public object[] GetServerInfoValues(out Exception error, string altip = null)
        {
            try
            {
                string HTML;
                var ip = altip ?? _address;
                HTML = wm_ps3_html = GetHtml(ip);
                var userid = GetCurrentUserId();
                string s_wmver = GetWMVersion();
                string s_ps3ver = GetFirmware().ToUpper().Replace("FIRMWARE : ", "");
                var usdirbase = userid == 0 ? "no" : string.Format("http://{0}/dev_hdd0/home/00000000", ip);
                string s_ps3usdir = usdirbase.Substring(0, usdirbase.Length - userid.ToString().Length) + userid;
                string s_ps3mem = GetMemoryRest().Replace("<", "").Replace("&lt", "").Substring("\">MEM:".Length, 4);
                string s_ps3hdd = GetHdd0().Substring(5, 4);
                string s_ps3game = GetInGameName();
                string s_ps3fan = GetCurrentFanSpeed().Substring(1, 4);
                string s_ps3temp = GetTempString();

                var l = new List<object>() { s_wmver, s_ps3ver, s_ps3usdir, s_ps3mem, s_ps3hdd, s_ps3game, s_ps3fan, s_ps3temp, userid };
                var a = userid == 0 ? Properties.Resources.tex_Avatar_Default : GetPSNAvatar(ip, userid);
                var b = userid == 0 ? "User1" : GetLocalUserName(s_ps3usdir);

                var c = userid == 0 ? Properties.Resources.ps : GetCurrentGamePic(ip);

                l.Add(a);
                l.Add(b);
                l.Add(c);
                l.Add(GetStartupElapsedTime());
                l.Add(GetLifeTimeString());
                l.Add(GetGameTime());
                error = null;
                return l.ToArray();
            }
            catch (Exception eee)
            {
                Console.WriteLine(eee.ToString());
                Misc.Log("Error => " + eee.Message);
                error = eee;
                return null;
            }

        }
        private void RunNewThread
            (Action e, string name = "",
            ThreadPriority prior = ThreadPriority.Normal,
            bool background = false, bool join = false)
        {
            Thread t = new Thread(() =>
            { e.Invoke(); })
            { Name = name, Priority = prior, IsBackground = background };
            if (join) { t.Start(); t.Join(); }
            else
            {
                t.Start();
            }
        }

    }

}



