using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace HackathonProject
{
    class Temperature : WaspMote
    {
        int idealTempLevel;
        public ThermostatControl connectedDevice;
        public double temperatureAdjustment;

        public Temperature(string ID, string deviceType, string connectedDeviceName, int idealTempLevel = 27) : base(ID, deviceType)
        {
            Console.WriteLine("Creating temperature sensor " + ID);
            connectedDevice = new ThermostatControl(connectedDeviceName);
            this.idealTempLevel = idealTempLevel;
        }

        public override void pollForData()
        {
            Console.WriteLine("Polling for new data from temperature sensor " + ID);
            jsonData = Utility.getRawJSon(getJsonURL("TCA", 7.0));
            parseSensorData(jsonData);
            base.pollForData();
        }

        public void calculateTemperatureAdjustment(int peopleCount)
        { // ASSUMING A SINGLE PERSON RAISES ROOM TEMPERATURE BY 0.1 degrees
            temperatureAdjustment = idealTempLevel - (double.Parse(latestReading) - (peopleCount * 0.1));
        }

        public override void updateDeviceSettings()
        {
            string command = "";

            command = "Increase temperature by " + temperatureAdjustment.ToString() + " degrees Celsius";

            connectedDevice.temperatureSetting = temperatureAdjustment;
            sendCommandToDevice(command);
        }

        private void sendCommandToDevice(string command)
        {
            connectedDevice.sendDeviceCommand(command);
        }
    }
}
