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
        Temperature wasp;
        PeopleCounter pc;

        public Room(string ID, string peopleCounterID, string waspID)
        {
            this.roomID = ID;
            wasp = new Temperature(waspID);
            //pc = new PeopleCounter(peopleCounterID);
        }
    }
}
