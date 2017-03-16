using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Room
    {
        string roomID;
        Luminosity luminosity;
        Temperature temperature;
        PeopleCounter pc;

        public Room(string ID, string peopleCounterID, string waspID)
        {
            this.roomID = ID;
            temperature = new Temperature(waspID);
            luminosity = new Luminosity(waspID);
            pc = new PeopleCounter(peopleCounterID);
        }

        public void pollForRoomData()
        {
            temperature.pollForData();
            luminosity.pollForData();
            pc.pollForData();
        }

    }
}
