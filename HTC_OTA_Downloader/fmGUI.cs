using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string model, version, sku, cidnum;
        bool isChina, isCurl;

        public fmGUI()
        {
            InitializeComponent();
        }

        private void fmGUI_Load(object sender, EventArgs e)
        {
            ActiveControl = text_dl_log;
            Config.DL_Load(out model, out version, out cidnum, out isChina, out isCurl);
            text_dl_model.Text = model;
            text_dl_version.Text = version;
            text_dl_cidnum.Text = cidnum;
            check_dl_china.Checked = isChina;
            check_dl_curl.Checked = isCurl;
            Config.BFC_Load(out model, out sku, out cidnum);
            text_bfc_model.Text = model;
            text_bfc_sku.Text = sku;
            text_bfc_cidnum.Text = cidnum;
        }

        private async void button_dl_get_Click(object sender, EventArgs e)
        {
            if (button_dl_get.Tag.ToString() == "STOP")
            {
                web.CancelAsync();
                return;
            }

            model = text_dl_model.Text;
            version = text_dl_version.Text;
            cidnum = text_dl_cidnum.Text;
            isChina = check_dl_china.Checked;
            isCurl = check_dl_curl.Checked;

            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(version) || string.IsNullOrEmpty(cidnum))
            {
                text_dl_log.Text = "Error: device informations are required!";
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }

            var json = await Task.Run(() => Funcs.CheckinJson(isChina, model, version, cidnum));
            var obj = serializer.Deserialize<Response>(json);
            text_dl_log.Text = json;

            if (obj.intent != null && obj.intent[0].data_uri != null)
            {
                Config.DL_Save(model, version, cidnum, isChina, isCurl);
                var url = obj.intent[0].data_uri;
                var pkg = obj.intent[0].pkgFileName;
                if (isCurl)
                {
                    text_dl_log.Text = Funcs.GetCurlCommand(obj);
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
                            button_dl_get.Tag = button_dl_get.Text = "GET";
                            System.Media.SystemSounds.Asterisk.Play();
                            progressBar.Value = 0;
                            if (_e.Cancelled) File.Delete(pkg);
                        };
                        web.DownloadFileAsync(new Uri(url), pkg);
                        button_dl_get.Tag = button_dl_get.Text = "STOP";
                    }
                }
            }
        }

        private void text_dl_log_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_dl_log.Text))
            {
                text_dl_log.Text = text_dl_log.Text
                    .Replace("[{", "[\r\n{")
                    .Replace("}]", "}\r\n]")
                    .Replace("{\"", "{\r\n\"")
                    .Replace("\"}", "\"\r\n}")
                    .Replace(",\"", ",\r\n\"")
                    .Replace(",{", ",\r\n{")
                    .Replace("\"},", "\"\r\n},");
            }
        }

        private void text_dl_info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ActiveControl = button_dl_get;
                button_dl_get_Click(sender, e);
            }
        }

        private async void btn_bfc_check_Click(object sender, EventArgs e)
        {
            if (btn_bfc_check.Tag.ToString() == "Suspend")
            {
                btn_bfc_check.Tag = "Check";
                return;
            }

            model = text_bfc_model.Text;
            sku = text_bfc_sku.Text;
            cidnum = text_bfc_cidnum.Text;

            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(cidnum))
            {
                text_bfc_log.Text = "Error: device informations are required!";
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }

            var sku_int = int.Parse(sku, System.Globalization.NumberStyles.Integer);
            isChina = (sku_int >= 1400 && sku_int <= 1405);

            btn_bfc_check.Tag = btn_bfc_check.Text = "Suspend";
            text_bfc_log.Text = "";

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    version = $"1.{i.ToString("D2")}.{sku}.{j}";
                    text_bfc_log.AppendText($"Check - {model} / {version} / {cidnum}\r\n");

                    var json = await Task.Run(() => Funcs.CheckinJson(isChina, model, version, cidnum));
                    var obj = serializer.Deserialize<Response>(json);

                    if (obj.intent != null && obj.reason != null)
                    {
                        Config.BFC_Save(model, sku, cidnum);
                        if (obj.reason == "FOTACANCEL_NO_MATCH_PRODUCT")
                        {
                            text_bfc_log.Text = "Error: Model name not vaild!";
                            btn_bfc_check.Tag = "Check";
                        }
                        if (obj.reason == "FOTACANCEL_NO_MATCH_SKU")
                        {
                            text_bfc_log.Text = "Error: SKU not vaild!";
                            btn_bfc_check.Tag = "Check";
                        }
                        if (obj.reason == "FOTAUPDATE_NO_ERROR")
                        {
                            text_bfc_log.Text = $"Found: {model} / {version} / {cidnum}";
                            btn_bfc_check.Tag = "Check";
                        }
                    }

                    if (btn_bfc_check.Tag.ToString() == "Check")
                    {
                        btn_bfc_check.Text = "Check";
                        System.Media.SystemSounds.Asterisk.Play();
                        return;
                    }
                }
            }
        }
    }
}
