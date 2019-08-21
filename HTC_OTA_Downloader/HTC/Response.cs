using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTC
{
    public class Response
    {
        public string time_msec { get; set; }
        public bool stats_ok { get; set; }
        public string reason { get; set; }
        public List<Intent> intent { get; set; }
        public class Intent
        {
            public string data_uri { get; set; }
            public string enc_type { get; set; }
            public string pkgFileName { get; set; }
            public string secure_uri { get; set; }
        }
    }
}
