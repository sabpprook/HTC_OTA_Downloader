using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace HTC_OTA_Downloader
{
    public class OTA_Object
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

    public partial class fmGUI : Form
    {
        readonly string CHECKIN_URL = "https://andchin-2.htc.com/htcfotacheckin/rest/checkin";
        readonly string CHECKIN_URL_CN = "https://andchin-2.htccomm.com.cn/htcfotacheckin/rest/checkin";
        readonly string SN = "CC55TYG07414";
        readonly string IMEI = "357290062810490";
        long TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        public fmGUI()
        {
            InitializeComponent();
        }

        private void fmGUI_SizeChanged(object sender, EventArgs e)
        {
            var height = this.Height;
            var width = this.Width;
            btn_execute.Width = width - 170;
            groupBox.Width = text_json.Width = progressBar.Width = width - 40;
            text_model.Width = text_version.Width = text_cidnum.Width = Width - 200;
            text_json.Height = height - 320;
            progressBar.Location = new Point(12, height - 90);
            checkBox.Location = new Point(width - 145, 165);
        }

        private void text_json_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_json.Text))
            {
                text_json.Text = text_json.Text.Replace("[{", "[\r\n{")
                                               .Replace("}]", "}\r\n]")
                                               .Replace("{\"", "{\r\n\"")
                                               .Replace("\"}", "\"\r\n}")
                                               .Replace(",\"", ",\r\n\"")
                                               .Replace(",{", ",\r\n{")
                                               .Replace("\"},", "\"\r\n},");
            }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            using (var web = new WebClient())
            {
                var headers = new WebHeaderCollection();
                headers.Add(HttpRequestHeader.UserAgent, "Android-Checkin/8.0");
                headers.Add(HttpRequestHeader.ContentType, "application/json");
                headers.Add("x-active-g", "DivadGS38Omatump76");
                web.Headers = headers;

                TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                var model = text_model.Text;
                var version = text_version.Text;
                var cidnum = text_cidnum.Text;
                var post_string = $"{{\"imei\":\"{IMEI}\",\"timeStamp\":{TimeStamp},\"model_number\":\"{model}\",\"checkin\":{{\"build\":{{\"serialno\":\"{SN}\",\"firmware_version\":\"{version}\"}},\"client_version\":\"A8.0(M)\",\"cid\":\"{cidnum}\",\"checkin_type\":\"Manual\"}},\"x1\":\"{getX1()}\"}}";
                var response_string = web.UploadString(checkBox.Checked ? CHECKIN_URL_CN : CHECKIN_URL, post_string);
                text_json.Text = response_string;

                var serializer = new JavaScriptSerializer();
                var OTA = serializer.Deserialize<OTA_Object>(response_string);

                if (OTA.intent != null && OTA.intent[0].data_uri != null)
                {
                    var url = OTA.intent[0].data_uri;
                    var pkgname = OTA.intent[0].pkgFileName;
                    if (MessageBox.Show(pkgname, "Download?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        headers = new WebHeaderCollection();
                        headers.Add(HttpRequestHeader.UserAgent, "Android-Checkin/8.0");
                        headers.Add("htc1s", getHTC1S(long.Parse(OTA.time_msec)));
                        web.Headers = headers;

                        web.DownloadProgressChanged += (_s, _e) => progressBar.Value = _e.ProgressPercentage;
                        web.DownloadFileCompleted += (_s, _e) =>
                        {
                            this.Text = "HTC OTA Downloader";
                            System.Media.SystemSounds.Asterisk.Play();
                            progressBar.Value = 0;
                        };

                        this.Text = pkgname;
                        web.DownloadFileAsync(new Uri(url), pkgname);
                    }
                }
            }
        }

        private string getX1()
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
            return sha256(time_tail + SN + IMEI + time_head);
        }

        public string getHTC1S(long timestamp)
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

        private string sha256(string str)
        {
            var bytes = Encoding.ASCII.GetBytes(str);
            var data = SHA256.Create().ComputeHash(bytes);
            return BitConverter.ToString(data).Replace("-", "").ToUpper();
        }
    }
}
