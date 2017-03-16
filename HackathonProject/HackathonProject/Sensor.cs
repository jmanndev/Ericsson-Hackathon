using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Sensor
    {
        protected string ID { get; set; }
        protected string latestSensorReading { get; set; }

        public Sensor(string ID)
        {
            this.ID = ID;
        }

        protected string getJsonURL(string ID, string sensorCode, double pollTimeMins)
        {
            DateTime currentDateTime = DateTime.Now;
            string baseURL = "https://eif-research.feit.uts.edu.au/api/json/?rFromDate=" + Utility.formatDateToString(currentDateTime.AddMinutes(-pollTimeMins).AddSeconds(-1)) + "&rToDate=" + Utility.formatDateToString(currentDateTime) + "&rFamily=wasp&rSensor=" + ID + "&rSubSensor=" + sensorCode;

            return baseURL;
        }


        protected string parseSensorData(string sensorData)
        {
            //  regex pattern: \\\",\d*.\d*
            string pattern = @"\\\"",\d *.\d *";
            Regex regex = new Regex(pattern);
            string value = "";

            Match match = regex.Match(sensorData);
            if (match.Success)
            {
                value = match.Groups[1].Value;
            }
            return value;
        }

    }
}
