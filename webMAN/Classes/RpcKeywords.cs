using PSS3.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PSS3.Classes
{
    internal class RpcKeywords
    {
        static string[] keys = {
        "GAMETITLE",
        "CPU/RSX",
        "LIFETIME",
        "STARTUPTIME",
        "STARTTIME",
        "USERID",
        "PSNID",
        "LOCALUSERNAME",
        "HDDREST",
        "MEM",
        "FRIENDCOUNT",
        "SAVEDATACOUNT",
        };
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
        public static string[] GetValues(PS3System sys)
        {
            return new string[]
            {
                sys.CURRENT_GAMENAME,
                sys.TEMPERATURE,
                sys.Values[13] as string,
                sys.STARTUP_TIME.ToString(),
                sys.Values[12] as string,
                sys.CurrentUser.USERID.ToString(),
                sys.CurrentUser.PSNId.ToString(),
                sys.CurrentUser.LocalUserName.ToString(),
                sys.Values[4].ToString(),
                sys.Values[3].ToString(),
                sys.CurrentUser.FriendNames.Length.ToString(),
                (sys.SaveDatasCurrentUser != null ? sys.SaveDatasCurrentUser .Length : 0).ToString(),

            };
        }
        public static string GetMessage(PS3System sys, string format)
        {
            try
            {
                int i = 0;
                var values = GetValues(sys);
                foreach (string key in keys)
                {
                    format = format.Replace("{" + key + "}", values[i]);
                    i++;
                }
                return format.Replace("}", "").Replace("{", "");
            }
            catch (Exception ex)
            {
                new MessageForm(
                $"Exception caught: {ex.GetType().FullName}", "msg: " + ex.Message + "\rSource: " + ex.Source, null, "OK");
                return "";
            }
        }
    }
}
