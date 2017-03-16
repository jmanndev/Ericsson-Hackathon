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
        protected string ID { get; }
        protected LinkedList<DataAtTime> sensorReadings { get; set; }
        protected string jsonData { get; set; }
        public string latestReading { get; set; }

        public Sensor(string ID)
        {
            this.ID = ID;
            this.sensorReadings = new LinkedList<DataAtTime>();
            latestReading = "";
        }

        //only used for WASPMOTE sensors
        protected string getJsonURL(string sensorCode, double pollTimeMins)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Getting JSON URL for sensor " + ID + " at " + currentDateTime.ToString());

            string baseURL = "https://eif-research.feit.uts.edu.au/api/json/?rFromDate=" + Utility.formatDateToString(currentDateTime.AddMinutes(-4 * pollTimeMins).AddSeconds(-1)) + "&rToDate=" + Utility.formatDateToString(currentDateTime) + "&rFamily=wasp&rSensor=" + ID + "&rSubSensor=" + sensorCode;

            return baseURL;
        }

        protected void parseSensorData(string rawJsonData)
        {
            Console.WriteLine("Parsing JSON for sensor " + ID);
            List<string[]> dataListArray = JsonConvert.DeserializeObject<List<string[]>>(rawJsonData);
            foreach (string[] dataRow in dataListArray)
            {
                sensorReadings.AddLast(new DataAtTime(dataRow.ElementAt(0), dataRow.ElementAt(1)));
            }
            Console.WriteLine("Completed parsing JSON for sensor " + ID);
        }

        public virtual void pollForData()
        {
            latestReading = sensorReadings.Last().reading;
            Console.WriteLine("Sensor polling complete");
        }


    }
}
