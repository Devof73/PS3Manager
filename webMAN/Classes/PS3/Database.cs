

using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.IO;

namespace PSS3.Classes.PS3
{
    public class Ps3Database : Debug
    {
        private static List<PS3TitleId> _datas = null;
        private static bool _initialized = false;
        public static bool Initialized { get => _initialized; }
        public static PS3TitleId[] Store { get => _datas.ToArray(); }
        public static Ps3Database Parse(string txt)
        {
            if (txt.Length < 200) throw new WarningException("Warning data length is less");
            else
            {
                return new Ps3Database(txt);
            }
        }
        private Ps3Database(string databasetxt, char separator = ';')
        {
            var d = ToLines(databasetxt);
            _datas = new List<PS3TitleId>();
            foreach (var line in d)
            {
                var values = line.Split(separator);
                if (values.Length > 0) { throw new InvalidDataException("Inparseable data."); }
                else
                {
                    var v = values;
                    _datas.Add(new PS3TitleId(int.Parse(v[0].Substring(4, 5)), v[0].Substring(0, 4), v[1], v[2], v[4], v[3]));
                }
            }
            //NPEF00136;All Star Boxing;PS1;EU;http://zeus.dl.playstation.net/cdn/EP4061/NPEF00136_00/GPTYaline5bkGMQmGTqYQ45YLXNLt16vYDtG7KNN63fFssREMYyN8MK5lWAgjk5S.pkg;;;*Warning, missing RAP*;LingXiaoyu

        }
        private Ps3Database() { }
        public static void Initialize(string filepath)
        {
            if (_initialized) return;
            else
            {
                try
                {
                    //BLUS31193;Assassin's Creed IV Black Flag DLC ACBFMICRODLC0005;DLC;US;http://zeus.dl.playstation.net/cdn/UP0001/BLUS31193_00/OCGPCAtHUAWVStSxIQQngFlZuvDfHpxfwKEUvMNJFYFTibWLxyjrTgqVHrFzuvnp.pkg;UP0001-BLUS31193_00-ACBFMICRODLC0005.rap;789EC049BC3DA3440BAC7B42DC6FCEEE;;HeihachiMishima

                    _initialized = true;
                    var filetxt = File.ReadAllLines(filepath);
                    var regionind = 0;
                    var nameind = 1;
                    var typeind = 2;
                    var regioncodeind = 3;
                    var linkind = 4;
                    var rapind = 5;
                    var rapcodeind = 6;
                    var database = new List<PS3TitleId>();
                    foreach (var line in filetxt)
                    {
                        var datas = line.Split(';');
                        var region = datas[regionind];
                        var name = datas[nameind];
                        var type = datas[typeind];
                        var regioncode = datas[regioncodeind];
                        var link = datas[linkind];
                        var rap = datas[rapind];
                        var rapcode = datas[rapcodeind];
                        var f = new PS3TitleId(int.Parse(region.Substring(4)), region.Substring(0, 4), name, type, link, regioncode);
                        database.Add(f);
                    }
                    _datas = database;
                }
                catch (Exception e)
                {
                    _initialized = false;
                    Console.WriteLine(e.ToString() + " - " + e.Message);
                    throw e;
                }
            }
        }
        private string[] ToLines(string txt)
        {
            var output = new List<string>();
            var @base = txt.Split('\n', '\r', ' ');
            foreach (var line in @base)
            {
                if (@base.Length > 3)
                {
                    output.Add(line);
                }
            }
            return output.ToArray();
        }
    }
}
