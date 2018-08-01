using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTC_OTA_Downloader
{
    public class Request
    {
        public string imei { get; set; }
        public long timeStamp { get; set; }
        public string model_number { get; set; }
        public Checkin checkin = new Checkin();
        public string x1 { get; set; }

        public class Checkin
        {
            public Build build = new Build();
            public string client_version = "A8.0(M)";
            public string cid { get; set; }
            public string checkin_type = "Manual";
            public class Build
            {
                public string serialno { get; set; }
                public string firmware_version { get; set; }
            }
        }
    }
}
