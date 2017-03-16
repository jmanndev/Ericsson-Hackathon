using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Sensor
    {
        protected string ID { get; set; }
        protected LinkedList<DataAtTime> sensorReadings { get; set; }
        protected string jsonData { get; set; }

        public Sensor(string ID)
        {
            this.ID = ID;
            this.sensorReadings = new LinkedList<DataAtTime>();
        }

        protected string getJsonURL(string ID, string sensorCode, double pollTimeMins)
        {
            DateTime currentDateTime = DateTime.Now;
            string baseURL = "https://eif-research.feit.uts.edu.au/api/json/?rFromDate=" + Utility.formatDateToString(currentDateTime.AddMinutes(-4 * pollTimeMins).AddSeconds(-1)) + "&rToDate=" + Utility.formatDateToString(currentDateTime) + "&rFamily=wasp&rSensor=" + ID + "&rSubSensor=" + sensorCode;

            return baseURL;
        }

        protected void parseSensorData(string rawJsonData)
        {
            List<string[]> dataListArray = JsonConvert.DeserializeObject<List<string[]>>(rawJsonData);
            foreach (string[] dataRow in dataListArray)
            {
                sensorReadings.AddLast(new DataAtTime(dataRow.ElementAt(0), dataRow.ElementAt(1)));
            }
        }

        public virtual void pollForData()
        {

        }
    }
}
