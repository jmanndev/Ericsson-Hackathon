using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class Room
    {
        public string ID { get; set; }

        bool peopleSensorEnabled = false;
        public PeopleCounter peopleCounter { get; set; }
        public Temperature temperatureSensor { get; set; }
        public Luminosity luminositySensor { get; set; }

        public int peopleInRoom = 0;

        public Room(string ID, string peopleCounterID, string waspID)
        {
            this.ID = ID;
            temperatureSensor =  new Temperature(waspID, "TEMP", "Temperature Control");
            luminositySensor = new Luminosity(waspID, "LUM", "Luminosity Control");

            if (peopleSensorEnabled)
                peopleCounter = new PeopleCounter(peopleCounterID, "PEOP");
        }

        public void updateSensorReadings()
        {
            pollForRoomData();

            if (peopleSensorEnabled)
                peopleCounter.getCurrentPeopleCount();
            else
                peopleInRoom = 2;

            updateDevicesInRoom();
        }

        private void updateDevicesInRoom()
        {
            Console.WriteLine("Updating device settings in room " + ID);
            temperatureSensor.calculateTemperatureAdjustment(peopleInRoom);
            temperatureSensor.updateDeviceSettings();
            luminositySensor.updateDeviceSettings();
            Console.WriteLine("Device settings in room" + ID + " updated");

        }

        private void pollForRoomData()
        {
            Console.WriteLine("Polling room " + ID + " for latest data");

            if (peopleSensorEnabled)
                peopleCounter.pollForData();

            temperatureSensor.pollForData();
            luminositySensor.pollForData();
            Console.WriteLine("Polling room" + ID + " completed");
        }
    }
}
