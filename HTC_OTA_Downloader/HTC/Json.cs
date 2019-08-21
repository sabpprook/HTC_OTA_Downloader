using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace HTC
{
    public class Json
    {

        public static JavaScriptSerializer Serializer = new JavaScriptSerializer();

        public static string GetRequestString(Request device)
        {
            return Serializer.Serialize(device);
        }

        public static Response GetResponseObject(string json)
        {
            return Serializer.Deserialize<Response>(json);
        }

        public static string GetString(string json)
        {
            int space_count = 0;
            string result = "";
            for (int i=0; i< json.Length; i++)
            {
                if (json[i] == '{' || json[i] == '[')
                {
                    space_count += 2;
                    result += json[i];
                    result += newline(space_count);
                }
                else if (json[i] == ',' && (json[i + 1] == '"' || json[i + 1] == '{'))
                {
                    result += json[i];
                    result += newline(space_count);
                }
                else if(json[i] == '}' || json[i] == ']')
                {
                    space_count -= 2;
                    result += newline(space_count);
                    result += json[i];
                }
                else
                {
                    result += json[i];
                }
            }
            return result;
        }

        private static string newline(int space_count)
        {
            string str = "\r\n";
            for (int i = 0; i < space_count; i++)
            {
                str += " ";
            }
            return str;
        }
    }
}
