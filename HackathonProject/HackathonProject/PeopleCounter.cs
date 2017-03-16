using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class PeopleCounter : Sensor
    {
        string baseURL = "http://hummingbird.feit.uts.edu.au:8080/peopleCounterApi/live/";
        LinkedList<DataAtTime> peopleCounterReadings = new LinkedList<DataAtTime>();

        public PeopleCounter (string ID) : base(ID)
        {
            string value = Utility.getRawJSon(baseURL + ID);
        }
        
    }
}