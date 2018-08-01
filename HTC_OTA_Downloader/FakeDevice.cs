using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTC_OTA_Downloader
{
    public class FakeDevice
    {
        public string SN { get; private set; }
        public string IMEI { get; private set; }

        static string[] Factory = { "FA", "HT", "LC", "HQ", "CC", "SH" };
        static string[] Model = { "WM", "YJ", "BN", "18" }; // M8, M9, 10, U11
        static string[] TAC_FAC = { "35871605", "35722606", "35426107", "35613308" };
        static Random RND = new Random(DateTime.Now.Millisecond);

        public FakeDevice()
        {
            var index = RND.Next(0, Model.Length);
            var dt = DateTimeOffset.Parse("2014-03-01").AddYears(index).AddDays(RND.Next(1, 500));

            var sn = "";
            sn += Factory[RND.Next(0, Factory.Length)];
            sn += Int2Char(dt.Year - 2010) + Int2Char(dt.Month) + Int2Char(dt.Day);
            sn += Model[index];
            sn += RND.Next(1, 10000).ToString("D5");

            var imei = "";
            imei += TAC_FAC[index];
            imei += RND.Next(100000, 900000);
            imei = IMEI_D(imei);

            this.SN = sn;
            this.IMEI = imei;
        }

        static string Int2Char(int num)
        {
            if (num >= 1 && num <= 9)
                return ((char)(num + 48)).ToString();
            else if (num <= 31)
                return ((char)(num + 55)).ToString();
            else
                return "0";
        }

        static string IMEI_D(string str)
        {
            var sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var tmp = int.Parse(str[i].ToString());
                tmp = i % 2 == 0 ? tmp : tmp * 2;
                sum += (tmp / 10) + (tmp % 10);
            }
            var D = (10 - (sum % 10)) % 10;
            return str + D;
        }
    }
}
