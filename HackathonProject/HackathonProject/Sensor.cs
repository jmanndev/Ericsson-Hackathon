using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Sensor
    {
        protected string ID { get; set; }

        public Sensor(string ID)
        {
            this.ID = ID;
        }

    }
}
