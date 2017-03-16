﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Temperature : Sensor
    {

        LinkedList<DataAtTime> temperatureReadings = new LinkedList<DataAtTime>();

        public Temperature(string ID) : base(ID)
        { 
            string temp = Utility.getRawJSon(getJsonURL(ID, "TCA"));
        }

        private string getJsonURL(string ID, string sensorCode)
        {
            DateTime currentDateTime = DateTime.Now;
            string baseURL = "https://eif-research.feit.uts.edu.au/api/json/?rFromDate=" + Utility.formatDateToString(currentDateTime.AddMinutes(-7).AddSeconds(-1)) + "&rToDate=" + Utility.formatDateToString(currentDateTime) + "&rFamily=wasp&rSensor=" + ID + "&rSubSensor=" + sensorCode;
            
            return baseURL;
        }
    }
}
