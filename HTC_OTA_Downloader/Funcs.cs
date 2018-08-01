using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace HTC_OTA_Downloader
{
    class Funcs
    {
        static long TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        static string CHECKIN_URL = "https://andchin-2.htc.com/htcfotacheckin/rest/checkin";
        static string CHECKIN_URL_CN = "https://andchin-2.htccomm.com.cn/htcfotacheckin/rest/checkin";
        public static JavaScriptSerializer serializer = new JavaScriptSerializer();
        static FakeDevice Device;

        public static string CheckinJson(bool isChina, string model, string version, string cidnum)
        {
            Device = new FakeDevice();
            using (var web = new WebClient())
            {
                var headers = new WebHeaderCollection();
                headers.Add(HttpRequestHeader.UserAgent, "Android-Checkin/8.0");
                headers.Add(HttpRequestHeader.ContentType, "application/json");
                headers.Add("x-active-g", "DivadGS38Omatump76");
                web.Headers = headers;

                var obj = new Request();
                obj.imei = Device.IMEI;
                obj.timeStamp = TimeStamp;
                obj.model_number = model;
                obj.checkin.build.serialno = Device.SN;
                obj.checkin.build.firmware_version = version;
                obj.checkin.cid = cidnum;
                obj.x1 = getX1();

                var post_string = serializer.Serialize(obj);
                var url = isChina ? CHECKIN_URL_CN : CHECKIN_URL;

                return web.UploadString(url, post_string);
            }
        }

        public static WebClient DonwloadPackage(Response obj)
        {
            var web = new WebClient();
            var headers = new WebHeaderCollection();
            headers.Add(HttpRequestHeader.UserAgent, "Android-Checkin/8.0");
            headers.Add("htc1s", getHTC1S(long.Parse(obj.time_msec)));
            web.Headers = headers;
            return web;
        }

        public static string GetCurlCommand(Response obj)
        {
            var url = obj.intent[0].data_uri;
            var pkg = obj.intent[0].pkgFileName;

            var curl = "curl -H \"User-Agent: Android-Checkin/8.0\"";
            curl += $" -H \"htc1s: {getHTC1S(long.Parse(obj.time_msec))}\"";
            curl += $" \"{url}\" -o \"{pkg}\"";

            return curl;
        }

        private static string getX1()
        {
            string time = TimeStamp.ToString();
            int shift_value = 0;
            for (int i = 4; i <= time.Length; i++)
            {
                if (time[time.Length - i] != '0')
                {
                    shift_value = (int)char.GetNumericValue(time[time.Length - i]);
                    break;
                }
            }
            var time_head = time.Substring(0, time.Length - shift_value);
            var time_tail = time.Substring(time.Length - shift_value);
            return sha256(time_tail + Device.SN + Device.IMEI + time_head);
        }

        public static string getHTC1S(long timestamp)
        {
            var htc1s = Device.SN + timestamp;
            if (timestamp <= 0) return htc1s;
            for (long i = timestamp % 10; ; i = timestamp % 10)
            {
                if (i == 0)
                    timestamp /= 10;
                else
                {
                    var index = htc1s.Length - (int)i;
                    return htc1s.Substring(index) + htc1s.Remove(index);
                }
            }
        }

        private static string sha256(string str)
        {
            var bytes = Encoding.ASCII.GetBytes(str);
            var data = SHA256.Create().ComputeHash(bytes);
            return BitConverter.ToString(data).Replace("-", "").ToUpper();
        }
    }
}
