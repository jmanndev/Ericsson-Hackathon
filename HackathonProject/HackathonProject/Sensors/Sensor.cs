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
        public string deviceType { get; set; }
        protected LinkedList<DataAtTime> sensorReadings { get; set; }
        protected string jsonData { get; set; }
        public string latestReading { get; set; }

        public Sensor(string ID, string deviceType)
        {
            this.ID = ID;
            this.deviceType = deviceType;
            this.sensorReadings = new LinkedList<DataAtTime>();
            latestReading = "";
        }

        protected void parseSensorData(string rawJsonData)
        {
            Console.WriteLine("Parsing JSON for sensor " + ID);
            try
            {
                List<string[]> dataListArray = JsonConvert.DeserializeObject<List<string[]>>(rawJsonData);
                foreach (string[] dataRow in dataListArray)
                {
                    sensorReadings.AddLast(new DataAtTime(dataRow.ElementAt(0), dataRow.ElementAt(1)));
                }
                Console.WriteLine("Completed parsing JSON for sensor " + ID);
            } catch(Exception) {
                Console.WriteLine("Error when parsing JSON for sensor " + ID + " - moving to next sensor");
            }
        }

        public virtual void pollForData()
        {
            if (sensorReadings.Count > 0)
            {
                latestReading = sensorReadings.Last().reading;
            }

            Console.WriteLine("Sensor polling complete");
        }

        public virtual void updateDeviceSettings()
        { }

    }
}
