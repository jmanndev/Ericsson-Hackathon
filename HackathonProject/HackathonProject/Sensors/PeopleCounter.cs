using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace HackathonProject
{
    class PeopleCounter : Sensor
    {
        public PeopleCounterReading reading { get; set; }

        public PeopleCounter (string ID, string deviceType) : base(ID, deviceType)
        {
            Console.WriteLine("Creating people counting sensor " + ID);
        }

        public override void pollForData()
        {
            Console.WriteLine("Polling for new data from people counting sensor " + ID);
            string value = Utility.getRawJSon("http://hummingbird.feit.uts.edu.au:8080/peopleCounterApi/live/" + ID);
            reading = JsonConvert.DeserializeObject<PeopleCounterReading>(value);
            base.pollForData();
        }


        public int getCurrentPeopleCount()
        {
            return reading.getCurrentPeopleCount();
        }
    }
}