using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class PeopleCounter : Sensor
    {
        public PeopleCounter (string ID) : base(ID)
        {
            Console.WriteLine("Creating people counting sensor " + ID);
        }

        public override void pollForData()
        {
            Console.WriteLine("Polling for new data from people counting sensor " + ID);
            string value = Utility.getRawJSon("http://hummingbird.feit.uts.edu.au:8080/peopleCounterApi/live/" + ID);
            base.pollForData();
        }

    }
}