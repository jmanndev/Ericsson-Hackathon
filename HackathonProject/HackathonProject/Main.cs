using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace HackathonProject
{
    public class Main
    {
        List<Sensor> sensors = new List<Sensor>();

        public Main()
        {
            //checks the room count
            //if > 0 activate luminosity
            //if > 0 perform thermostat modifications
            //if = 0 thermostat set to default and light turned off
        }

        public void start()
        {
            string results = GetRawJSon("http://hummingbird.feit.uts.edu.au:8080/peopleCounterApi/live/PCB101-LevelB1CenterPCLabs1");
        }

        private string GetRawJSon(string url)
        {
            WebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }


    }
}
