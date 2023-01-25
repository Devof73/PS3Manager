
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace PSS3.Classes
{
    public class StaticResources
    {
        public static readonly string Resources = Application.StartupPath + "\\res";
        public static readonly string UserData = Application.StartupPath + "\\USRDAT";
        public static readonly SoundPlayer _SND = new SoundPlayer();
        public static readonly SoundPlayer SndCursor = new SoundPlayer(Resources + "\\wf\\snd_cursor.wav");
        public static readonly SoundPlayer SndError = new SoundPlayer(Resources + "\\wf\\snd_system_ng.wav");
        public static readonly SoundPlayer SndOption = new SoundPlayer(Resources + "\\wf\\snd_option.wav");
        public static readonly SoundPlayer SndOk = new SoundPlayer(Resources + "\\wf\\snd_system_ok.wav");
        public static readonly SoundPlayer SndCancel = new SoundPlayer(Resources + "\\wf\\snd_cancel.wav");

    }

}
