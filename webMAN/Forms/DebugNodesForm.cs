using HtmlAgilityPack;
using iTextSharp.text.html;
using Org.BouncyCastle.Crmf;
using PSS3.Classes.PS3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSS3.Classes;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Threading;

namespace PSS3.Forms
{
    public partial class DebugNodesForm : Form
    {
        string _ip;
        public DebugNodesForm(string ip)
        {
            InitializeComponent();
            _ip = ip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ps3Database.Initialize(Application.StartupPath + "\\res\\dat.trim");

        }
        public static String Decode(string Url)
        {

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }

        private static string HtmlToPlainText(string html)
        {
            const string tagWhiteSpace = @"(>|$)(\W|\n|\r)+<";//matches one or more (white space or line breaks) between '>' and '<'
            const string stripFormatting = @"<[^>]*(>|$)";//match any character between '<' and '>', even when end tag is missing
            const string lineBreak = @"<(br|BR)\s{0,1}\/{0,1}>";//matches: <br>,<br/>,<br />,<BR>,<BR/>,<BR />
            var lineBreakRegex = new Regex(lineBreak, RegexOptions.Multiline);
            var stripFormattingRegex = new Regex(stripFormatting, RegexOptions.Multiline);
            var tagWhiteSpaceRegex = new Regex(tagWhiteSpace, RegexOptions.Multiline);

            var text = html;
            //Decode html specific characters
            text = System.Net.WebUtility.HtmlDecode(text);
            //Remove tag whitespace/line breaks
            text = tagWhiteSpaceRegex.Replace(text, "><");
            //Replace <br /> with line breaks
            text = lineBreakRegex.Replace(text, Environment.NewLine);
            //Strip formatting
            text = stripFormattingRegex.Replace(text, string.Empty);

            return text;
        }
        public static string ExtractText(string html)
        {
            if (html == null)
            {
                throw new ArgumentNullException("html");
            }

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            var chunks = new List<string>();

            foreach (var item in doc.DocumentNode.DescendantNodesAndSelf())
            {
                if (item.NodeType == HtmlNodeType.Text)
                {
                    if (item.InnerText.Trim() != "")
                    {
                        chunks.Add(item.InnerText.Trim());
                    }
                }
            }
            return String.Join(" ", chunks);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                var sys = new PS3System(_ip);
                Thread.SpinWait(5);
                var file = Ps3File.FromSystem(sys, "/dev_hdd0/game/NPUB31419/PARAM.SFO");
                Thread.SpinWait(5);
                var param = PS3ParamSfo.FromFile(file);
            }).Start();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                var t = PS3TitleId.GetSearchInDatabaseFromRegion(TEXTREG.Text);
                Thread.Sleep(900);
                MessageBox.Show(t?.ToString());
            }).Start();
        }
    }
}
