using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Temperature : Sensor
    {
        public Temperature(string ID) : base(ID)
        {
            latestSensorReading = Utility.getRawJSon(getJsonURL(ID, "TCA", 7.0));
        }
    }
}
