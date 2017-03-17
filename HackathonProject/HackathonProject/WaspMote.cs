using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class WaspMote : Sensor
    {
        public WaspMote(string ID, string deviceType) : base(ID, deviceType)
        { }

        //only used for WASPMOTE sensors
        protected string getJsonURL(string sensorCode, double pollTimeMins)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Getting JSON URL for sensor " + ID + " at " + currentDateTime.ToString());

            string baseURL = "https://eif-research.feit.uts.edu.au/api/json/?rFromDate=" + Utility.formatDateToString(currentDateTime.AddMinutes(-4 * pollTimeMins).AddSeconds(-1)) + "&rToDate=" + Utility.formatDateToString(currentDateTime) + "&rFamily=wasp&rSensor=" + ID + "&rSubSensor=" + sensorCode;

            return baseURL;
        }
    }
}
