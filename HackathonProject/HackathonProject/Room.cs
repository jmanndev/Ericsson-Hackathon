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
        List<Sensor> sensors = new List<Sensor>();

        public Room(string ID, string peopleCounterID, string waspID)
        {
            this.ID = ID;
            sensors.Add(new Temperature(waspID));
            sensors.Add(new Luminosity(waspID));
            //sensors.Add(new PeopleCounter(peopleCounterID));
        }

        public void updateSensorReadings()
        {
            pollForRoomData();
            double adjustment = (int)getLuminositySensor().getLuxAdjustment();
        }

        private void pollForRoomData()
        {
            Console.WriteLine("Polling room " + ID + " for latest data");
            foreach (Sensor sensor in sensors)
            {
                sensor.pollForData();
            }
            Console.WriteLine("Polling room" + ID + " completed");
        }

        public Luminosity getLuminositySensor()
        {
            return (Luminosity)sensors.ElementAt(1);
        }

        public Temperature getTemperatureSensor()
        {
            return (Temperature)sensors.ElementAt(0);
        }

        public PeopleCounter getPeopleCounterSensor()
        {
            return (PeopleCounter)sensors.ElementAt(2);
        }
    }
}
