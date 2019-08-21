using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace HTC
{
    class Utils
    {
        static string CHECKIN_URL = "https://andchin-2.htc.com/htcfotacheckin/rest/checkin";
        static string CHECKIN_URL_CN = "https://andchin-2.htccomm.com.cn/htcfotacheckin/rest/checkin";

        static Device device;

        public static string CheckinJson(string model, string version, string cidnum, string taskid, string locale, bool isChina = false)
        {
            device = new Device();
            using (var web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;

                var headers = new WebHeaderCollection();
                headers.Add(HttpRequestHeader.UserAgent, "Android-Checkin/8.0");
                headers.Add(HttpRequestHeader.ContentType, "application/json");
                headers.Add("x-active-g", "DivadGS38Omatump76");
                web.Headers = headers;

                var obj = new Request();
                obj.timeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                obj.locale = locale;
                obj.imei = device.IMEI;
                obj.model_number = model;
                obj.checkin.cid = cidnum;
                obj.checkin.build.serialno = device.SN;
                obj.checkin.build.firmware_version = version;
                obj.checkin.build.build_taskid = taskid;
                obj.x1 = getX1(device.SN, device.IMEI, obj.timeStamp);

                var post_string = Json.GetRequestString(obj);
                var url = isChina ? CHECKIN_URL_CN : CHECKIN_URL;

                return web.UploadString(url, post_string);
            }
        }

        public static WebClient Download(Response obj)
        {
            var web = new WebClient();
            web.Encoding = Encoding.UTF8;
            var headers = new WebHeaderCollection();
            headers.Add(HttpRequestHeader.UserAgent, "Android-Checkin/8.0");
            headers.Add("htc1s", getHTC1S(device.SN, long.Parse(obj.time_msec)));
            web.Headers = headers;
            return web;
        }

        public static string GetCurlCommand(Response obj)
        {
            var url = obj.intent[0].data_uri;
            var pkg = obj.intent[0].pkgFileName;

            var curl = "curl -H \"User-Agent: Android-Checkin/8.0\"";
            curl += $" -H \"htc1s: {getHTC1S(device.SN, long.Parse(obj.time_msec))}\"";
            curl += $" \"{url}\" -o \"{pkg}\"";

            return curl;
        }

        private static string getX1(string SN, string IMEI, long timestamp)
        {
            string time = timestamp.ToString();
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
            return sha256(time_tail + SN + IMEI + time_head);
        }

        private static string getHTC1S(string SN, long timestamp)
        {
            var htc1s = SN + timestamp;
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
