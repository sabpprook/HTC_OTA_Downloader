using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTC
{
    public class Request
    {
        public Checkin checkin { get; set; } = new Checkin();
        public string locale { get; set; }
        public string imei { get; set; }
        public long timeStamp { get; set; }
        public string model_number { get; set; }
        public string x1 { get; set; }

        public class Checkin
        {
            public Build build { get; set; } = new Build();
            public string client_version { get; set; } = "A8.0(M)";
            public string cid { get; set; }
            public string checkin_type { get; set; } = "Manual";
            public class Build
            {
                public string serialno { get; set; }
                public string firmware_version { get; set; }
                public string build_taskid { get; set; }
            }
        }
    }
}
