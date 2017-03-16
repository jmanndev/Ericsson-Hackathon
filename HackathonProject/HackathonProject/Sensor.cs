using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class Sensor
    {
        protected int ID { get; set; }

        public Sensor(int ID)
        {
            this.ID = ID;
        }
    }
}
