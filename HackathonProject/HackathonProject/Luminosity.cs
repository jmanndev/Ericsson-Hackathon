using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Luminosity : Sensor
    {
        LinkedList<DataAtTime> luminosityReadings = new LinkedList<DataAtTime>();

        public Luminosity(string ID) : base(ID)
        {
            string lumin = Utility.getRawJSon(getJsonURL(ID, "LUM"));
        }

        private string getJsonURL(string ID, string sensorCode)
        {
            DateTime currentDateTime = DateTime.Now;
            string baseURL = "https://eif-research.feit.uts.edu.au/api/json/?rFromDate=" + Utility.formatDateToString(currentDateTime.AddMinutes(-7).AddSeconds(-1)) + "&rToDate=" + Utility.formatDateToString(currentDateTime) + "&rFamily=wasp&rSensor=" + ID + "&rSubSensor=" + sensorCode;

            return baseURL;
        }
    }
}
