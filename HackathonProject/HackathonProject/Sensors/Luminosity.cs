using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Luminosity : Sensor
    {
        /* https://www.noao.edu/education/QLTkit/ACTIVITY_Documents/Safety/LightLevels_outdoor+indoor.pdf
         * 
         * Recommendations:
         *  - Office - 500
         *  - Tunnel - 200
         *  - Parking (general) - 50-100
         *  - Parking (entrances) - 500
         *  
         * Daylight ranges from 10-10000
         * 
         */

        int idealLuxLevel;


        public Luminosity(string ID, int idealLuxLevel = 500) : base(ID)
        {
            Console.WriteLine("Creating luminosity sensor " + ID + " with ideal setting at " + idealLuxLevel);
            this.idealLuxLevel = idealLuxLevel;
        }

        public override void pollForData()
        {
            Console.WriteLine("Polling for new data from luminosity sensor " + ID);
            jsonData = Utility.getRawJSon(getJsonURL("LUM", 7.0));
            parseSensorData(jsonData);
            base.pollForData();
        }

        public double getLuxAdjustment()
        {
            return idealLuxLevel - double.Parse(sensorReadings.Last().reading);
        }
    }
}
