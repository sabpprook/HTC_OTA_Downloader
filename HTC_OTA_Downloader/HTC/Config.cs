using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTC
{
    class Config
    {
        private static RegistryKey Reg = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).CreateSubKey("HTCFZ\\HTC OTA Downloader");

        public static void DL_Load(out string model, out string version, out string cidnum, out string taskid, out bool isChina, out bool isCURL)
        {
            model = (string)Reg.GetValue("DL_string_Model", "htc_pmeuhl");
            version = (string)Reg.GetValue("DL_string_Version", "2.41.709.73");
            cidnum = (string)Reg.GetValue("DL_string_CID", "HTC__621");
            taskid = (string)Reg.GetValue("DL_string_TaskID", "");
            isChina = (string)Reg.GetValue("DL_bool_China", "0") == "1" ? true : false;
            isCURL = (string)Reg.GetValue("DL_bool_CURL", "0") == "1" ? true : false;
        }

        public static void DL_Save(string model, string version, string cidnum, string taskid, bool isChina, bool isCURL)
        {
            Reg.SetValue("DL_string_Model", model, RegistryValueKind.String);
            Reg.SetValue("DL_string_Version", version, RegistryValueKind.String);
            Reg.SetValue("DL_string_CID", cidnum, RegistryValueKind.String);
            Reg.SetValue("DL_string_TaskID", taskid, RegistryValueKind.String);
            Reg.SetValue("DL_bool_China", isChina ? "1" : "0", RegistryValueKind.String);
            Reg.SetValue("DL_bool_CURL", isCURL ? "1" : "0", RegistryValueKind.String);
        }

        public static void BFC_Load(out string model, out string main, out string sku, out string cidnum)
        {
            model = (string)Reg.GetValue("BFC_string_Model", "htc_pmeuhl");
            main = (string)Reg.GetValue("BFC_string_Main", "1");
            sku = (string)Reg.GetValue("BFC_string_SKU", "709");
            cidnum = (string)Reg.GetValue("BFC_string_CID", "HTC__621");
        }

        public static void BFC_Save(string model, string main, string sku, string cidnum)
        {
            Reg.SetValue("BFC_string_Model", model, RegistryValueKind.String);
            Reg.SetValue("BFC_string_Main", main, RegistryValueKind.String);
            Reg.SetValue("BFC_string_SKU", sku, RegistryValueKind.String);
            Reg.SetValue("BFC_string_CID", cidnum, RegistryValueKind.String);
        }
    }
}
