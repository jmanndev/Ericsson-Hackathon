using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    static class Utility
    {
        public static string getRawJSon(string url)
        {
            WebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }

        public static string formatDateToString(DateTime date)
        {
            return date.ToString("yyyy-MM-dd\\Thh\\%\\3\\Amm\\%\\3\\Ass");
        }
    }
}
