using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace HTC_OTA_Downloader
{
    public partial class fmGUI : Form
    {
        JavaScriptSerializer serializer = Funcs.serializer;
        WebClient web = new WebClient();

        public fmGUI()
        {
            InitializeComponent();
        }

        private void fmGUI_Load(object sender, EventArgs e)
        {
            ActiveControl = text_log;
        }

        private async void button_get_Click(object sender, EventArgs e)
        {
            if (button_get.Tag.ToString() == "STOP")
            {
                web.CancelAsync();
                return;
            }

            var isChina = check_china.Checked;
            var model = text_model.Text;
            var version = text_version.Text;
            var cidnum = text_cidnum.Text;

            var json = await Task.Run(() => Funcs.CheckinJson(isChina, model, version, cidnum));
            var obj = serializer.Deserialize<Response>(json);
            text_log.Text = json;
            
            if (obj.intent != null && obj.intent[0].data_uri != null)
            {
                var url = obj.intent[0].data_uri;
                var pkg = obj.intent[0].pkgFileName;
                if (check_curl.Checked)
                {
                    text_log.Text = Funcs.GetCurlCommand(obj);
                    System.Media.SystemSounds.Asterisk.Play();
                }
                else
                {
                    var result = MessageBox.Show(pkg, "Download", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        web = Funcs.DonwloadPackage(obj);
                        web.DownloadProgressChanged += (_s, _e) =>
                        {
                            progressBar.Value = _e.ProgressPercentage;
                            this.Text = $"[{progressBar.Value}%] {pkg}";
                        };
                        web.DownloadFileCompleted += (_s, _e) =>
                        {
                            this.Text = "HTC OTA Downloader";
                            button_get.Tag = button_get.Text = "GET";
                            System.Media.SystemSounds.Asterisk.Play();
                            progressBar.Value = 0;
                        };
                        web.DownloadFileAsync(new Uri(url), pkg);
                        button_get.Tag = button_get.Text = "STOP";
                    }
                }
            }
        }

        private void text_log_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_log.Text))
            {
                text_log.Text = text_log.Text
                    .Replace("[{", "[\r\n{")
                    .Replace("}]", "}\r\n]")
                    .Replace("{\"", "{\r\n\"")
                    .Replace("\"}", "\"\r\n}")
                    .Replace(",\"", ",\r\n\"")
                    .Replace(",{", ",\r\n{")
                    .Replace("\"},", "\"\r\n},");
            }
        }

        private void text_info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ActiveControl = button_get;
                button_get_Click(sender, e);
            }
        }
    }
}
