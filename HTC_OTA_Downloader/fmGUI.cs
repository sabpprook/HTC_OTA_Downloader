using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTCFZ.HTC_OTA_Downloader
{
    public partial class fmGUI : Form
    {
        WebClient web = new WebClient();

        public fmGUI()
        {
            InitializeComponent();
        }

        private void FmGUI_Load(object sender, EventArgs e)
        {
            ServicePointManager.DefaultConnectionLimit = 16;
            text_device_locale.Text = CultureInfo.CurrentCulture.Name.Replace("-", "_");

            string model, version, cidnum, taskid, main, sku;
            bool isChina, isCURL;

            HTC.Config.DL_Load(out model, out version, out cidnum, out taskid, out isChina, out isCURL);
            text_device_model.Text = model;
             text_device_version.Text= version;
            text_device_cid.Text= cidnum;
            text_device_taskid.Text= taskid;

            HTC.Config.BFC_Load(out model, out main, out sku, out cidnum);
            text_bfc_model.Text = model;
            text_bfc_main.Text = main;
            text_bfc_sku.Text = sku;
            text_bfc_cid.Text = cidnum;
        }

        private async void Button_get_info_Click(object sender, EventArgs e)
        {
            if (button_get_info.Tag.ToString() == "STOP")
            {
                web.CancelAsync();
                return;
            }

            var model = text_device_model.Text;
            var version = text_device_version.Text;
            var cidnum = text_device_cid.Text;
            var taskid = text_device_taskid.Text;
            var locale = text_device_locale.Text;

            var isChina = check_option_china.Checked;
            var isCURL = check_option_curl.Checked;

            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(version) || string.IsNullOrEmpty(cidnum))
            {
                text_main.Text = "Error: Important device informations are missing!";
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }

            button_get_info.Enabled = false;

            var json = await Task.Run(() => HTC.Utils.CheckinJson(model, version, cidnum, taskid, locale, isChina));
            var resp = HTC.Json.GetResponseObject(json);

            button_get_info.Enabled = true;

            text_main.Text = HTC.Json.GetString(json);

            if (resp.intent == null || resp.intent[0].data_uri == null)
            {
                button_get_info.Enabled = true;
                return;
            }

            HTC.Config.DL_Save(model, version, cidnum, taskid, isChina, isCURL);
            File.WriteAllText("OTA.json", text_main.Text);

            if (isCURL)
            {
                text_main.Text = HTC.Utils.GetCurlCommand(resp);
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }

            var package_url = resp.intent[0].data_uri;
            var package_filename = resp.intent[0].pkgFileName;

            var result = MessageBox.Show(package_filename, "Download", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result != DialogResult.OK)
            {
                button_get_info.Enabled = true;
                return;
            }

            web = HTC.Utils.Download(resp);

            web.DownloadProgressChanged += (_s, _e) =>
            {
                progressBar.Value = _e.ProgressPercentage;
                this.Text = $"[{progressBar.Value}%] {package_filename}";
            };
            web.DownloadFileCompleted += (_s, _e) =>
            {
                this.Text = "HTC OTA Downloader";
                button_get_info.Tag = button_get_info.Text = "GET";
                System.Media.SystemSounds.Asterisk.Play();
                progressBar.Value = 0;
                if (_e.Cancelled) File.Delete(package_filename);
            };
            web.DownloadFileAsync(new Uri(package_url), package_filename);
            button_get_info.Tag = button_get_info.Text = "STOP";
        }

        private async void Button_bfc_check_Click(object sender, EventArgs e)
        {
            if (button_bfc_check.Tag.ToString() == "Suspend")
            {
                button_bfc_check.Tag = button_bfc_check.Text = "Check";
                return;
            }

            var model = text_bfc_model.Text;
            var cidnum = text_bfc_cid.Text;
            var main = text_bfc_main.Text;
            var sku = text_bfc_sku.Text;
            var locale = text_device_locale.Text;
            var sku_int = int.Parse(sku, NumberStyles.Integer);
            var isChina = (sku_int >= 1400 && sku_int <= 1405);

            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(cidnum))
            {
                text_main.Text = "Error: Important device informations are missing!";
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }

            button_bfc_check.Tag = button_bfc_check.Text = "Suspend";
            text_main.Text = "";

            var is_Suspend = false;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (button_bfc_check.Tag.ToString() == "Check")
                    {
                        is_Suspend = true;
                        break;
                    }

                    var version = $"{main}.{i.ToString("D2")}.{sku}.{j}";
                    var str = $"{model}\t{version}\t{cidnum}";

                    this.Text = $"Brute-Force: {str.Replace("\t", " / ")}";
                    text_main.AppendText($"Check: {str}\r\n");

                    var json = await Task.Run(() => HTC.Utils.CheckinJson(model, version, cidnum, "", locale, isChina));
                    var resp = HTC.Json.GetResponseObject(json);

                    if (resp.intent != null && resp.reason != null)
                    {
                        HTC.Config.BFC_Save(model, main, sku, cidnum);
                        if (resp.reason == "FOTACANCEL_NO_MATCH_PRODUCT")
                        {
                            text_main.Text = "Error: Model name not vaild!";
                            is_Suspend = true;
                        }
                        if (resp.reason == "FOTACANCEL_NO_MATCH_SKU")
                        {
                            text_main.Text = "Error: SKU not vaild!";
                            is_Suspend = true;
                        }
                        if (resp.reason == "FOTAUPDATE_NO_ERROR")
                        {
                            text_main.Text = $"Found: {model} / {version} / {cidnum}";
                            is_Suspend = true;
                        }
                    }
                    if (is_Suspend) break;
                }
                if (is_Suspend) break;
            }

            if (!is_Suspend)
            {
                text_main.Text = "No OTA package found!";
            }

            this.Text = "HTC OTA Downloader";
            button_bfc_check.Tag = button_bfc_check.Text = "Check";
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void KeyDown_Download(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ActiveControl = button_get_info;
                Button_get_info_Click(sender, e);
            }
        }

        private void KeyDown_Bruteforce(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ActiveControl = button_bfc_check;
                Button_bfc_check_Click(sender, e);
            }
        }
    }
}
