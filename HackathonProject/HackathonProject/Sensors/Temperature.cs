using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace HackathonProject
{
    class Temperature : Sensor
    {
        public Temperature(string ID) : base(ID)
        {
            Console.WriteLine("Creating temperature sensor " + ID);
        }

        public override void pollForData()
        {
            Console.WriteLine("Polling for new data from temperature sensor " + ID);
            jsonData = Utility.getRawJSon(getJsonURL("TCA", 7.0));
            parseSensorData(jsonData);
            base.pollForData();
        }
    }
}
