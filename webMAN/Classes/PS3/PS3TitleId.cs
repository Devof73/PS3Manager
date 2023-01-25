using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PSS3.Classes.PS3
{
    public class PS3TitleId : Debug
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string RegionCode { get; set; }
        public static readonly PS3TitleId None = new PS3TitleId(0, "UNKN", "Unknown", "None", "https://google.com", "0000");
        public PS3TitleId(int id, string region, string name, string type, string url, string regionCode)
        {
            Id = id;
            Region = region;
            Name = name;
            Url = url;
            Type = type;
            RegionCode = regionCode;
            Console.WriteLine(ToString());
        }
        public static PS3TitleId GetSearchInDatabaseFromRegion(string abcd1234Region)
        {
            if (Ps3Database.Initialized is false)
            {
                throw new InvalidOperationException("Datas not initialized!");
            }
            else
            {
                var e = Ps3Database.Store;
                foreach (var tid in e)
                {
                    if (tid.Region + tid.Id == abcd1234Region)
                    {
                        return tid;
                    }
                    else
                    {
                        Console.WriteLine(" ! NO => " + tid.Region + tid.Id);
                    }
                }
                Thread.Sleep(500);
                return None;
            }
        }
        public new string ToString()
        {
            return $"{Id} ({RegionCode}) - {Name} | {Type} | {Url}";
        }
    }
}
