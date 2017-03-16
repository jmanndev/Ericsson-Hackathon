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
        {}

        public void pollForData()
        {
            string value = Utility.getRawJSon("http://hummingbird.feit.uts.edu.au:8080/peopleCounterApi/live/" + ID);
            base.pollForData();
        }

    }
}