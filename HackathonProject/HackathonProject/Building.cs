using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Building
    {
        string ID;
        LinkedList<Room> rooms = new LinkedList<Room>();

        public Building(string ID)
        {
            this.ID = ID;
            populateBuildingData();
        }

        private void populateBuildingData()
        {
            addRoom("Room1", "PC0111-CafeWest", "ES_B_05_417_7C13");
            addRoom("Room2", "PCB102-LevelB1WesternPCLabs1", "ES_B_02_412_3E68");
            addRoom("Room3", "PC0007-WattleStB10Entrance", "ES_B_09_425_3E8D");
            addRoom("Room4", "PC0420-Classroom400", "ES_A_09_226_44DF");
            addRoom("Room5", "PC1133-Level11StairsUp", "ES_B_06_418_7BED");
            addRoom("Room6", "PC1131-Level11BridgeEast", "ES_B_12_431_7BC2");
        }

        private void addRoom(string ID, string waspID, string peopleCounterID)
        {
            Room room = new Room(ID, waspID, peopleCounterID);
            rooms.AddLast(room);
        }
        
    }
}
