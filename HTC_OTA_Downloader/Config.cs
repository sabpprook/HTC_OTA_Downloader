using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTC_OTA_Downloader
{
    class Config
    {
        private static RegistryKey Reg = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).CreateSubKey("HTCFZ\\HTC OTA Downloader");

        public static void DL_Load(out string model, out string version, out string cidnum, out bool isChina, out bool isCurl)
        {
            model = (string)Reg.GetValue("Model", "htc_pmeuhl");
            version = (string)Reg.GetValue("Version", "2.41.709.73");
            cidnum = (string)Reg.GetValue("CID", "HTC__621");
            isChina = (string)Reg.GetValue("isChina", "0") == "1" ? true : false;
            isCurl = (string)Reg.GetValue("isCurl", "0") == "1" ? true : false;
        }

        public static void DL_Save(string model, string version, string cidnum, bool isChina, bool isCurl)
        {
            Reg.SetValue("Model", model, RegistryValueKind.String);
            Reg.SetValue("Version", version, RegistryValueKind.String);
            Reg.SetValue("CID", cidnum, RegistryValueKind.String);
            Reg.SetValue("isChina", isChina ? "1" : "0", RegistryValueKind.String);
            Reg.SetValue("isCurl", isCurl ? "1" : "0", RegistryValueKind.String);
        }

        public static void BFC_Load(out string model, out string sku, out string cidnum)
        {
            model = (string)Reg.GetValue("Model2", "htc_pmeuhl");
            sku = (string)Reg.GetValue("SKU", "1:709");
            cidnum = (string)Reg.GetValue("CID2", "HTC__621");
        }

        public static void BFC_Save(string model, string sku, string cidnum)
        {
            Reg.SetValue("Model2", model, RegistryValueKind.String);
            Reg.SetValue("SKU", sku, RegistryValueKind.String);
            Reg.SetValue("CID2", cidnum, RegistryValueKind.String);
        }
    }
}
