using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS3.Classes.PS3
{
    public interface IPs3Capability<T> where T : class
    {
        T FromSystem(PS3System system);
        void FetchFromSystem();
        string ToString();
        void Download();
    }
}
