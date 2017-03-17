using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Luminosity : WaspMote
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
        public LightControl connectedDevice;


        public Luminosity(string ID, string deviceType,  string connectedDeviceName, int idealLuxLevel = 500) : base(ID, deviceType)
        {
            Console.WriteLine("Creating luminosity sensor " + ID + " with ideal setting at " + idealLuxLevel);
            connectedDevice = new LightControl(connectedDeviceName);
            this.idealLuxLevel = idealLuxLevel;
        }

        public override void pollForData()
        {
            Console.WriteLine("Polling for new data from luminosity sensor " + ID);
            jsonData = Utility.getRawJSon(getJsonURL("LUM", 7.0));
            parseSensorData(jsonData);
            base.pollForData();
        }

        public override void updateDeviceSettings()
        {
            string command = "";
            double lightingAdjustment = getLuxAdjustment();

            command = "Increase lighting by " + lightingAdjustment.ToString() + " LUX";

            connectedDevice.lightSetting = lightingAdjustment;
            sendCommandToDevice(command);
        }

        private void sendCommandToDevice(string command)
        {
            connectedDevice.sendDeviceCommand(command);
        }

        public double getLuxAdjustment()
        {
            return idealLuxLevel - double.Parse(sensorReadings.Last().reading);
        }
    }
}
