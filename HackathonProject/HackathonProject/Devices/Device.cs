using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class Device
    {
        public string name { get; set; }

        public Device(string name)
        {
            this.name = name;
        }

        public void sendDeviceCommand(string commandString)
        {
            Console.WriteLine("Command sent to DEVICE: " + name + " - " + commandString);
        }
    }
}
