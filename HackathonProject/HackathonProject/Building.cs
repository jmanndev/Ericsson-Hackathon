using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class Building
    {
        string ID;
        public List<Room> rooms = new List<Room>();

        public Building(string ID)
        {
            Console.WriteLine("Constructing building " + ID);
            this.ID = ID;
            populateBuildingData();

            Console.WriteLine("Building " + this.ID + " construction complete");
        }

        private void populateBuildingData()
        {
            Console.WriteLine("Populating building " + ID);
            addRoom("Room1", "PC0111-CafeWest", "ES_B_05_417_7C13");
            addRoom("Room2", "PCB102-LevelB1WesternPCLabs1", "ES_B_02_412_3E68");
            addRoom("Room3", "PC0007-WattleStB10Entrance", "ES_B_09_425_3E8D");
           // addRoom("Room4", "PC0420-Classroom400", "ES_A_09_226_44DF");
            addRoom("Room5", "PC1133-Level11StairsUp", "ES_B_06_418_7BED");
            addRoom("Room6", "PC1131-Level11BridgeEast", "ES_B_12_431_7BC2");

            Console.WriteLine("Building " + ID + " populated");
        }

        private void addRoom(string roomID, string waspID, string peopleCounterID)
        {
            Room room = new Room(roomID, waspID, peopleCounterID);
            rooms.Add(room);
        }

        public void pollForBuildingData()
        {
            Console.WriteLine("Polling building " + ID + " for latest readings");
            foreach(Room room in rooms)
            {
                room.updateSensorReadings();
            }

            Console.WriteLine("Polling complete for building " + ID);
        }
        
    }
}
