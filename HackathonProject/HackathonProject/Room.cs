using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Room
    {
        public string ID { get; set; }
        PeopleCounter peopleCounter;
        Temperature temperatureSensor;
        Luminosity luminositySensor;

        int peopleInRoom = 0;

        public Room(string ID, string peopleCounterID, string waspID)
        {
            this.ID = ID;
            temperatureSensor =  new Temperature(waspID, "TEMP", "Temperature Control");
            luminositySensor = new Luminosity(waspID, "LUM", "Luminosity Control");
            peopleCounter = new PeopleCounter(peopleCounterID, "PEOP");
        }

        public void updateSensorReadings()
        {
            pollForRoomData();
            peopleInRoom = peopleCounter.getCurrentPeopleCount();
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
            peopleCounter.pollForData();
            temperatureSensor.pollForData();
            luminositySensor.pollForData();
            Console.WriteLine("Polling room" + ID + " completed");
        }
    }
}
